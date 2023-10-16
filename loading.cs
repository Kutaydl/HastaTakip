using System;
using System.Windows.Forms;

namespace HastaTakip
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
            if (gunaLoading.Value == 0)
            {
                timerProgress.Start();
            }

        }
        private void gunaLoading_ValueChanged(object sender, EventArgs e)
        {


        }
        private void timerProgress_Tick(object sender, EventArgs e)
        {
            Random _random = new Random();
            int number = _random.Next(1, 10);
            gunaLoading.Increment(number);
            if (gunaLoading.Value == 100)
            {
                timerProgress.Stop();
                Anasayfa a1 = new Anasayfa();
                a1.Show();
                this.Hide();
            }
        }
    }
}
