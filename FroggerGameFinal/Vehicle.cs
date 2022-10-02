using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FroggerGameFinal
{
    class Vehicle : GamePiece
    {

        public enum VehicleDirection
        {
            Left2Right = 0,
            Right2Left = 1
        }

        public VehicleDirection Direction {get; set;}
        public int Speed { get; set; }

        public Vehicle(string pieceName, int x, int y, string imageFile, int width, int height, VehicleDirection direction)
            : base(pieceName + x + y, x, y, imageFile, width, height, PictureBoxSizeMode.StretchImage)
        {
            Direction = direction;
            Speed = 0;
        }
        public virtual void NextMove() 
        { 
            //No Movement
        }
    }
}
