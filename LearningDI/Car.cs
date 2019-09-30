using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDI
{
    public class Car
    {
        public Motor Motor { get; set; }
        public Brake Brake { get; set; }
        public Transmission Transmission { get; set; }
        public bool IsOn { get; set; }
        public double Speed { get; set; }



        public void StartCar()
        {
            throw new NotImplementedException();
        }

        public void TurnOffCar()
        {
            throw new NotImplementedException();
        }

        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Decelerate()
        {
            throw new NotImplementedException();
        }


    }
}
