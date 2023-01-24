/* Name: Daniel Cunningham
 * Date: 1/24/23
 * Declaration of the abstract class Animal and its member variables. Its constructors and properties are implemented.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace PA1_GettingIntoCS
{
    abstract class Animal
    {
        private string name, noise;
        private int age, weight;
        
        // Default constructor that sets the variables of the abstract class to its default values
        public Animal()
        {
            this.name = "Default Animal";
            this.noise = "Default Noise";
            this.age = -1;
            this.weight = -1;
        }
        // Parameterized constructor that sets the member variables to their respective parameters when called
        public Animal(string name, string noise, int age, int weight)
        {
            this.name = name;
            this.noise = noise;
            this.age = age;
            this.weight = weight;
        }
        // Abstract function that will be overrided to print the info of a child class
        abstract public void printInfo();
        // Abstract function that will be overrided to print the noise of a child class
        abstract public void makeNoise();
        // Abstract function that will be overrided to age up the child class
        abstract public void ageUp();
        
        // Name property that allows you to set and get the name member variable
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // Noise property that allows you to set and get the noise member variable
        public string Noise
        {
            get { return noise; }
            set { noise = value; }
        }
        // Age property that allows you to set and get the age member variable
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        // Weight property that allows you to set and get the weight member variable
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }

}
