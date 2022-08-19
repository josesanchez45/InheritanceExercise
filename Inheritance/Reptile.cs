using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public string ReptileSpecies { get; set; }
        public string LizardorSnake { get; set; }
        public bool Venomous { get; set; }
        public bool CanChangeColor { get; set; }
    }
}
