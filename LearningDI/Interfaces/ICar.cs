using LearningDI.Interfaces;
using LearningDI.Models;

namespace LearningDI.Interfaces
{
    public interface ICar
    {
        IBrake Brake { get; set; }
        bool IsOn { get; set; }
        IMotor Motor { get; set; }
        double Speed { get; set; }
        ITire Tire { get; set; }
        ITransmission Transmission { get; set; }

        void Accelerate();
        void ChangeDirection();
        void Decelerate();
        void StartCar();
        void TurnOffCar();
    }
}