using System;
using System.Windows.Forms;

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
                securityQuest.Visible = true;
                securityQuestEn.Visible = false;                
            }
            else
            {
                labelSecure.Text = "Select and answer\nthe security question";
                labelMail.Text = "Mail";
                buttonAccept.Text = "Send";
                butonCancel.Text = "Cancel";
                securityQuest.Visible = false;
                securityQuestEn.Visible = true;
            }
        }

        private void securityQuestEn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if(securityQuest.SelectedIndex == 1 || securityQuestEn.SelectedIndex == 1)
            {
                this.Close();
            }
        }
    }
}
