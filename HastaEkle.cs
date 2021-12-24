using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HastaTakip
{
    public partial class HastaEkle : Form
    {

        public HastaEkle()
        {
            InitializeComponent();
        }

        int timeLeft = 5;
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

        private void languageSwi_CheckedChanged(object sender, EventArgs e)
        {
            if (languageSwi.Checked == true)
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (hastaEkId.Text == "1")
            {
                foreach (var tb in this.Controls.OfType<Label>()) tb.Visible = false;
                foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2Button>()) tb.Visible = false;
                foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>()) tb.Visible = false;
                checkPicture.Visible = true;
                labelRegister.Visible = true;
                timerNum.Start();
            }

        }

        private void buttonHasCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
