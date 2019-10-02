using System;
using LearningDI.Interfaces;
using LearningDI.Models;
using SimpleInjector;

namespace LearningDI
{
    class Program
    {
        static readonly Container container;

        static Program()
        {
            container = DiSetup.Setup();
        }

        static void Main(string[] args)
        {
            var car = container.GetInstance<ICar>();

            car.StartCar();

            car.ChangeDirection();

            car.Accelerate();

        }
    }
}
