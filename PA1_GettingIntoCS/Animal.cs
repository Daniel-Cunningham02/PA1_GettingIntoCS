using System;
using System.Collections.Generic;
using System.Text;

namespace PA1_GettingIntoCS
{
    abstract class Animal
    {
        private string name, noise;
        private int age, weight;

        public Animal()
        {
            this.name = "Default Animal";
        }
        
        public Animal(string name, string noise, int age, int weight)
        {
            this.name = name;
            this.noise = noise;
            this.age = age;
            this.weight = weight;
        }
        abstract public void printInfo();
        abstract public void makeNoise();
        abstract public void ageUp();
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Noise
        {
            get { return noise; }
            set { noise = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }

}
