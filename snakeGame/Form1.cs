using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakeGame
{
    public partial class Form1 : Form
    {
        //memory layout
        private List<Snake> snake = new List<Snake>();
        private Snake target = new Snake();
        public Form1()
        {
            InitializeComponent();

            //setup GameSession to default settings
            new GameSession();

            //game timer
            gameTimer.Interval = 1000 / GameSession.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            //begun with new game
            StartGame();
        }

        private void StartGame()
        {
            labelGameOver.visible = false;

            //rest setting
            new GameSession();

            //create new player
            snake.Clear();
            Snake head = new Snake { X = 10, Y = 5 };
            snake.Add(head);

            labelScore.Text = GameSession.Score.ToString();
            GenerateTarget();
        }

        private void GenerateTarget()
        {
            //random generating
            int maxXPosition = pbCanvas.Size.Width / GameSession.Width;
            int maxYPosition = pbCanvas.Size.Height / GameSession.Height;

            Random random = new Random();
            target = new Snake { X = random.Next(0, maxXPosition), Y = random.Next(0, maxYPosition) };
        }

        void ScreenUpdate()
        {
            //checking if game is over..
            if(GameSession.GameOver)
            {
                if(Input.Keypressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.Keypressed(Keys.Right) && GameSession.direction != Direction.Left)
                    GameSession.direction = Direction.Right;
                else if(Input.Keypressed(Keys.Left) && GameSession.direction != Direction.Right)
                    GameSession.direction = Direction.Left;
                else if (Input.Keypressed(Keys.Up) && GameSession.direction != Direction.Down)
                    GameSession.direction = Direction.Up;
                else if (Input.Keypressed(Keys.Down) && GameSession.direction != Direction.Up)
                    GameSession.direction = Direction.Down;

                PlayerMoveMent();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
