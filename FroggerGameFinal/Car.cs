using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FroggerGameFinal
{
    class Car: Vehicle
    { 
        public Car(int x, int y, string imageFile, int width, int height, VehicleDirection direction)
            : base("car" + x + y, x, y, imageFile, width, height, direction)
        {
            Speed = 5;
        }
        public override void NextMove() 
        {
            if (Direction == VehicleDirection.Left2Right)
            {
                this.Left += Speed;
                //Check to see if we are at the end of the road
                if (this.Left >= this.Parent.Size.Width)
                {
                    this.Left = -Size.Width;
                    //Triple the Speed
                    Speed *= 3;
                    //Reset when speed gets greater than 100
                    if (Speed >= 100)
                    {
                        Speed = 5;
                    }
                }
            }
            else if (Direction == VehicleDirection.Right2Left) 
            {
                this.Left -= Speed;
                //Check to see if we are at the end of the road
                if (this.Right <= 0)
                {
                    this.Left = this.Parent.Size.Width;
                    //Double the Speed
                    Speed *= 2;
                    //Reset when speed gets greater than 100
                    if (Speed >= 100)
                    {
                        Speed = 5;
                    }
                }
            }
        }

        
    }
}
