using System;
using System.Windows.Forms;

namespace HastaTakip
{
    public partial class HastaSec : Form
    {
        public HastaSec()
        {
            InitializeComponent();
            string[] patient0 = { "1", "Kutay", "Dil", "E", "21", "186", "85", "ARh+", "07/11/2000", "kutaydil@gmail.com" };
            string[] patient1 = { "2", "Emre", "Tırak", "E", "20", "186", "73", "ARh+", "20/10/2001", "emretirak@hotmail.com" };
            string[] patient2 = { "3", "Amir", "Seyyedebbasi", "E", "~~", "~~", "~~", "~~", "~~", "~~" };

            dataGridHasta.Rows.Add(patient0);
            dataGridHasta.Rows.Add(patient1);
            dataGridHasta.Rows.Add(patient2);
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void languageSwi_CheckedChanged(object sender, EventArgs e)
        {
            if (languageSwi.Checked == true)
            {
                buttonCancel.Text = "İptal";
                buttonEdit.Text = "Düzenle";
                buttonSelect.Text = "Seç";
                hastaName.HeaderText = "İsim";
                patientAge.HeaderText = "Yaş";
                patientBirt.HeaderText = "Doğduğu Gün";
                patientBlood.HeaderText = "Kan Grubu";
                patientGender.HeaderText = "Cinsiyet";
                patientHeight.HeaderText = "Boy";
                patientWeight.HeaderText = "Kilo";
                hastaEmail.HeaderText = "E-posta";
                hastaSurname.HeaderText = "Soyisim";
                HastaNumara.HeaderText = "Hasta Numarası";
            }
            else
            {
                buttonCancel.Text = "Cancel";
                buttonEdit.Text = "Edit";
                buttonSelect.Text = "Select";
                hastaName.HeaderText = "Name";
                patientAge.HeaderText = "Age";
                patientBirt.HeaderText = "Date of Birth";
                patientBlood.HeaderText = "Blood Group";
                patientGender.HeaderText = "Gender";
                patientHeight.HeaderText = "Height";
                patientWeight.HeaderText = "Weight";
                hastaEmail.HeaderText = "Email";
                hastaSurname.HeaderText = "Surname";
                HastaNumara.HeaderText = "Patient Number";
            }
        }

        private void dataGridHasta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
