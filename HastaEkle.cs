using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaTakip
{
    public partial class HastaEkle : Form
    {

        public HastaEkle()
        {
            InitializeComponent();
           
        }

        int timeLeft = 3;
        private void timerNum_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                timerNum.Stop();
                this.Close();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string[] bloodType = { "ARh+", "ARh-", "BRh+", "BRh-", "ABRh+", "ABRh-", "0Rh+", "0Rh-" };
            char[] gender = { 'E', 'K' };
            
            if (hastaEkId.TextLength != 0 || hastaEkEmail.TextLength != 0 || hastaEkName.TextLength != 0 || hastaEkSurname.TextLength != 0)
            {
                Databaseconnection constr = new Databaseconnection();
                string conStr = constr.ConSource();

                SqlConnection connect = new SqlConnection(conStr);
                SqlConnection connect1 = new SqlConnection(conStr);
                SqlConnection connect2 = new SqlConnection(conStr);


                string check1 = "Select * from Patient Where id=@id";
                
                SqlCommand command1 = new SqlCommand(check1, connect1);
                command1.Parameters.AddWithValue("@id", hastaEkId.Text.Trim());

                string check2 = "Select * from Patient Where email=@mail";
                SqlCommand command2 = new SqlCommand(check2, connect2);
                command2.Parameters.AddWithValue("@mail", hastaEkEmail.Text.Trim());

                numberCr randnum = new numberCr();
                int age = randnum.RandomNumber(2, 91);
                int height = randnum.heightNumber(age);
                int weight = randnum.weightNumber(age);
                int bloodnum = randnum.RandomNumber(0, 8);
                string clientBlty = bloodType[bloodnum];
                int gennum = randnum.RandomNumber(0, 2);
                string clientgen = gender[gennum].ToString();
                DateTime date = DateTime.Now;
                int currentyear = date.Year;
                int birthyear = currentyear - age;
                string clientbirth = randnum.dateGen(birthyear);

                string check = "insert into Patient(id, clientName, clientSurname, gender, age, height, weight, bloodType, birthdate, email) values('" + hastaEkId.Text.Trim() + "', '" + hastaEkName.Text.Trim() + "', '" + hastaEkSurname.Text.Trim() + "', '" + clientgen + "', '" + age.ToString() + "', '" + height.ToString() + "', '" + weight.ToString() + "', '" + clientBlty + "', '" + clientbirth + "', '" + hastaEkEmail.Text.Trim() + "')";
                SqlCommand command = new SqlCommand(check, connect);

                connect.Open();
                connect1.Open();
                connect2.Open(); 

                SqlDataReader reader = command1.ExecuteReader();
                SqlDataReader reader1 = command2.ExecuteReader();
                int count = 0;
                int count1 = 0;
                while (reader1.Read())
                {
                    count1++;

                }
                while (reader.Read())
                {
                    count++;
                }
                if(count == 0 && count1 == 0)
                {
                    command.ExecuteNonQuery();
                    connect.Close();
                    foreach (var tb in this.Controls.OfType<Label>()) tb.Visible = false;
                    foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2Button>()) tb.Visible = false;
                    foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>()) tb.Visible = false;
                    checkPicture.Visible = true;
                    labelRegister.Visible = true;
                    timerNum.Start();
                }
                else if (count != 0 && count1 != 0)
                {
                    MessageBox.Show("Bu bilgilere sahip hasta sistemde kayıtlı");
                }
                else if (count != 0)
                {
                    MessageBox.Show("Bu idye sahip hasta sistemde kayıtlı");
                }
                else
                {
                    MessageBox.Show("Bu maile sahip hasta sistemde kayıtlı");
                }


                
            }
            else
            {
                MessageBox.Show("Boş alanları doldurun");
                labelE.Show();
                labelN.Show();
                labelS.Show();
                labelI.Show();
            }

        }

        private void buttonHasCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HastaEkle_Load(object sender, EventArgs e)
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
            if (count == 1)
            {
                labelHastaEkName.Text = "İsim";
                labelHastaEkEmail.Text = "Mail";
                labelHastaEkSurname.Text = "Soyisim";
                labelHastaEkId.Text = "Kimlik Numarası";
                buttonSave.Text = "Kayıt";
                buttonHasCancel.Text = "İptal";
                labelRegister.Text = "Hasta kayıt edildi";
                labelRegister.Location = new Point(114, 204);
                this.Controls.Add(labelRegister);
            }
            else
            {
                labelHastaEkName.Text = "Name";
                labelHastaEkEmail.Text = "Email";
                labelHastaEkSurname.Text = "Surname";
                labelHastaEkId.Text = "Identification Number";
                buttonSave.Text = "Save";
                buttonHasCancel.Text = "Cancel";
                labelRegister.Text = "Patient was registered";
                labelRegister.Location = new Point(94, 204);
                this.Controls.Add(labelRegister);
            }
        }
    }
}
