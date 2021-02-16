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

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
