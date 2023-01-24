using System;
using System.Collections.Generic;
using System.Text;

namespace PA1_GettingIntoCS
{
    class Cat : Animal
    {

        public Cat() : base("Default Cat", "meow", -1, -1)
        {

        }

        public Cat(string name, int age, int weight) : base(name, "meows", age, weight)
        {
            
        }
        public override void printInfo()
        {
            Console.WriteLine(Name + " the cat ");
            Console.Write("Age: " + Age + "\nWeight: " + Weight + " pounds.\n\n");
        }

        public override void ageUp()
        {
            Age = Age + 1;
        }

        public override void makeNoise()
        {
            Console.WriteLine("\n" + Name + " the cat " + Noise + ".");

        }

    }
}
