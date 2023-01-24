/* Name: Daniel Cunningham
 * Date: 1/24/23
 * Declaration and implementation of the concrete class Cassowary that inherits the Animal Abstract 
 * class's members and overrides the member variables
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace PA1_GettingIntoCS
{
    class Cassowary : Animal
    {
        // Default constructor that calls the abstract class Animal constructor to set it to the default values for Cassowary
        public Cassowary() : base("Default Cassowary", "rumbles", -1, -1)
        {

        }
        // Parameterized constructor that calls the abstract class Animal constructor to set it to the arguments passed
        public Cassowary(string name, int age, int weight) : base(name, "rumbles", age, weight)
        {

        }
        // Overrided void function to print the info of a Cassowary instance in a formatted way
        public override void printInfo()
        {
            Console.WriteLine(Name + " the Cassowary ");
            Console.Write("Age: " + Age + "\nWeight: " + Weight + " pounds.\n\n");
        }
        // Overrided void function to add one to the age of a Cassowary Instance
        public override void ageUp()
        {
            Age = Age + 1;
        }
        
        // Overrided void function to print the noise of the Cassowary along with the name of the Cassowary Instance.
        public override void makeNoise()
        {
            Console.WriteLine("\n" + Name + " the Cassowary " + Noise + ".");
        }
    }
}
