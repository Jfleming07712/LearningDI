using System;
using System.Collections.Generic;
using System.Text;
using LearningDI.Interfaces;

namespace LearningDI.Models
{
    public class Transmission: ITransmission
    {
        private int Direction { get; set; } = 0;

        internal void ChangeDirection(string direction)
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

        internal int GetDirection()
        {
            return Direction;
        }

    }
}
