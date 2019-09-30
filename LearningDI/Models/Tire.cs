using System;
using System.Collections.Generic;
using System.Text;
using LearningDI.Interfaces;

namespace LearningDI.Models
{
    public class Tire: ITire
    {
        private int RollSpeed { get; set; } = 0;

        public void CalcRollSPeed(int RPM, int direction)
        {
            int rollSpeed;

            rollSpeed = RPM * 5 * direction;

            this.RollSpeed = rollSpeed;
        }
        
        public int GetRollSpeed(int RPM, int direction)
        {
            this.CalcRollSPeed(RPM, direction);

            return this.RollSpeed;
        }
    }
}
