using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FroggerGameFinal
{
    class Frog : GamePiece
    {
        public Frog(int x, int y)
            : base("frog" + x + y ,x,y,"frog.png", 50, 40, PictureBoxSizeMode.Zoom)
        {
        }
    }
}
