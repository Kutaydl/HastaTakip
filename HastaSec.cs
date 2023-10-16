using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HastaTakip
{
    public partial class HastaSec : Form
    {
        DataSet dataSet = new DataSet();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public HastaSec()
        {
            InitializeComponent();
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();
            SqlConnection connect = new SqlConnection(conStr);
            dataAdapter.SelectCommand = new SqlCommand("Select * from Patient", connect);
            dataSet.Clear();
            dataAdapter.Fill(dataSet);

            dataGridHasta.DataSource = dataSet.Tables[0];
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HastaSec_Load(object sender, EventArgs e)
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
                buttonCancel.Text = "İptal";
                buttonDelete.Text = "Sil";
                labelId.Text = "Hasta Numarası";
                labelEmail.Text = "Hasta Email";
                labelName.Text = "Hasta İsim";
                labelSurname.Text = "Hasta Soyisim";

                
                
            }
            else
            {
                buttonCancel.Text = "Cancel";
                buttonDelete.Text = "Delete";
                labelId.Text = "Patient Id";
                labelEmail.Text = "Patient Email";
                labelName.Text = "Patient Name";
                labelSurname.Text = "Patient Surname";

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();

            SqlConnection connect = new SqlConnection(conStr);
            string check = "Select * from Patient Where id=@id";
            SqlCommand command = new SqlCommand(check, connect);
            command.Parameters.AddWithValue("@id", textBoxPatid.Text.Trim());

            SqlConnection connect1 = new SqlConnection(conStr);
            string check1 = "Delete from Patient where id=@id";
            SqlCommand command1 = new SqlCommand(check1, connect1);
            command1.Parameters.AddWithValue("@id", textBoxPatid.Text.Trim());

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
                dataAdapter.SelectCommand = new SqlCommand("Select * from Patient", connect2);
                dataSet.Clear();
                dataAdapter.Fill(dataSet);

                dataGridHasta.DataSource = dataSet.Tables[0];
                textBoxPatid.Text = "";
            }
            else
            {
                MessageBox.Show("Bu numaraya sahip kişi sistemde yok");
            }
            connect.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();

            SqlConnection connect = new SqlConnection(conStr);
            string check = "UPDATE Patient SET clientName=@name , clientSurname=@sname , email=@mail WHERE id=@id";
            SqlCommand command = new SqlCommand(check, connect);
            command.Parameters.AddWithValue("@id", textBoxPatid.Text.Trim());
            command.Parameters.AddWithValue("@name", textBoxName.Text.Trim());
            command.Parameters.AddWithValue("@sname", textBoxSurname.Text.Trim());
            command.Parameters.AddWithValue("@mail", textBoxEmail.Text.Trim());

            SqlConnection connect1 = new SqlConnection(conStr);
            string check1 = "Select * from Patient Where id=@id";
            SqlCommand command1 = new SqlCommand(check1, connect1);
            command1.Parameters.AddWithValue("@id", textBoxPatid.Text.Trim());

            connect1.Open();
            SqlDataReader reader = command1.ExecuteReader();
            
            int count = 0;
            while (reader.Read())
            {
                count++;
            }

            if (textBoxPatid.TextLength != 0 && textBoxName.TextLength != 0 && textBoxSurname.TextLength != 0 && textBoxEmail.TextLength != 0)
            {
                if(count != 0)
                {
                    connect.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kişi başarıyla düzenlendi");
                    connect.Close();


                    SqlConnection connect2 = new SqlConnection(conStr);
                    dataAdapter.SelectCommand = new SqlCommand("Select * from Patient", connect2);
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet);

                    dataGridHasta.DataSource = dataSet.Tables[0];

                    textBoxPatid.Text = "";
                    textBoxName.Text = "";
                    textBoxEmail.Text = "";
                    textBoxSurname.Text = "";

                }
                else
                {
                    MessageBox.Show("Bu numaraya sahip hasta sistemde bulunamamaktadır");
                }
                connect1.Close();
            }
            else
            {
                MessageBox.Show("Lütfen tüm kutucukları doldurun");
            }
            
        }
    }
}
