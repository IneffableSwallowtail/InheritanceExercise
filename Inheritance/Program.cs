using System;
using System.Drawing;

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




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird crow = new Bird()
            {
                legs = 2,
                name = "Bee",
                eyes = 2,
                color = "black",
                call = "caw",
                flightSpeed = 60,
                flies = true,
                makesNest = true
            };

            Console.Write($"{crow.name}, the {crow.legs}-legged, {crow.eyes}-eyed bird, is a {crow.color} crow. It makes a {crow.call} sound. ");
            if (crow.makesNest == true)
                Console.Write("It makes nests, and ");
            else
                Console.Write("It does not make nests, and ");

            if (crow.flies == true)
                Console.Write($"it flies, and reaches speeds up to {crow.flightSpeed} mph.\n");
            else
                Console.WriteLine("it does not fly.\n");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile copperhead = new Reptile()
            {
                legs = 0,
                name = "Lisa",
                eyes = 2,
                color = "brown",
                swims = true,
                camouflages = false,
                venomous = true,
                shell = false
            };

            Console.Write($"\n{copperhead.name}, the {copperhead.legs}-legged, {copperhead.eyes}-eyed snake, is a {copperhead.color} coppehead. ");
            if (copperhead.swims == true)
                Console.Write("It swims, ");
            else
                Console.Write("It does not swim, ");

            if (copperhead.camouflages == true)
                Console.Write("camouflages, ");
            else
                Console.Write("does not camouflage, ");
            if (copperhead.shell == true)
                Console.Write("has a shell, ");
            else
                Console.Write("has no shell, ");

            if (copperhead.venomous == true)
                Console.Write("and is venomous.\n");
            else
                Console.Write("and is not venomous.\n");

        }
    }
}
