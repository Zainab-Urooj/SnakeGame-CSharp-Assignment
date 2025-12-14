namespace SnakeGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            btnGameStart = new Button();
            label2 = new Label();
            btnDifficult = new Button();
            btnMedium = new Button();
            btnEasy = new Button();
            label1 = new Label();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.ForestGreen;
            pnlMenu.Controls.Add(btnGameStart);
            pnlMenu.Controls.Add(label2);
            pnlMenu.Controls.Add(btnDifficult);
            pnlMenu.Controls.Add(btnMedium);
            pnlMenu.Controls.Add(btnEasy);
            pnlMenu.Controls.Add(label1);
            pnlMenu.ForeColor = Color.FromArgb(255, 255, 128);
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(878, 544);
            pnlMenu.TabIndex = 0;
            // 
            // btnGameStart
            // 
            btnGameStart.BackColor = Color.FromArgb(255, 255, 128);
            btnGameStart.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGameStart.ForeColor = Color.ForestGreen;
            btnGameStart.Location = new Point(336, 450);
            btnGameStart.Name = "btnGameStart";
            btnGameStart.Size = new Size(177, 44);
            btnGameStart.TabIndex = 6;
            btnGameStart.Text = "Game Start";
            btnGameStart.UseVisualStyleBackColor = false;
            btnGameStart.Click += btnGameStart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(322, 140);
            label2.Name = "label2";
            label2.Size = new Size(209, 28);
            label2.TabIndex = 5;
            label2.Text = "Choose Difficulty Level";
            // 
            // btnDifficult
            // 
            btnDifficult.BackColor = Color.ForestGreen;
            btnDifficult.Font = new Font("Snap ITC", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDifficult.Location = new Point(295, 350);
            btnDifficult.Name = "btnDifficult";
            btnDifficult.Size = new Size(264, 60);
            btnDifficult.TabIndex = 4;
            btnDifficult.Text = "Difficult";
            btnDifficult.UseVisualStyleBackColor = false;
            btnDifficult.Click += btnDifficult_Click;
            
            // 
            // btnMedium
            // 
            btnMedium.BackColor = Color.ForestGreen;
            btnMedium.Font = new Font("Snap ITC", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMedium.Location = new Point(295, 270);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(261, 57);
            btnMedium.TabIndex = 3;
            btnMedium.Text = "Medium";
            btnMedium.UseVisualStyleBackColor = false;
            btnMedium.Click += btnMedium_Click;
           
            // 
            // btnEasy
            // 
            btnEasy.BackColor = Color.ForestGreen;
            btnEasy.Font = new Font("Snap ITC", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEasy.ForeColor = Color.FromArgb(255, 255, 128);
            btnEasy.Location = new Point(295, 187);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(261, 58);
            btnEasy.TabIndex = 2;
            btnEasy.Text = "Easy";
            btnEasy.UseVisualStyleBackColor = false;
            btnEasy.Click += btnEasy_Click;
           
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(226, 29);
            label1.Name = "label1";
            label1.Size = new Size(419, 73);
            label1.TabIndex = 1;
            label1.Text = "Snake Game";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(878, 544);
            Controls.Add(pnlMenu);
            KeyPreview = true;
            Name = "Form1";
            Text = "snake";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Label label1;
        private Button btnEasy;
        private Button btnMedium;
        private Label label2;
        private Button btnDifficult;
        private Button btnGameStart;
    }
}
