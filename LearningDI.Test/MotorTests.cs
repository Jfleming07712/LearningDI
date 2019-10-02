using System;
using System.Collections.Generic;
using System.Text;
using LearningDI.Interfaces;
using LearningDI.Models;
using Xunit;


namespace LearningDI.Test
{
    public class MotorTests
    {
        [Fact]
        public void Motor_ShouldReturnRPM()
        {
            // Arrange
            var container = DiSetup.Setup();
            var motor = container.GetInstance<IMotor>();
            // Act
            var expected = 1000;
            var actual = motor.GetRPM();
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Motor_ShouldThrottleUp()
        {
            // Arrange
            var container = DiSetup.Setup();
            var motor = container.GetInstance<IMotor>();
            motor.ThrottleUp();
            // Act
            var expected = 2000;
            var actual = motor.GetRPM();
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Motor_ShouldThrottleDown()
        {
            // Arrange
            var container = DiSetup.Setup();
            var motor = container.GetInstance<IMotor>();
            motor.ThrottleDown();
            // Act
            var expected = 0;
            var actual = motor.GetRPM();
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
