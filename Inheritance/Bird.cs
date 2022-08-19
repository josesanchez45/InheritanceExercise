using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird:Animal
    {
        public bool CanFly { get; set; }
        public bool BirdOfPrey { get; set; }

        public bool BuildsNestInTree { get; set; }
        public string BirdSpecies { get; set; }
    }
}
