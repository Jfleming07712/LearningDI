using System;
using System.Collections.Generic;
using System.Text;
using LearningDI.Interfaces;

namespace LearningDI.Models
{
    public class Motor: IMotor
    {
        private int RPM { get; set; } = 1000;

        internal void ThrottleUp()
        {
            this.RPM = RPM + 1000;
        }

        internal void ThrottleDown()
        {
            this.RPM = RPM - 1000;
        }

        internal int GetRPM()
        {
            return RPM;
        }
    }
}
