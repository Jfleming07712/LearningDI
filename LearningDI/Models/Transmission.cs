using System;
using System.Collections.Generic;
using System.Text;
using LearningDI.Interfaces;

namespace LearningDI.Models
{
    public class Transmission : ITransmission
    {
        public int Direction { get; set; } = 0;

        public void ChangeDirection(string direction)
        {
            switch (direction)
            {
                case "Forward":
                    {
                        this.Direction = 1;

                        break;
                    }
                case "Reverse":
                    {
                        this.Direction = 2;

                        break;
                    }

                default:
                    {
                        this.Direction = 0;

                        break;
                    }
            }
        }

        public int GetDirection()
        {
            return Direction;
        }

    }
}
