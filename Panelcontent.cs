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
    public partial class Panelcontent : Form
    {
        DataSet dataSet = new DataSet();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public Panelcontent()
        {
            InitializeComponent();
        }

        private void Panelcontent_Load(object sender, EventArgs e)
        {
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();

            SqlConnection connect = new SqlConnection(conStr);
            
            dataAdapter.SelectCommand = new SqlCommand("Select * from Kayit", connect);
            dataSet.Clear();
            dataAdapter.Fill(dataSet);

            dataGridKayit.DataSource = dataSet.Tables[0];

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
                labelEmail.Text = "Email";
                labelId.Text = "Numara";
                labelName.Text = "İsim";
                labelSurname.Text = "Soyisim";
                buttonCancel.Text = "İptal";
                buttonDelete.Text = "Sil";
                buttonEdit.Text = "Düzenle";
            }
            else
            {
                labelEmail.Text = "Mail";
                labelId.Text = "Id";
                labelName.Text = "Name";
                labelSurname.Text = "Surname";
                buttonCancel.Text = "Cancel";
                buttonDelete.Text = "Delete";
                buttonEdit.Text = "Edit";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();

            SqlConnection connect = new SqlConnection(conStr);
            string check = "UPDATE Kayit SET clientName=@name , clientSurname=@sname , email=@mail WHERE idNumber=@id";
            SqlCommand command = new SqlCommand(check, connect);
            command.Parameters.AddWithValue("@id", textBoxId.Text.Trim());
            command.Parameters.AddWithValue("@name", textBoxName.Text.Trim());
            command.Parameters.AddWithValue("@sname", textBoxSurname.Text.Trim());
            command.Parameters.AddWithValue("@mail", textBoxEmail.Text.Trim());

            SqlConnection connect1 = new SqlConnection(conStr);
            string check1 = "Select * from Kayit Where idNumber=@id";
            SqlCommand command1 = new SqlCommand(check1, connect1);
            command1.Parameters.AddWithValue("@id", textBoxId.Text.Trim());

            connect1.Open();
            SqlDataReader reader = command1.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (textBoxId.TextLength != 0 && textBoxName.TextLength != 0 && textBoxSurname.TextLength != 0 && textBoxEmail.TextLength != 0)
            {
                if (count != 0)
                {
                    connect.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kişi başarıyla düzenlendi");
                    connect.Close();

                    SqlConnection connect2 = new SqlConnection(conStr);
                    dataAdapter.SelectCommand = new SqlCommand("Select * from Kayit", connect2);
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet);

                    dataGridKayit.DataSource = dataSet.Tables[0];

                    textBoxId.Text = "";
                    textBoxName.Text = "";
                    textBoxEmail.Text = "";
                    textBoxSurname.Text = "";

                }
                else
                {
                    MessageBox.Show("Bu numaraya sahip kullanıcı sistemde bulunamamaktadır");
                }
                connect1.Close();
            }
            else
            {
                MessageBox.Show("Lütfen tüm kutucukları doldurun");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();

            SqlConnection connect = new SqlConnection(conStr);
            string check = "Select * from Kayit Where idNumber=@id";
            SqlCommand command = new SqlCommand(check, connect);
            command.Parameters.AddWithValue("@id", textBoxId.Text.Trim());

            SqlConnection connect1 = new SqlConnection(conStr);
            string check1 = "Delete from Kayit Where idNumber=@id";
            SqlCommand command1 = new SqlCommand(check1, connect1);
            command1.Parameters.AddWithValue("@id", textBoxId.Text.Trim());

            connect.Open();
            connect1.Open();

            SqlDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count != 0)
            {
                command1.ExecuteNonQuery();
                MessageBox.Show("Kişi başarılı şekilde silindi");
                connect1.Close();

                SqlConnection connect2 = new SqlConnection(conStr);
                dataAdapter.SelectCommand = new SqlCommand("Select * from Kayit", connect2);
                dataSet.Clear();
                dataAdapter.Fill(dataSet);

                dataGridKayit.DataSource = dataSet.Tables[0];
                textBoxId.Text = "";
            }
            else
            {
                MessageBox.Show("Bu numaraya sahip kişi sistemde yok");
            }
            connect.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdminPanel adPa = new AdminPanel();
            adPa.Show();

            this.Close();
        }
    }
}
