using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace FroggerGameFinal
{
    class GamePiece: PictureBox
    {
        public GamePiece(string pieceName, int x, int y, string imageFile, int width, int height, PictureBoxSizeMode mode) 
        {
            Name = pieceName;
            Size = new System.Drawing.Size(width, height);
            Location = new System.Drawing.Point(x, y);
            Image = Image.FromFile(imageFile);
            SizeMode = mode;

        }
        

    }
}
