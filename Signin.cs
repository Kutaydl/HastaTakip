using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace HastaTakip
{
    public partial class Signin : Form
    {
       
        public Signin()
        {
            InitializeComponent();
            
        }

        private void textBoxVerifyPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSignPassword.Text == textBoxVerifyPassword.Text)
            {
                verifyPassword.ForeColor = Color.Green;
                notEqual.Hide();
            }
            else if (textBoxVerifyPassword.Text.Length == 0)
            {
                verifyPassword.ForeColor = Color.Black;
                notEqual.Hide();
            }
            else
            {
                verifyPassword.ForeColor = Color.Red;
                notEqual.Show();
            }
        }

        private void checkBoxSign_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSign.Checked == true)
            {
                textBoxSignPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxSignPassword.UseSystemPasswordChar = true;
            }
        }

        private void checkBoxSignVerify_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSignVerify.Checked == true)
            {
                textBoxVerifyPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxVerifyPassword.UseSystemPasswordChar = true;
            }
        }

        private void languageSwi_CheckedChanged(object sender, EventArgs e)
        {
            if(languageSwi.Checked == true)
            {
                signInlabel.Text = "Kayıt ol";
                labelName.Text = "İsim";
                labelSurname.Text = "Soyisim";
                idSign.Text = "Kimlik Numarası";
                signPassword.Text = "Şifre";
                labelSecure.Text = "Güvenlik Sorusu";
                verifyPassword.Text = "Şifre Doğrulama";
                notEqual.Text = "Şifre eşleşmiyor";
                notEqual.Location = new Point(170, 325);
                this.Controls.Add(notEqual);
                buttonCancel.Text = "İptal";
                buttonSignfull.Text = "Kayıt ol";
                labelLang.Text = "Dil";
            }
            else
            {
                signInlabel.Text = "Sign in";
                labelName.Text = "Name";
                labelSurname.Text = "Surname";
                idSign.Text = "Identification Number";
                signPassword.Text = "Password";
                labelSecure.Text = "Security Question";
                verifyPassword.Text = "Verify Password";
                notEqual.Text = "your password does not match";
                notEqual.Location = new Point(77, 325);
                this.Controls.Add(notEqual);
                buttonCancel.Text = "Cancel";
                buttonSignfull.Text = "Sign in";
                labelLang.Text = "Language";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSignfull_Click(object sender, EventArgs e)
        {
            if (verifyPassword.ForeColor == Color.Green && textBoxVerifyPassword.Text.Length != 0 && textBoxSignPassword.Text.Length != 0)
            {
                if (textBoxEmail.TextLength == 0 || textBoxName.TextLength == 0 || textBoxSignId.TextLength == 0 || textBoxSurname.TextLength == 0 || secureAns.TextLength == 0 || securityBox.SelectedIndex.ToString() == "")
                {
                    MessageBox.Show("Boş alanları doldurun");
                    labelcheck.Visible = true;
                    labelcheck1.Visible = true;
                    labelcheck2.Visible = true;
                    labelcheck3.Visible = true;
                    labelcheck5.Visible = true;
                    labelcheck6.Visible = true;
                    labelcheck7.Visible = true;
                    labelcheck8.Visible = true;
                }
                else
                {
                    sha256 encode = new sha256();
                    Databaseconnection constr = new Databaseconnection();
                    string plainData = textBoxSignPassword.Text;
                    string hashedData = encode.ComputeSha256Hash(plainData);
                    string ques = securityBox.SelectedIndex.ToString();
                    string conStr = constr.ConSource();

                    SqlConnection connect = new SqlConnection(conStr);
                    SqlConnection connect1 = new SqlConnection(conStr);
                    SqlConnection connect2 = new SqlConnection(conStr);
                    SqlConnection connect3 = new SqlConnection(conStr);
                    SqlConnection connect4 = new SqlConnection(conStr);

                    string check1 = "Select * from Kayit Where idNumber=@id";
                    string check2 = "Select * from Kayit Where email=@mail";
                    SqlCommand command1 = new SqlCommand(check1, connect1);
                    SqlCommand command2 = new SqlCommand(check2, connect2);
                  
                    command1.Parameters.AddWithValue("@id", textBoxSignId.Text.Trim());
                    command2.Parameters.AddWithValue("@mail", textBoxEmail.Text.Trim());

                    string check3 = "Select * from language Where language='"+"1"+"'";
                    SqlCommand command3 = new SqlCommand(check3, connect3);
                    connect3.Open();
                    SqlDataReader reader2 = command3.ExecuteReader();
                    int count2 = 0;
                    while (reader2.Read())
                    {
                        count2++;
                    }
                    int readerdata = 0;
                    if(count2 == 0)
                    {
                        readerdata = 0;
                    }
                    else
                    {
                        readerdata = 1;
                    }

                    connect3.Close();
                    int languageData = 0;
                    if (languageSwi.Checked == true)
                    {
                        languageData = 1;
                    }
                    else
                    {
                        languageData = 0;
                    }

                    
                    string check4 = "update language set language='"+ languageData +"' where language='"+ readerdata +"'";
                    SqlCommand command4 = new SqlCommand(check4, connect4);

                    
                    string check = "insert into Kayit(idNumber, clientName, clientSurname, securityQ, securityA, password, email) values('" + textBoxSignId.Text.Trim() + "', '" + textBoxName.Text.Trim() + "', '" + textBoxSurname.Text.Trim() + "', '" + ques + "', '" + secureAns.Text.Trim() + "', '" + hashedData + "', '" + textBoxEmail.Text.Trim() + "')";
                    SqlCommand command = new SqlCommand(check, connect);

                    connect1.Open();
                    connect2.Open();
                    connect4.Open();


                    SqlDataReader reader = command1.ExecuteReader();
                    SqlDataReader reader1 = command2.ExecuteReader();

                    int count = 0;
                    int count1 = 0;
                    while (reader.Read()){
                        count++;
                    }
                    while (reader1.Read())
                    {
                        count1++;
                    }

                    if (count == 0 && count1 == 0)
                    {                        
                        connect1.Close();
                        connect2.Close();
                        connect.Open();
                        command4.ExecuteNonQuery();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Kişi başarılı şekilde kaydedildi");
                        this.Close();
                                               
                    }
                                     
                    else
                    {
                        if (count != 0 && count1 != 0)
                        {
                            MessageBox.Show("Bu id ve maile sahip kişi sistemde var");
                            
                        }
                        else if(count1 != 0)
                        {
                            MessageBox.Show("Bu maile sahip kişi sistemde var");
                        }
                        else if(count !=0)
                        {
                            MessageBox.Show("Bu idye sahip kişi sistemde var");
                        }
                        else
                        {
                            
                        }
                        
                    }

                    connect.Close();
                    connect1.Close();
                    connect2.Close();
                    connect4.Close();
                }
                
            }
            


        }

        private void textBoxSignPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void notEqual_Click(object sender, EventArgs e)
        {

        }

        private void verifyPassword_Click(object sender, EventArgs e)
        {

        }

        private void signPassword_Click(object sender, EventArgs e)
        {

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
