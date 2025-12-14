using System;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class instructions : Form
    {
        public instructions()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            main_screen gameForm = new main_screen();
            gameForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 mainMenu = new Form1();
            mainMenu.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            // empty
        }
    }
}
