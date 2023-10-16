using System;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        

        private void cikis_Load(object sender, EventArgs e)
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
