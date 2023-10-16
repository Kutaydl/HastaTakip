using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;



namespace HastaTakip
{
    public partial class Giris : Form
    {
        
        int sayac = 0;

        public Giris()
        {
            InitializeComponent();
            textBoxId.Focus();            
        }              

        private void exitbuttnor_MouseHover(object sender, EventArgs e)
        {
            exitbuttnor.Hide();
            exitbutt.Show();
        }

        private void exitbutt_MouseLeave(object sender, EventArgs e)
        {
            exitbutt.Hide();
            exitbuttnor.Show();
        }

        private void exitbutt_Click(object sender, EventArgs e)
        {
            cikis c1 = new cikis();
            c1.ShowDialog();

        }

        private void changePass_MouseHover(object sender, EventArgs e)
        {
            changePass.ForeColor = Color.Blue;
        }

        private void changePass_MouseLeave(object sender, EventArgs e)
        {
            changePass.ForeColor = Color.DimGray;
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            hatalıGiris h1 = new hatalıGiris();
            h1.ShowDialog();
        }

        private void passwrCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (passwrCheck.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void languageSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (languageSwitch.Checked == true)
            {
                if (labelPassword.Text == "Password")
                {
                    labelTC.Text = "Kimlik Numarası";
                    labelPassword.Text = "Şifre";
                    buttonLogin.Text = "Giriş";
                    buttonSign.Text = "Kayıt ol";
                    labelWrong.Text = "Hatalı mail veya şifre";
                    changePass.Text = "Şifrenizi mi unuttunuz?";
                    changePass.Location = new Point(152, 94);
                    this.Controls.Add(changePass);
                }
            }
            else
            {
                if (labelPassword.Text == "Şifre")
                {
                    labelTC.Text = "Identification Number";
                    labelPassword.Text = "Password";
                    buttonLogin.Text = "Login";
                    buttonSign.Text = "Sign in";
                    labelWrong.Text = "Wrong email or password";
                    changePass.Text = "Forgot Password?";
                    changePass.Location = new Point(172, 94);
                    this.Controls.Add(changePass);
                }
            }
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            sha256 encode = new sha256();
            Databaseconnection constr = new Databaseconnection();
            string plainData = textBoxPassword.Text;
            string hashedData = encode.ComputeSha256Hash(plainData);
            string conStr = constr.ConSource();

            SqlConnection connect = new SqlConnection(conStr);
            string check = "Select * from Kayit Where idNumber=@id and password=@pass";
            SqlCommand command = new SqlCommand(check, connect);

            command.Parameters.AddWithValue("@id", textBoxId.Text.Trim());
            command.Parameters.AddWithValue("@pass", hashedData);

            connect.Open();
            SqlDataReader reader = command.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                try
                {
                    if(connect.State == ConnectionState.Closed)
                    {
                        connect.Open();
                    }
                    count++;
                }
                catch
                {
                    count++;
                }
                
            }
            if (count == 1 || count > 1)
            {
                connect.Close();
                loading l1 = new loading();
                l1.Show();
                this.Hide();
               
            }
            else
            {
                textBoxId.Text = "";
                textBoxPassword.Text = "";
                connect.Close();
                labelWrong.Show();
                sayac++;
                if(sayac == 5)
                {
                    labelCountdown.Show();
                    labelWrong.Hide();
                    timerCountdown.Start();
                }
            }

            



        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            Signin s1 = new Signin();
            s1.ShowDialog();
        }
        int timeLeft = 20;
        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                labelCountdown.Text = timeLeft + "";

            }
            else
            {
                labelCountdown.Hide();
                sayac = 0;
                timerCountdown.Stop();

            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2Button>()) tb.Visible = false;
            foreach (var tb in this.Controls.OfType<Label>()) tb.Visible = false;
            foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>()) tb.Visible = false;
            foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2CheckBox>()) tb.Visible = false;
            foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2ToggleSwitch>()) tb.Visible = false;
            foreach (var tb in this.Controls.OfType<PictureBox>()) tb.Visible = false;
            formShape.BorderRadius = 500;
            pictureLoad.Show();
            labelLoad.Show();
            timerLoad.Start();
        }
        int loadLeft = 3;
        private void timerLoad_Tick(object sender, EventArgs e)
        {
            if (loadLeft > 0)
            {
                loadLeft--;
            }
            else
            {
                foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2Button>()) tb.Visible = true;
                foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>()) tb.Visible = true;
                foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2CheckBox>()) tb.Visible = true;
                foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2ToggleSwitch>()) tb.Visible = true;
                foreach (var tb in this.Controls.OfType<PictureBox>()) tb.Visible = true;
                labelTC.Show();
                formShape.BorderRadius = 0;
                labelPassword.Show();
                changePass.Show();
                pictureLoad.Hide();
                labelLoad.Hide();
                timerLoad.Stop();
            }
        }

        private void pictureLoad_Click(object sender, EventArgs e)
        {

        }

        private void textBoxId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }
    }
}
