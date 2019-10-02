using System;
using System.Collections.Generic;
using System.Text;
using LearningDI.Models;

namespace LearningDI.Interfaces
{
    public interface IMotor
    {
        //int RPM { get; set; }
        void ThrottleUp();
        void ThrottleDown();
        int GetRPM();
    }
}
