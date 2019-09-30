using LearningDI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace LearningDI.Models
{
    public class Brake: IBrake
    {
        private int friction { get; set; } = 1000;

    }
}
