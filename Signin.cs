using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSignfull_Click(object sender, EventArgs e)
        {
            if(securityBox.SelectedIndex == 1)
            {
                this.Close();
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
    }
}
