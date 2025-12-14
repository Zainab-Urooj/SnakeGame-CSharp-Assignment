namespace SnakeGame
{
    partial class instructions
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
            label1 = new Label();
            panel1 = new Panel();
            btnStart = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnExit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(31, 22);
            label1.Name = "label1";
            label1.Size = new Size(336, 51);
            label1.TabIndex = 0;
            label1.Text = "Instructions:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 544);
            panel1.TabIndex = 2;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(255, 255, 128);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.ForestGreen;
            btnStart.Location = new Point(739, 498);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 34);
            btnStart.TabIndex = 9;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(85, 434);
            label9.Name = "label9";
            label9.Size = new Size(465, 50);
            label9.TabIndex = 8;
            label9.Text = "If the snake collides with the wall or itself, the game ends.\r\nYou can restart from the Start Screen or press Restart.";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(85, 328);
            label8.Name = "label8";
            label8.Size = new Size(274, 50);
            label8.TabIndex = 7;
            label8.Text = "Do not hit the walls.\r\nDo not hit your own snake body.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(54, 285);
            label7.Name = "label7";
            label7.Size = new Size(225, 32);
            label7.TabIndex = 6;
            label7.Text = "3. Avoid Collisions";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(80, 217);
            label6.Name = "label6";
            label6.Size = new Size(515, 50);
            label6.TabIndex = 5;
            label6.Text = "The snake cannot move in the opposite direction instantly. \r\n(For example, if moving Up, you cannot go Down immediately.)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(53, 389);
            label5.Name = "label5";
            label5.Size = new Size(168, 32);
            label5.TabIndex = 4;
            label5.Text = "4. Game Over";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(54, 176);
            label4.Name = "label4";
            label4.Size = new Size(220, 32);
            label4.TabIndex = 3;
            label4.Text = "2. Do Not Reverse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(80, 136);
            label3.Name = "label3";
            label3.Size = new Size(523, 25);
            label3.TabIndex = 2;
            label3.Text = " Press Up, Down, Left, or Right to control the snake’s movement.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(53, 95);
            label2.Name = "label2";
            label2.Size = new Size(221, 32);
            label2.TabIndex = 1;
            label2.Text = "1. Use Arrow Keys";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 255, 128);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.ForestGreen;
            btnExit.Location = new Point(611, 498);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // instructions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(878, 544);
            Controls.Add(panel1);
            Name = "instructions";
            Text = "instructions";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnStart;
        private Button btnExit;
    }
}