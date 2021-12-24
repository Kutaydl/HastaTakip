using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HastaTakip
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
            string[] appo0 = { "Kutay", "Dil", "15/15/2015", "15:15" };
            string[] appo1 = { "Emre", "Tırak", "15/15/2015", "15:15" };
            string[] appo2 = { "Amir", "Seyyedebbasi", "15/15/2015", "15:15" };

            dataGridAppo.Rows.Add(appo0);
            dataGridAppo.Rows.Add(appo1);
            dataGridAppo.Rows.Add(appo2);
            pictureBoxAnaly.SizeMode = PictureBoxSizeMode.AutoSize;
            reportEx.SizeMode = PictureBoxSizeMode.AutoSize;
            
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
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            reportEx.Visible = true;
            dataGridAppo.Visible = false;
            pictureBoxAnaly.Visible = false;
            
        }  

        private void randevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridAppo.Visible = true;
            reportEx.Visible = false;            
            pictureBoxAnaly.Visible = false;
            
        }

        private void tahlillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxAnaly.Visible = true;            
            reportEx.Visible = false;           
            dataGridAppo.Visible = false;
            
        }
        
        private void Anasayfa_Load(object sender, EventArgs e)
        {
           
        }

        
    }
}
