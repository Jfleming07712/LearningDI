using System;
using Xunit;
using SimpleInjector;
using LearningDI.Interfaces;
using LearningDI.Models;

namespace LearningDI.Test
{
    public class CarTests
    {
        [Fact]
        public void Car_ShouldStart()
        {
            // Arrange
            var container = DiSetup.Setup();
            var car = container.GetInstance<ICar>();
            car.StartCar();
            // Act
            bool expected = true;
            bool actual = car.IsOn;
            // Assert 
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Car_ShouldTurnOff()
        {
            // Arrange
            var container = DiSetup.Setup();
            var car = container.GetInstance<ICar>();
            car.TurnOffCar();
            //Act
            bool actual = car.IsOn;
            // Assert
            Assert.False(actual);
        }
    }
}
