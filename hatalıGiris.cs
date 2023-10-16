using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Net;
using System.Net.Mail;
using System.Data;

namespace HastaTakip
{
    public partial class hatalıGiris : Form
    {

        public hatalıGiris()
        {
            InitializeComponent();
        }

        private void securityQuest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void languageSwi_CheckedChanged(object sender, EventArgs e)
        {
            if(languageSwi.Checked == true)
            {
                labelSecure.Text = "Güvenlik sorusunu\nseçiniz ve cevaplayınız";
                labelMail.Text = "Email";
                buttonAccept.Text = "Gönder";
                butonCancel.Text = "İptal";
                labelLang.Text = "Dil";


            }
            else
            {
                labelSecure.Text = "Select and answer\nthe security question";
                labelMail.Text = "Mail";
                buttonAccept.Text = "Send";
                butonCancel.Text = "Cancel";
                labelLang.Text = "Language";


            }
        }



        private void buttonAccept_Click(object sender, EventArgs e)
        {
            sha256 encode = new sha256();
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();
            string ques = securityQuest.SelectedIndex.ToString();

            SqlConnection connect = new SqlConnection(conStr);
            string check = "Select * from Kayit Where email=@email and securityQ=@sques and securityA=@sans";
            SqlCommand command = new SqlCommand(check, connect);

            command.Parameters.AddWithValue("@email", textBoxMail.Text);
            command.Parameters.AddWithValue("@sques", ques);
            command.Parameters.AddWithValue("@sans", securityAnswer.Text.Trim());

            connect.Open();
            SqlDataReader reader1 = command.ExecuteReader();


            while (reader1.Read())
            {

                try
                {

                    if (connect.State == ConnectionState.Closed)
                    {
                        connect.Open();
                    }
                    SmtpClient smptserver = new SmtpClient();
                    MailMessage message = new MailMessage();
                    string date = DateTime.Now.ToLongDateString();
                    string time = DateTime.Now.ToLongTimeString();
                    string mailaddress = "";
                    string password = "";
                    string mailserver = "smtp-mail.outlook.com";
                    string clientto = (reader1["email"].ToString());
                    string sub = ("Password reminder");
                    String maintext = ("Sayın " + reader1["clientName"].ToString() + " " + reader1["clientSurname"].ToString() + "\n" + date + " " + time + " tarihinde şifre hatırlatma talebinde bulundunuz." + "\n" + "Parolanız: " + reader1["password"].ToString() + "\nŞifrelerinize 3. şahıs ve bizim erişimimiz yoktur.\nŞifreniz yukarıda gösterildiği gibi tek taraflı (sha256) şifrelenmiştir. Lütfen size yazılımı sağlayan yetkili ile iletişime geçin.");
                    smptserver.Credentials = new NetworkCredential(mailaddress, password);
                    smptserver.Port = 587;
                    smptserver.Host = mailserver;
                    smptserver.EnableSsl = true;
                    message.From = new MailAddress(mailaddress);
                    message.To.Add(clientto);
                    message.Subject = sub;
                    message.Body = maintext;
                    smptserver.Send(message);
                    DialogResult info = new DialogResult();
                    info = MessageBox.Show("Email gönderildi");
                    this.Hide();
                    
                }
                catch (Exception Hata)
                {

                    MessageBox.Show("Bu bilgilere sahip kişi sistemde yok.", Hata.Message);
                    
                }

            } 
            
            
        }

        private void hatalıGiris_Load(object sender, EventArgs e)
        {
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();
            SqlConnection connect2 = new SqlConnection(conStr);
            string check2 = "Select * from language Where language='" + "1" + "'";
            SqlCommand command2 = new SqlCommand(check2, connect2);

            connect2.Open();

            SqlDataReader reader = command2.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if(count == 1)
            {
                labelSecure.Text = "Güvenlik sorusunu\nseçiniz ve cevaplayınız";
                labelMail.Text = "Email";
                buttonAccept.Text = "Gönder";
                butonCancel.Text = "İptal";                
                labelLang.Text = "Dil";
            }
            else
            {
                labelSecure.Text = "Select and answer\nthe security question";
                labelMail.Text = "Mail";
                buttonAccept.Text = "Send";
                butonCancel.Text = "Cancel";                
                labelLang.Text = "Language";
            }
        }

        private void languageSwi_MouseHover(object sender, EventArgs e)
        {
            labelLang.Visible = true;
        }

        private void languageSwi_MouseLeave(object sender, EventArgs e)
        {
            labelLang.Visible = false;
        }
    }
}
