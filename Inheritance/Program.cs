using System;
using System.Reflection;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            var bird1 = new Bird()
            {
                BirdOfPrey = true,
                HasFur = false,
                Legs = 2,
                BuildsNestInTree = true,
                BirdSpecies = "Harpy Eagle",
                WarmBlooded = true,
                CanFly = true,
                Nocturnal = false,

            };
            var reptile1 = new Reptile()
            {
                LizardorSnake = "Snake",
                ReptileSpecies = "Anaconda",
                CanChangeColor = false,
                HasFur= false,
                Legs = 0,
                Nocturnal = false,
                Venomous = false,
                WarmBlooded = false
            };

            Console.WriteLine($"The following is information about the {reptile1.ReptileSpecies}" + Environment.NewLine +
                $"It is a large {reptile1.LizardorSnake}. Can it change color: {reptile1.CanChangeColor}");
            Console.WriteLine($"It has {reptile1.Legs} legs" + Environment.NewLine + $"Nocturnal: {reptile1.Nocturnal} "
                + Environment.NewLine + $"Is warmblooded: {reptile1.WarmBlooded}");

            Console.WriteLine();

            Console.WriteLine($"The following is information about the {bird1.BirdSpecies}" + Environment.NewLine +
          $" Does it nest in trees: {bird1.BuildsNestInTree }"+ Environment.NewLine + $"Can it fly: {bird1.CanFly}");
            Console.WriteLine($"It has {bird1.Legs} legs" + Environment.NewLine + $"Nocturnal: {bird1.Nocturnal} "
                + Environment.NewLine + $"Is warmblooded: {bird1.WarmBlooded}");

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
