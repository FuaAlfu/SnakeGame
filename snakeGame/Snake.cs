using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeGame
{
    class Snake
    {
        public int X { get; set; }
        public int Y { get; set; }

        //default constrauctor..
        public Snake()
        {
            X = 0;
            Y = 0;
        }
    }
}
