using System;
using System.Collections.Generic;
using System.Text;
using LearningDI.Models;

namespace LearningDI.Interfaces
{
    public interface IMotor
    {
        void ThrottleUp();
        void ThrottleDown();
        int GetRPM();
    }
}
