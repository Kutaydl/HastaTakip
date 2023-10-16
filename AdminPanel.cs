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

namespace HastaTakip
{
    public partial class AdminPanel : Form
    {
        DataSet dataSet = new DataSet();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public AdminPanel()
        {
            InitializeComponent();
            textBoxName.Focus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();

            this.Close();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();

            SqlConnection connect = new SqlConnection(conStr);
            

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
                labelTitle.Text = "Admin Paneli";
                labelName.Text = "İsim";
                labelPass.Text = "Şifre";
                buttonAdmin.Text = "Giriş";
                buttonCancel.Text = "İptal";
            }
            else
            {
                labelTitle.Text = "Admin Panel";
                labelName.Text = "Name";
                labelPass.Text = "Password";
                buttonAdmin.Text = "Login";
                buttonCancel.Text = "Cancel";
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            sha256 encode = new sha256();
            Databaseconnection constr = new Databaseconnection();
            string plainData = textBoxPass.Text;
            string hashedData = encode.ComputeSha256Hash(plainData);
            string conStr = constr.ConSource();

            SqlConnection connect = new SqlConnection(conStr);
            string check = "Select * from Admin Where Name=@id and Password=@pass";
            SqlCommand command = new SqlCommand(check, connect);

            command.Parameters.AddWithValue("@id", textBoxName.Text.Trim());
            command.Parameters.AddWithValue("@pass", hashedData);

            connect.Open();
            SqlDataReader reader = command.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
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
            if(count != 0)
            {
                Panelcontent panCon = new Panelcontent();
                panCon.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Giriş bilgileri hatalı");
            }
        }

        private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdmin.PerformClick();
            }
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdmin.PerformClick();
            }
        }
    }
}
