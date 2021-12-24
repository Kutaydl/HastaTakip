using System;
using System.Windows.Forms;

namespace HastaTakip
{
    public partial class cikis : Form
    {

        public cikis()
        {
            InitializeComponent();
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRed_MouseLeave(object sender, EventArgs e)
        {
            buttonNorm.Show();
        }

        private void buttonNorm_Click(object sender, EventArgs e)
        {

        }

        private void buttonNorm_MouseHover(object sender, EventArgs e)
        {
            buttonNorm.Hide();
        }

        private void acceptbutt_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cancelbutt_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void languageSwi_CheckedChanged(object sender, EventArgs e)
        {
            if (languageSwi.Checked == true)
            {
                acceptbutt.Text = "Evet";
                cancelbutt.Text = "Hayır";
                labelcikis.Text = "Çıkış yapmak" + "\n" + "istiyor musunuz?";

            }
            else
            {
                acceptbutt.Text = "Yes";
                cancelbutt.Text = "No";
                labelcikis.Text = "Are you sure" + "\n" + "you want to exit?";

            }
        }
    }
}
