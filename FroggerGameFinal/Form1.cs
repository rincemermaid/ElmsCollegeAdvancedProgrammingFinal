using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FroggerGameFinal
{
    public partial class Frogger : Form
    {
        Frog frogger;
        GamePiece grass1;
       
        List<Vehicle> vehicles = new List<Vehicle>();
       
        public Frogger()
        {
            InitializeComponent();
            
        }


        private List<GamePiece> buildRoads()
        {
            var roads = new List<GamePiece>();
            roads.Add(new GamePiece("road1", 0, 779, "street.png", MaximumSize.Width, 60, PictureBoxSizeMode.StretchImage));
            roads.Add(new GamePiece("road2", 0, 528, "street.png", MaximumSize.Width, 60, PictureBoxSizeMode.StretchImage));
            roads.Add(new GamePiece("road3", 0, 284, "street.png", MaximumSize.Width, 60, PictureBoxSizeMode.StretchImage));
            roads.Add(new GamePiece("road4", 0, 65, "street.png", MaximumSize.Width, 60, PictureBoxSizeMode.StretchImage));
            return roads;
        }
        private List<Vehicle> buildCarsLeft2Right()
        {
            var cars = new List<Vehicle>();
            cars.Add(new Car(0, 810, "car.png", 45, 31, Vehicle.VehicleDirection.Left2Right));
            cars.Add(new Car(45, 810, "car.png", 45, 31, Vehicle.VehicleDirection.Left2Right));
            cars.Add(new Car(2*45, 810, "car.png", 45, 31, Vehicle.VehicleDirection.Left2Right));
            return cars;
        }
        private List<Vehicle> buildCarsRight2Left() 
        {
            var cars = new List<Vehicle>();
            cars.Add(new Car((MaximumSize.Width - 65), 528, "car2.png", 45, 31, Vehicle.VehicleDirection.Right2Left));
            cars.Add(new Car((MaximumSize.Width - 65) - 45, 528, "car2.png", 45, 31, Vehicle.VehicleDirection.Right2Left));
            cars.Add(new Car((MaximumSize.Width - 65) - 2 * 45, 528, "car2.png", 45, 31, Vehicle.VehicleDirection.Right2Left));
            return cars;
        }
        private List<Vehicle> buildTruckssLeft2Right()
        {
            var trucks = new List<Vehicle>();
            trucks.Add(new Truck(0, 307, "truck.png", 95, 31, Vehicle.VehicleDirection.Left2Right));
            trucks.Add(new Truck(95, 307, "truck.png", 95, 31, Vehicle.VehicleDirection.Left2Right));
            trucks.Add(new Truck(95*2, 307, "truck.png", 95, 31, Vehicle.VehicleDirection.Left2Right));
            return trucks;
        }
        private List<Vehicle> buildTrucksRight2Left()
        {
            var trucks = new List<Vehicle>();
            trucks.Add(new Truck((MaximumSize.Width - 115), 65, "truck2.png", 95, 31, Vehicle.VehicleDirection.Right2Left));
            trucks.Add(new Truck((MaximumSize.Width - 115) - 95, 65, "truck2.png", 95, 31, Vehicle.VehicleDirection.Right2Left));
            trucks.Add(new Truck((MaximumSize.Width - 115) - 2 * 95, 65, "truck2.png", 95, 31, Vehicle.VehicleDirection.Right2Left));
            return trucks;
        }
        private void Frogger_Load(object sender, EventArgs e)
        {
          //DoubleBuffered Graphics
            DoubleBuffered = true;
            //Create Grass
            grass1 = new GamePiece("grass", 0, 0, "tileable_old_school_video_game_grass.jpg", MaximumSize.Width, MaximumSize.Height, PictureBoxSizeMode.StretchImage);
            //Create Roads
            var roads = buildRoads();
            //Create Frog
            frogger = new Frog(MaximumSize.Width/2, MaximumSize.Height-100);
            //Create Cars
            var carsL2R = buildCarsLeft2Right();
            var carsR2L = buildCarsRight2Left();
            //Add car to vehicles
            foreach (var car in carsL2R) 
            {
                vehicles.Add(car);
            }
            foreach (var car in carsR2L)
            {
                vehicles.Add(car);
            }
            //Create Trucks
            var trucksL2R = buildTruckssLeft2Right();
            var trucksR2L = buildTrucksRight2Left();
            //Add truck to vehicles
            foreach (var truck in trucksL2R) 
            {
                vehicles.Add(truck);
            }
            foreach (var truck in trucksR2L)
            {
                vehicles.Add(truck);
            }
            //Add pictureboxes into form
            //Add frogger
            this.Controls.Add(this.frogger);
            // Add vehicles
            foreach (var vehicle in vehicles) 
            {
                this.Controls.Add(vehicle);
            }
            //Add Roads
            foreach (var road in roads) 
            {
                this.Controls.Add(road);
            }
           //Add Grass
            this.Controls.Add(this.grass1); 
        }
        
        private void frogtimer_Tick(object sender, EventArgs e)
        {
            
            foreach (Control c in Controls) 
            {
                if ((c.Name.Contains("car") && c.Visible) || (c.Name.Contains("truck") && c.Visible))
                {
                    Vehicle vehicle = (Vehicle)c;
                    vehicle.NextMove();
                    if (vehicle.Bounds.IntersectsWith(frogger.Bounds))
                    {
                        //Collision with vehicle start over
                        frogger.Location = new System.Drawing.Point(MaximumSize.Width / 2, MaximumSize.Height - 100);
                        break;
                    }
                } 
            }


        }

        private void move_frog(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Right) && (frogger.Right < (Size.Width - frogger.Width / 4)))
            {
                frogger.Left += 5;
            }
            if ((e.KeyCode == Keys.Left) && (frogger.Left >= 0))
            {
                frogger.Left -= 5;
            }
            if ((e.KeyCode == Keys.Up) && (frogger.Top >= (frogger.Height / 4)))
            {
                frogger.Top -= 5;
            }
            if ((e.KeyCode == Keys.Down) && (frogger.Top < (Size.Height - frogger.Height)))
            {
                frogger.Top += 5;
            }
            //Check if frog is hitting the vehicles
            foreach (var vehicle in vehicles) 
            {
                if (vehicle.Bounds.IntersectsWith(frogger.Bounds)) 
                {
                    //Collision with vehicle start over
                    frogger.Location = new System.Drawing.Point(MaximumSize.Width / 2, MaximumSize.Height - 100);
                    break;
                }
            }
        }
    }
}
