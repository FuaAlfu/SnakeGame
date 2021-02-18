using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeGame
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };
    class GameSession
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static  Direction direction  { get; set; }

        public GameSession()
        {
            Width = 16; 
            Height = 16;
            Speed = 10;
            Points = 1000;
            direction = Direction.Down; 
        }

    }
}
