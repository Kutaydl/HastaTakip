using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.IO;

namespace HastaTakip
{
    public partial class Anasayfa : Form
    {
        DataSet dataSet = new DataSet();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataSet dataSet1 = new DataSet();
        SqlDataAdapter dataAdapter1 = new SqlDataAdapter();
        DataSet dataSet2 = new DataSet();
        SqlDataAdapter dataAdapter2 = new SqlDataAdapter();

        public Anasayfa()
        {
            InitializeComponent();
            

        }
        public void ClearScreen()
        {
            foreach (var tb in this.Controls.OfType<Label>()) tb.Visible = false;
            foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2Button>()) tb.Visible = false;
            foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>()) tb.Visible = false;
            foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2DataGridView>()) tb.Visible = false;
            foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2DateTimePicker>()) tb.Visible = false;
            foreach (var tb in this.Controls.OfType<Guna.UI2.WinForms.Guna2ComboBox>()) tb.Visible = false;
        }
        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaEkle H1 = new HastaEkle();
            H1.ShowDialog();
        }

        private void selectPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaSec H2 = new HastaSec();
            H2.ShowDialog();
        }

        private void turkishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();
            SqlConnection connect3 = new SqlConnection(conStr);
            SqlConnection connect4 = new SqlConnection(conStr);
            string check3 = "Select * from language Where language='" + "1" + "'";
            SqlCommand command3 = new SqlCommand(check3, connect3);
            connect3.Open();
            SqlDataReader reader2 = command3.ExecuteReader();
            int count2 = 0;
            while (reader2.Read())
            {
                count2++;
            }
            int readerdata = 0;
            if (count2 == 0)
            {
                readerdata = 0;
            }
            else
            {
                readerdata = 1;
            }
            int languageData = 1;
            connect3.Close();
            string check4 = "update language set language='" + languageData + "' where language='" + readerdata + "'";
            SqlCommand command4 = new SqlCommand(check4, connect4);

            connect4.Open();
            command4.ExecuteNonQuery();
            connect4.Close();
            if (turkishToolStripMenuItem.Text == "Turkish")
            {
                turkishToolStripMenuItem.Text = "Türkçe";
                englishToolStripMenuItem.Text = "İngilizce";
                addPatientToolStripMenuItem.Text = "Hasta Ekle";
                exitAplicationToolStripMenuItem.Text = "Uygulamadan Çıkış";
                logOutToolStripMenuItem.Text = "Hesaptan Çıkış";
                exitToolStripMenuItem.Text = "Çıkış";
                languageToolStripMenuItem.Text = "Dil";
                patientToolStripMenuItem.Text = "Hasta";
                selectPatientToolStripMenuItem.Text = "Hasta Seç";
                tahlillerToolStripMenuItem.Text = "Tahliller";
                raporToolStripMenuItem.Text = "Rapor";     
                randevularToolStripMenuItem.Text = "Randevular";
                labelPicker.Text = "Randevu zamanı";
                labelDoc.Text = "Doktor ismi";
                labelId.Text = "Hasta Numarası";
                buttonAdd.Text = "Ekle";
                buttonDisplay.Text = "Yenile";
                labelTime.Text = "Saat";                
                buttonDelete.Text = "Sil";
                adminPanelItem.Text = "Admin Paneli";
                buttonBrowse.Text = "Seç";
                labelBrowse.Text = "Seçilen Dosya";
                buttonSave.Text = "Kayıt";
                buttonRepoDis.Text = "Yenile";
                buttonOpen.Text = "Dosya Aç";
                labelAnaBr.Text = "Seçilen Dosya";
                buttonAnaBrowse.Text = "Seç";
                buttonAnaDisplay.Text = "Yenile";
                buttonAnaSave.Text = "Kayıt";
                buttonAnaOpen.Text = "Dosya Aç";
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();
            SqlConnection connect3 = new SqlConnection(conStr);
            SqlConnection connect4 = new SqlConnection(conStr);
            string check3 = "Select * from language Where language='" + "1" + "'";
            SqlCommand command3 = new SqlCommand(check3, connect3);
            connect3.Open();
            SqlDataReader reader2 = command3.ExecuteReader();
            int count2 = 0;
            while (reader2.Read())
            {
                count2++;
            }
            int readerdata = 0;
            if (count2 == 0)
            {
                readerdata = 0;
            }
            else
            {
                readerdata = 1;
            }
            int languageData = 0;
            connect3.Close();
            string check4 = "update language set language='" + languageData + "' where language='" + readerdata + "'";
            SqlCommand command4 = new SqlCommand(check4, connect4);

            connect4.Open();
            command4.ExecuteNonQuery();
            connect4.Close();

            if (turkishToolStripMenuItem.Text == "Türkçe")
            {
                turkishToolStripMenuItem.Text = "Turkish";
                englishToolStripMenuItem.Text = "English";
                addPatientToolStripMenuItem.Text = "Add Patient";
                exitAplicationToolStripMenuItem.Text = "Exit Application";
                logOutToolStripMenuItem.Text = "Log out";
                exitToolStripMenuItem.Text = "Exit";
                languageToolStripMenuItem.Text = "Language";
                patientToolStripMenuItem.Text = "Patient";
                selectPatientToolStripMenuItem.Text = "Select Patient";
                tahlillerToolStripMenuItem.Text = "Analyzes";
                raporToolStripMenuItem.Text = "Report";              
                randevularToolStripMenuItem.Text = "Appointments";
                labelPicker.Text = "Date";
                labelDoc.Text = "Doctor Name";
                labelId.Text = "Patient Id";
                buttonAdd.Text = "Add";
                buttonDisplay.Text = "Display";
                labelTime.Text = "Time";                
                buttonDelete.Text = "Delete";
                adminPanelItem.Text = "Admin Panel";
                buttonBrowse.Text = "Browse";
                labelBrowse.Text = "Selected File";
                buttonSave.Text = "Save";
                buttonRepoDis.Text = "Display";
                buttonOpen.Text = "Open File";
                labelAnaBr.Text = "Selected File";
                buttonAnaBrowse.Text = "Browse";
                buttonAnaDisplay.Text = "Display";
                buttonAnaSave.Text = "Save";
                buttonAnaOpen.Text = "Open File";

            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giris g1 = new Giris();
            g1.Show();
            this.Close();
        }

        private void exitAplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cikis c1 = new cikis();
            c1.ShowDialog();
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            labelDate.Text = "" + DateTime.Now.ToString("dd/MM/yyyy\nHH:mm:ss");
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearScreen();
            labelDate.Visible = true;
            buttonBrowse.Visible = true;
            labelBrowse.Visible = true;
            buttonSave.Visible = true;
            buttonRepoDis.Visible = true;
            dataGridRepo.Visible = true;
            buttonOpen.Visible = true;

        }  

        private void randevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearScreen();
            labelDate.Visible = true;
            dataGridAppo.Visible = true;            
            labelDoc.Visible = true;
            labelId.Visible = true;
            labelPicker.Visible = true;
            textBoxDoc.Visible = true;
            textBoxPatId.Visible = true;
            dateTimePicker.Visible = true;
            buttonAdd.Visible = true;
            buttonDisplay.Visible = true;
            labelTime.Visible = true;
            timePicker.Visible = true;
            buttonDelete.Visible = true;
            

        }

        private void tahlillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearScreen();
            labelDate.Visible = true;
            labelAnaBr.Visible = true;
            buttonAnaBrowse.Visible = true;
            buttonAnaDisplay.Visible = true;
            buttonAnaSave.Visible = true;
            buttonAnaOpen.Visible = true;
            dataGridAna.Visible = true;

            
        }
        
        private void Anasayfa_Load(object sender, EventArgs e)
        {            
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();

            SqlConnection connect = new SqlConnection(conStr);
            dataAdapter.SelectCommand = new SqlCommand("Select * from Appointment", connect);
            dataSet.Clear();
            dataAdapter.Fill(dataSet);

            dataGridAppo.DataSource = dataSet.Tables[0];

            SqlConnection connect3 = new SqlConnection(conStr);
            dataAdapter1.SelectCommand = new SqlCommand("Select * from Reports", connect3);
            dataSet1.Clear();
            dataAdapter1.Fill(dataSet1);

            dataGridRepo.DataSource = dataSet1.Tables[0];

            SqlConnection connect4 = new SqlConnection(conStr);
            dataAdapter2.SelectCommand = new SqlCommand("Select * from Analyzes", connect4);
            dataSet2.Clear();
            dataAdapter2.Fill(dataSet2);

            dataGridAna.DataSource = dataSet2.Tables[0];



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
            if(count == 1)
            {
                turkishToolStripMenuItem.Text = "Türkçe";
                englishToolStripMenuItem.Text = "İngilizce";
                addPatientToolStripMenuItem.Text = "Hasta Ekle";
                exitAplicationToolStripMenuItem.Text = "Uygulamadan Çıkış";
                logOutToolStripMenuItem.Text = "Hesaptan Çıkış";
                exitToolStripMenuItem.Text = "Çıkış";
                languageToolStripMenuItem.Text = "Dil";
                patientToolStripMenuItem.Text = "Hasta";
                selectPatientToolStripMenuItem.Text = "Hasta Seç";
                tahlillerToolStripMenuItem.Text = "Tahliller";
                raporToolStripMenuItem.Text = "Rapor";
                randevularToolStripMenuItem.Text = "Randevular";
                labelPicker.Text = "Randevu zamanı";
                labelDoc.Text = "Doktor ismi";
                labelId.Text = "Hasta Numarası";
                buttonAdd.Text = "Ekle";
                buttonDisplay.Text = "Yenile";
                labelTime.Text = "Saat";                
                buttonDelete.Text = "Sil";
                adminPanelItem.Text = "Admin Paneli";
                buttonBrowse.Text = "Seç";
                labelBrowse.Text = "Seçilen Dosya";
                buttonSave.Text = "Kayıt";
                buttonRepoDis.Text = "Yenile";
                buttonOpen.Text = "Dosya Aç";
                labelAnaBr.Text = "Seçilen Dosya";
                buttonAnaBrowse.Text = "Seç";
                buttonAnaDisplay.Text = "Yenile";
                buttonAnaSave.Text = "Kayıt";
                buttonAnaOpen.Text = "Dosya Aç";
            }
            else
            {
                turkishToolStripMenuItem.Text = "Turkish";
                englishToolStripMenuItem.Text = "English";
                addPatientToolStripMenuItem.Text = "Add Patient";
                exitAplicationToolStripMenuItem.Text = "Exit Application";
                logOutToolStripMenuItem.Text = "Log out";
                exitToolStripMenuItem.Text = "Exit";
                languageToolStripMenuItem.Text = "Language";
                patientToolStripMenuItem.Text = "Patient";
                selectPatientToolStripMenuItem.Text = "Select Patient";
                tahlillerToolStripMenuItem.Text = "Analyzes";
                raporToolStripMenuItem.Text = "Report";
                randevularToolStripMenuItem.Text = "Appointments";
                labelPicker.Text = "Date";
                labelDoc.Text = "Doctor Name";
                labelId.Text = "Patient Id";
                buttonAdd.Text = "Add";
                buttonDisplay.Text = "Display";
                labelTime.Text = "Time";                
                buttonDelete.Text = "Delete";
                adminPanelItem.Text = "Admin Panel";
                buttonBrowse.Text = "Browse";
                labelBrowse.Text = "Selected File";
                buttonSave.Text = "Save";
                buttonRepoDis.Text = "Display";
                buttonOpen.Text = "Open File";
                labelAnaBr.Text = "Selected File";
                buttonAnaBrowse.Text = "Browse";
                buttonAnaDisplay.Text = "Display";
                buttonAnaSave.Text = "Save";
                buttonAnaOpen.Text = "Open File";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();

            SqlConnection connect4 = new SqlConnection(conStr);
            string check4 = "Select * from Patient Where id=@id";
            SqlCommand command4 = new SqlCommand(check4, connect4);
            command4.Parameters.AddWithValue("@id", textBoxPatId.Text.Trim());

            SqlConnection connect = new SqlConnection(conStr);           
            string check = "Select * from Appointment Where patientId=@id";
            SqlCommand command = new SqlCommand(check, connect);
            command.Parameters.AddWithValue("@id", textBoxPatId.Text.Trim());

            SqlConnection connect1 = new SqlConnection(conStr);
            string check1 = "Select * from Appointment Where appointmentDate=@date and appointmentTime=@time";
            SqlCommand command1 = new SqlCommand(check1, connect1);

            string date = dateTimePicker.Text.Trim();
            string time = timePicker.SelectedItem.ToString();
                        
            int result = DateTime.Compare(dateTimePicker.Value, DateTime.Now);

            connect4.Open();

            SqlDataReader reader2 = command4.ExecuteReader();
            int count3 = 0;
            while (reader2.Read())
            {
                count3++;
            }

            if (result == 0 || result > 0)
            {
                if (count3 != 0)
                {
                    command1.Parameters.AddWithValue("@date", date);
                    command1.Parameters.AddWithValue("@time", time);
                    connect.Open();
                    connect1.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    SqlDataReader reader1 = command1.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        count++;
                    }

                    int count1 = 0;
                    while (reader1.Read())
                    {
                        count1++;
                    }

                    if (count == 0 && count1 == 0)
                    {
                        SqlConnection connect2 = new SqlConnection(conStr);
                        string check2 = "insert into Appointment(patientId, doctorName, appointmentDate, appointmentTime) values('" + textBoxPatId.Text.Trim() + "', '" + textBoxDoc.Text.Trim() + "', '" + date + "', '" + time + "')";
                        SqlCommand command2 = new SqlCommand(check2, connect2);

                        connect2.Open();
                        command2.ExecuteNonQuery();
                        MessageBox.Show("Randevu kaydedildi");
                        connect2.Close();
                        connect.Close();
                        connect1.Close();
                        SqlConnection connect3 = new SqlConnection(conStr);
                        dataAdapter.SelectCommand = new SqlCommand("Select * from Appointment", connect3);
                        dataSet.Clear();
                        dataAdapter.Fill(dataSet);

                        dataGridAppo.DataSource = dataSet.Tables[0];
                        connect3.Close();

                        textBoxDoc.Text = "";
                        textBoxPatId.Text = "";
                        

                    }
                    else if (count != 0)
                    {
                        MessageBox.Show("Bu numaraya sahip hasta randevusu var");
                        textBoxPatId.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Bu tarihte randevu kaydı var");
                        
                    }

                    connect.Close();
                    connect1.Close();
                }
                else
                {
                    MessageBox.Show("Bu numaraya sahip kullanıcı sistemde bulunmamaktadır");
                }
                connect4.Close();
            }
            else
            {
                MessageBox.Show("Geçmiş bir tarih seçmeye çalıştınız");
                connect4.Close();
            }
                
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();
            SqlConnection connect = new SqlConnection(conStr);
            dataAdapter.SelectCommand = new SqlCommand("Select * from Appointment", connect);
            dataSet.Clear();
            dataAdapter.Fill(dataSet);

            dataGridAppo.DataSource = dataSet.Tables[0];
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();

            SqlConnection connect = new SqlConnection(conStr);
            string check = "Select * from Appointment Where patientId=@id";
            SqlCommand command = new SqlCommand(check, connect);
            command.Parameters.AddWithValue("@id", textBoxPatId.Text.Trim());

            SqlConnection connect1 = new SqlConnection(conStr);
            string check1 = "Delete from Appointment where patientId=@id";
            SqlCommand command1 = new SqlCommand(check1, connect1);
            command1.Parameters.AddWithValue("@id", textBoxPatId.Text.Trim());

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
                MessageBox.Show("Randevu başarılı şekilde silindi");
                connect1.Close();
                
                SqlConnection connect2 = new SqlConnection(conStr);
                dataAdapter.SelectCommand = new SqlCommand("Select * from Appointment", connect2);
                dataSet.Clear();
                dataAdapter.Fill(dataSet);

                dataGridAppo.DataSource = dataSet.Tables[0];

                textBoxDoc.Text = "";
                textBoxPatId.Text = "";
                
            }
            else
            {
                MessageBox.Show("Bu kişiye ait randevu bulunamamıştır");
                textBoxPatId.Text = "";
            }
            connect.Close();
        }

        private void adminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel adPa = new AdminPanel();
            this.Close();
            adPa.ShowDialog();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            labelBrowse.Text = dialog.FileName;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string Dname = "Reports";
            SaveFile(labelBrowse.Text, Dname);
            if (labelBrowse.Text.Length != 0)
            {
                MessageBox.Show("Başarılı şekilde kayıt edildi");
            }
            else
            {
                MessageBox.Show("Önce Dosya Seçin");
            }
            string Daname = "Reports";
            LoadData(Daname);
        }

        private void SaveFile(string filePath, String Dname)
        {
            if(labelBrowse.Text.Length != 0)
            {
                using (Stream stream = File.OpenRead(filePath))
                {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);

                    var file = new FileInfo(filePath);
                    string extn = file.Extension;
                    string name = file.Name;

                    string check = "insert into "+ Dname +"(fileName, extention, data) values(@filename, @extn, @data)";

                    Databaseconnection constr = new Databaseconnection();
                    string conStr = constr.ConSource();

                    SqlConnection connect = new SqlConnection(conStr);
                    SqlCommand command = new SqlCommand(check, connect);
                    command.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    command.Parameters.Add("@extn", SqlDbType.NVarChar).Value = extn;
                    command.Parameters.Add("@filename", SqlDbType.NVarChar).Value = name;
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Önce Dosya Seçin");
            }
           
        }

        private void buttonRepoDis_Click(object sender, EventArgs e)
        {
            string Dname = "Reports";
            LoadData(Dname);

        }

        private void LoadData(string Dname)
        {
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();

            SqlConnection connect = new SqlConnection(conStr);
            string check = "Select * from " + Dname;
            SqlDataAdapter adp = new SqlDataAdapter(check, connect);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridRepo.DataSource = dt;
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridRepo.SelectedRows;
            foreach(var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                string Dname = "Reports";
                OpenFile(id, Dname);
            }
        }

        private void OpenFile(int id, string Dname)
        {
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();

            SqlConnection connect = new SqlConnection(conStr);
            string check = "Select fileName, extention, data From "+ Dname + " where id=@id";
            SqlCommand command = new SqlCommand(check, connect);
            command.Parameters.Add("id", SqlDbType.Int).Value = id;
            connect.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                var name = reader["fileName"].ToString();
                var data = (byte[])reader["data"];
                var extn = reader["extention"].ToString();
                var newName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;

                File.WriteAllBytes(newName, data);

                System.Diagnostics.Process.Start(newName);
                connect.Close();
            }
        }

        private void buttonAnaBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            labelAnaBr.Text = dialog.FileName;
        }

        private void buttonAnaSave_Click(object sender, EventArgs e)
        {
            string Dname = "Analyzes";
            SaveFile(labelAnaBr.Text, Dname);
            if (labelAnaBr.Text.Length != 0)
            {
                MessageBox.Show("Başarılı şekilde kayıt edildi");
            }
            else
            {
                MessageBox.Show("Önce Dosya Seçin");
            }
            string Daname = "Analyzes";
            LoadData1(Daname);
        }

        private void buttonAnaOpen_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridAna.SelectedRows;
            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                string Dname = "Analyzes";
                OpenFile(id, Dname);
            }
        }

        private void buttonAnaDisplay_Click(object sender, EventArgs e)
        {
            string Dname = "Analyzes";
            LoadData1(Dname);
            
        }
        private void LoadData1(string Dname)
        {
            Databaseconnection constr = new Databaseconnection();
            string conStr = constr.ConSource();

            SqlConnection connect = new SqlConnection(conStr);
            string check = "Select * from " + Dname;
            SqlDataAdapter adp = new SqlDataAdapter(check, connect);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridAna.DataSource = dt;
            }
        }
    }
}
