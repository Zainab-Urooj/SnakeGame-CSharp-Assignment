using System;
using System.Windows.Forms;
using System.Drawing;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        public static int selectedSpeed = -1; // 0 = Easy, 1 = Medium, 2 = Difficult

        // Default button colors
        Color defaultBack = Color.ForestGreen;
        Color defaultFore = Color.Yellow;

        public Form1()
        {
            InitializeComponent();

            // UI load -> all buttons default colors (no selected highlight)
            btnEasy.BackColor = defaultBack;
            btnEasy.ForeColor = defaultFore;

            btnMedium.BackColor = defaultBack;
            btnMedium.ForeColor = defaultFore;

            btnDifficult.BackColor = defaultBack;
            btnDifficult.ForeColor = defaultFore;

            // Mouse Hover Events
            btnEasy.MouseEnter += btnEasy_MouseEnter;
            btnMedium.MouseEnter += btnMedium_MouseEnter;
            btnDifficult.MouseEnter += btnDifficult_MouseEnter;

            btnEasy.MouseLeave += btnEasy_MouseLeave;
            btnMedium.MouseLeave += btnMedium_MouseLeave;
            btnDifficult.MouseLeave += btnDifficult_MouseLeave;
        }

        // Helper function to highlight selected button
        private void SelectDifficultyButton(Button selectedBtn)
        {
            // Reset all buttons
            btnEasy.BackColor = defaultBack;
            btnEasy.ForeColor = defaultFore;

            btnMedium.BackColor = defaultBack;
            btnMedium.ForeColor = defaultFore;

            btnDifficult.BackColor = defaultBack;
            btnDifficult.ForeColor = defaultFore;

            // Highlight selected
            selectedBtn.BackColor = Color.Yellow;
            selectedBtn.ForeColor = Color.ForestGreen;
        }

        // Easy click
        private void btnEasy_Click(object sender, EventArgs e)
        {
            selectedSpeed = 0;
            SelectDifficultyButton(btnEasy);
        }

        // Medium click
        private void btnMedium_Click(object sender, EventArgs e)
        {
            selectedSpeed = 1;
            SelectDifficultyButton(btnMedium);
        }

        // Difficult click
        private void btnDifficult_Click(object sender, EventArgs e)
        {
            selectedSpeed = 2;
            SelectDifficultyButton(btnDifficult);
        }

        // Start game
        private void btnGameStart_Click(object sender, EventArgs e)
        {
            // If user never selected any button, default = Easy
            if (selectedSpeed == -1)
            {
                selectedSpeed = 0;
                SelectDifficultyButton(btnEasy);
            }

            loading_screen loadForm = new loading_screen();
            loadForm.Show();
            this.Hide();
        }

        // Mouse Enter animations (Hover)
        private void btnEasy_MouseEnter(object? sender, EventArgs e)
        {
            if (selectedSpeed != 0)
            {
                btnEasy.BackColor = Color.Yellow;
                btnEasy.ForeColor = Color.ForestGreen;
            }
        }

        private void btnMedium_MouseEnter(object? sender, EventArgs e)
        {
            if (selectedSpeed != 1)
            {
                btnMedium.BackColor = Color.Yellow;
                btnMedium.ForeColor = Color.ForestGreen;
            }
        }

        private void btnDifficult_MouseEnter(object? sender, EventArgs e)
        {
            if (selectedSpeed != 2)
            {
                btnDifficult.BackColor = Color.Yellow;
                btnDifficult.ForeColor = Color.ForestGreen;
            }
        }

        // Mouse Leave animations (un-highlight if not selected)
        private void btnEasy_MouseLeave(object? sender, EventArgs e)
        {
            if (selectedSpeed != 0)
            {
                btnEasy.BackColor = defaultBack;
                btnEasy.ForeColor = defaultFore;
            }
        }

        private void btnMedium_MouseLeave(object? sender, EventArgs e)
        {
            if (selectedSpeed != 1)
            {
                btnMedium.BackColor = defaultBack;
                btnMedium.ForeColor = defaultFore;
            }
        }

        private void btnDifficult_MouseLeave(object? sender, EventArgs e)
        {
            if (selectedSpeed != 2)
            {
                btnDifficult.BackColor = defaultBack;
                btnDifficult.ForeColor = defaultFore;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // empty
        }
    }
}
