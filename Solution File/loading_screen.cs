using System;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class loading_screen : Form
    {
        public loading_screen()
        {
            InitializeComponent();
        }

        private void loading_screen_Shown(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick; // ensure Tick event attach hai
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 2;
            }
            else
            {
                timer1.Stop();
                instructions instrForm = new instructions();
                instrForm.Show();
                this.Hide();
            }
        }
    }
}
