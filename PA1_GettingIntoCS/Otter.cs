/* Name: Daniel Cunningham
 * Date: 1/24/23
 * Declaration and implementation of the concrete class Otter that inherits the Animal Abstract 
 * class's members and overrides the member variables
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace PA1_GettingIntoCS
{
    class Otter : Animal
    {
        // Default constructor that calls the abstract class Animal constructor to set it to the default values for Otter
        public Otter() : base("Default Otter", "chirps", -1, -1)
        {

        }
        // Parameterized constructor that calls the abstract class Animal constructor to set it to the arguments passed
        public Otter(string name, int age, int weight) : base(name, "chirps", age, weight)
        {

        }
        // Overrided void function to print the info of a Otter instance in a formatted way
        public override void printInfo()
        {
            Console.WriteLine(Name + " the otter ");
            Console.Write("Age: " + Age + "\nWeight: " + Weight + " pounds.\n\n");
        }
        // Overrided void function to add one to the age of a Otter Instance
        public override void ageUp()
        {
            Age = Age + 1;
        }
        // Overrided void function to print the noise of the Otter along with the name of the Otter Instance.
        public override void makeNoise()
        {
            Console.WriteLine("\n" + Name + " the otter " + Noise + ".");
        }
    }
}
