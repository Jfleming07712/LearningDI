using System;
using System.Collections.Generic;
using System.Text;
using LearningDI.Interfaces;
using LearningDI.Models;

namespace LearningDI.Models
{
    public class Car : ICar
    {
        public IMotor Motor { get; set; }
        public IBrake Brake { get; set; }
        public ITransmission Transmission { get; set; }
        public ITire Tire { get; set; }
        public bool IsOn { get; set; }
        public double Speed { get; set; }

        public Car(IMotor motor, IBrake brake, ITransmission transmission, ITire tire)
        {
            this.Motor = motor;
            this.Brake = brake;
            this.Transmission = transmission;
            this.Tire = tire;
        }


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

            Console.WriteLine("the car is going" + this.Tire.GetRollSpeed(this.Motor.GetRPM(), this.Transmission.GetDirection()) + "FPS");
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
