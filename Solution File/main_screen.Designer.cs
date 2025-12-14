namespace SnakeGame
{
    partial class main_screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlMainScreen = new Panel();
            lblLiveScore = new Label();
            lblHighScore = new Label();
            btnRestart = new Button();
            btnPauseResume = new Button();
            pnlSnakeGame = new Panel();
            lblGameOver = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlMainScreen.SuspendLayout();
            pnlSnakeGame.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainScreen
            // 
            pnlMainScreen.BackColor = Color.ForestGreen;
            pnlMainScreen.Controls.Add(lblLiveScore);
            pnlMainScreen.Controls.Add(lblHighScore);
            pnlMainScreen.Controls.Add(btnRestart);
            pnlMainScreen.Controls.Add(btnPauseResume);
            pnlMainScreen.Controls.Add(pnlSnakeGame);
            pnlMainScreen.Controls.Add(label1);
            pnlMainScreen.Dock = DockStyle.Fill;
            pnlMainScreen.Location = new Point(0, 0);
            pnlMainScreen.Name = "pnlMainScreen";
            pnlMainScreen.Size = new Size(878, 544);
            pnlMainScreen.TabIndex = 0;
            // 
            // lblLiveScore
            // 
            lblLiveScore.AutoSize = true;
            lblLiveScore.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLiveScore.ForeColor = Color.FromArgb(255, 255, 128);
            lblLiveScore.Location = new Point(30, 103);
            lblLiveScore.Name = "lblLiveScore";
            lblLiveScore.Size = new Size(109, 28);
            lblLiveScore.TabIndex = 5;
            lblLiveScore.Text = "Your Score:";
            lblLiveScore.Click += lblLiveScore_Click;
            // 
            // lblHighScore
            // 
            lblHighScore.AutoSize = true;
            lblHighScore.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHighScore.ForeColor = Color.FromArgb(255, 255, 128);
            lblHighScore.Location = new Point(30, 75);
            lblHighScore.Name = "lblHighScore";
            lblHighScore.Size = new Size(150, 28);
            lblHighScore.TabIndex = 4;
            lblHighScore.Text = "High Score: 100";
            lblHighScore.Click += lblHighScore_Click;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.FromArgb(255, 255, 128);
            btnRestart.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = Color.ForestGreen;
            btnRestart.Location = new Point(728, 109);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(112, 34);
            btnRestart.TabIndex = 3;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Visible = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnPauseResume
            // 
            btnPauseResume.BackColor = Color.FromArgb(255, 255, 128);
            btnPauseResume.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPauseResume.ForeColor = Color.ForestGreen;
            btnPauseResume.Location = new Point(728, 69);
            btnPauseResume.Name = "btnPauseResume";
            btnPauseResume.Size = new Size(112, 34);
            btnPauseResume.TabIndex = 2;
            btnPauseResume.Text = "Pause";
            btnPauseResume.UseVisualStyleBackColor = false;
            btnPauseResume.Click += btnPauseResume_Click;
            // 
            // pnlSnakeGame
            // 
            pnlSnakeGame.BackColor = Color.White;
            pnlSnakeGame.Controls.Add(lblGameOver);
            pnlSnakeGame.Location = new Point(12, 154);
            pnlSnakeGame.Name = "pnlSnakeGame";
            pnlSnakeGame.Size = new Size(854, 378);
            pnlSnakeGame.TabIndex = 1;
            pnlSnakeGame.Paint += pnlSnakeGame_Paint;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.Font = new Font("Snap ITC", 28F, FontStyle.Bold | FontStyle.Italic);
            lblGameOver.ForeColor = Color.FromArgb(192, 0, 0);
            lblGameOver.Location = new Point(212, 146);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(385, 73);
            lblGameOver.TabIndex = 0;
            lblGameOver.Text = "Game Over";
            lblGameOver.Visible = false;
            lblGameOver.Click += lblGameOver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 22F, FontStyle.Bold);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(334, 57);
            label1.TabIndex = 0;
            label1.Text = "Snake Game";
            // 
            // main_screen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(pnlMainScreen);
            Name = "main_screen";
            Text = "main_screen";
            pnlMainScreen.ResumeLayout(false);
            pnlMainScreen.PerformLayout();
            pnlSnakeGame.ResumeLayout(false);
            pnlSnakeGame.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMainScreen;
        private Label label1;
        private Button btnRestart;
        private Button btnPauseResume;
        private Panel pnlSnakeGame;
        private Label lblHighScore;
        private Label lblLiveScore;
        private Label lblGameOver;
        private System.Windows.Forms.Timer timer1;
    }
}