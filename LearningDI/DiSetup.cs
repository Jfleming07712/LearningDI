using System;
using System.Collections.Generic;
using System.Text;
using SimpleInjector;
using LearningDI.Interfaces;
using LearningDI.Models;

namespace LearningDI
{
    public static class DiSetup
    {
        public static Container Setup()
        {
            // 1. Create a new Simple Injector container
            var container = new Container();

            // 2. Configure the container (register)
            container.Register<IBrake, Brake>();
            container.Register<IMotor, Motor>();
            container.Register<ITire, Tire>();
            container.Register<ITransmission, Transmission>();
            container.Register<ICar, Car>();


            // 3. Verify your configuration
            container.Verify();

            return container;
        }
    }
}
