using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeGame
{
   internal class Input
    {
        //load available list of keys
        private static Hashtable keytable = new Hashtable();

        public static bool Keypressed(Keys k)
        {
            if(keytable[k] == null)
            {
                return false;
            }
            return (bool)keytable[k];
        }

        //single tone
        public static void Changestate(Keys k, bool state)
        {
            keytable[k] = state;
        }
    }
}
