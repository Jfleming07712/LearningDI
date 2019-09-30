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
            // 1. Create a new Simple Injector container
            container = new Container();

            // 2. Configure the container (register)
            container.Register<IBrake, Brake>();
            container.Register<IMotor, Motor>();
            container.Register<ITire, Tire>();
            container.Register<ITransmission, Transmission>();


            // 3. Verify your configuration
            container.Verify();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
