using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class main_screen : Form
    {
        private List<Point> snake = new List<Point>();
        private Point food;
        private int score = 0;
        private int highScore = 0;
        private int direction = 0; // 0=Right,1=Down,2=Left,3=Up
        private int snakeSpeed;
        private bool isPaused = false;

        Random rand = new Random();
        private int cellSize = 20; // Grid cell size
        private int rows;
        private int cols;

        private Bitmap gridBitmap; // Static grid bitmap

        public main_screen()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += main_screen_KeyDown;

            this.ActiveControl = null;
            this.Shown += (s, e) => { this.ActiveControl = null; };

            // Enable double buffering for panel to prevent grid flicker
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, pnlSnakeGame, new object[] { true });

            rows = pnlSnakeGame.Height / cellSize;
            cols = pnlSnakeGame.Width / cellSize;

            CreateGrid(); // Draw grid once
            StartNewGame();
        }

        private void pnlSnakeGame_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void CreateGrid()
        {
            gridBitmap = new Bitmap(pnlSnakeGame.Width, pnlSnakeGame.Height);
            using (Graphics g = Graphics.FromImage(gridBitmap))
            {
                Color gridColor = Color.FromArgb(100, 0, 0, 0); // 100 = alpha, 0-255
                using (Pen gridPen = new Pen(gridColor))
                {
                    for (int i = 0; i <= cols; i++)
                        g.DrawLine(gridPen, i * cellSize, 0, i * cellSize, pnlSnakeGame.Height);
                    for (int j = 0; j <= rows; j++)
                        g.DrawLine(gridPen, 0, j * cellSize, pnlSnakeGame.Width, j * cellSize);
                }
            }
        }
        private void StartNewGame()
        {
            switch (Form1.selectedSpeed)
            {
                case 0: snakeSpeed = 200; break;
                case 1: snakeSpeed = 100; break;
                case 2: snakeSpeed = 50; break;
                default: snakeSpeed = 200; break;
            }

            timer1.Interval = snakeSpeed;

            snake.Clear();
            snake.Add(new Point(5, 5)); // initial head
            GenerateFood();

            score = 0;
            lblLiveScore.Text = "Your Score: 0";
            lblHighScore.Text = "High Score: " + highScore;
            lblGameOver.Visible = false;
            btnRestart.Visible = false;

            timer1.Tick -= GameTick;
            timer1.Tick += GameTick;
            timer1.Start();
            this.ActiveControl = null;
            this.Focus();
        }

        private void GenerateFood()
        {
            food = new Point(rand.Next(0, cols), rand.Next(0, rows));
            pnlSnakeGame.Invalidate();
        }

        private void GameTick(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                MoveSnake();
                pnlSnakeGame.Invalidate();
            }
        }

        private void MoveSnake()
        {
            Point head = snake[0];
            Point newHead = head;

            switch (direction)
            {
                case 0: newHead.X += 1; break;
                case 1: newHead.Y += 1; break;
                case 2: newHead.X -= 1; break;
                case 3: newHead.Y -= 1; break;
            }

            if (newHead.X < 0 || newHead.Y < 0 || newHead.X >= cols || newHead.Y >= rows)
            {
                GameOver();
                return;
            }

            foreach (Point p in snake)
            {
                if (p.Equals(newHead))
                {
                    GameOver();
                    return;
                }
            }

            snake.Insert(0, newHead);

            if (newHead.Equals(food))
            {
                score += 10;
                lblLiveScore.Text = "Your Score: " + score;
                if (score > highScore) highScore = score;
                lblHighScore.Text = "High Score: " + highScore;
                GenerateFood();
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }
        }

        private void GameOver()
        {
            timer1.Stop();
            lblGameOver.Visible = true;
            btnRestart.Visible = true;
        }

        private void main_screen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                TogglePauseResume();

            if (e.KeyCode == Keys.Up && direction != 1) direction = 3;
            if (e.KeyCode == Keys.Down && direction != 3) direction = 1;
            if (e.KeyCode == Keys.Left && direction != 0) direction = 2;
            if (e.KeyCode == Keys.Right && direction != 2) direction = 0;
        }

        private void TogglePauseResume()
        {
            isPaused = !isPaused;
            btnPauseResume.Text = isPaused ? "Resume" : "Pause";
            if (!isPaused)
            {
                this.ActiveControl = null;
                this.Focus();
            }
        }

        private void btnPauseResume_Click(object sender, EventArgs e)
        {
            TogglePauseResume();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void pnlSnakeGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Draw static grid
            if (gridBitmap != null)
                g.DrawImage(gridBitmap, 0, 0);

            // Draw snake
            for (int i = 0; i < snake.Count; i++)
            {
                Brush snakeBrush = (i == 0) ? Brushes.Yellow : Brushes.ForestGreen;
                g.FillRectangle(snakeBrush, new Rectangle(snake[i].X * cellSize, snake[i].Y * cellSize, cellSize, cellSize));
            }

            // Draw food
            g.FillRectangle(Brushes.Red, new Rectangle(food.X * cellSize, food.Y * cellSize, cellSize, cellSize));
        }

        private void lblHighScore_Click(object sender, EventArgs e) { }
        private void lblLiveScore_Click(object sender, EventArgs e) { }

        private void lblGameOver_Click(object sender, EventArgs e)
        {
            Form1 mainMenu = new Form1();
            mainMenu.Show();
            this.Hide();
        }
    }
}
