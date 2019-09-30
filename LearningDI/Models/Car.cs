using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDI.Models
{
    public class Car
    {
        public Motor Motor { get; set; }
        public Brake Brake { get; set; }
        public Transmission Transmission { get; set; }
        public Tire Tire { get; set; }
        public bool IsOn { get; set; }
        public double Speed { get; set; }



        public void StartCar()
        {
            Console.WriteLine("Vroom vroom, the car is running");
        }

        public void TurnOffCar()
        {
            Console.WriteLine("Putter putter, the car is not running");
        }

        public void Accelerate()
        {
            this.Motor.ThrottleUp();

            Console.WriteLine("the car is going" +  this.Tire.GetRollSpeed(this.Motor.GetRPM(), this.Transmission.GetDirection()) + "FPS" );
        }

        public void Decelerate()
        {
            this.Motor.ThrottleDown();

            Console.WriteLine("the car is going" + this.Tire.GetRollSpeed(this.Motor.GetRPM(), this.Transmission.GetDirection()) + "FPS");
        }

        public void ChangeDirection()
        {
            Console.WriteLine("which direction should we go?");
            var direction = Console.ReadLine().ToString();

            this.Transmission.ChangeDirection(direction);
        }


    }
}
