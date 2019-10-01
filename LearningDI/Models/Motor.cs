using System;
using System.Collections.Generic;
using System.Text;
using LearningDI.Interfaces;

namespace LearningDI.Models
{
    public class Motor : IMotor
    {
        public int RPM { get; set; } = 1000;

        public void ThrottleUp()
        {
            this.RPM = RPM + 1000;
        }

        public void ThrottleDown()
        {
            this.RPM = RPM - 1000;
        }

        public int GetRPM()
        {
            return RPM;
        }
    }
}
