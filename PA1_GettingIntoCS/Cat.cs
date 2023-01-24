/* Name: Daniel Cunningham
 * Date: 1/24/23
 * Declaration and implementation of the concrete class Cat that inherits the Animal Abstract 
 * class's members and overrides the member variables
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace PA1_GettingIntoCS
{
    class Cat : Animal
    {
        // Default constructor that calls the abstract class Animal constructor to set it to the default values for Cat
        public Cat() : base("Default Cat", "meow", -1, -1)
        {

        }
        // Parameterized constructor that calls the abstract class Animal constructor to set it to the passed arguments for Cat
        public Cat(string name, int age, int weight) : base(name, "meows", age, weight)
        {
            
        }
        // Overrided void function to print the info of a Cat instance in a formatted way
        public override void printInfo()
        {
            Console.WriteLine(Name + " the cat ");
            Console.Write("Age: " + Age + "\nWeight: " + Weight + " pounds.\n\n");
        }
        // Overrided void function to add one to the age of a Cat Instance
        public override void ageUp()
        {
            Age = Age + 1;
        }
        // Overrided void function to print the noise of the Cat along with the name of the Cat Instance.
        public override void makeNoise()
        {
            Console.WriteLine("\n" + Name + " the cat " + Noise + ".");

        }

    }
}
