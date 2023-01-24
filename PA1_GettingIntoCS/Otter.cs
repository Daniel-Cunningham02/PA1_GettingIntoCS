using System;
using System.Collections.Generic;
using System.Text;

namespace PA1_GettingIntoCS
{
    class Otter : Animal
    {
        public Otter() : base("Default Otter", "squeaks", -1, -1)
        {

        }

        public Otter(string name, int age, int weight) : base(name, "squeaks", age, weight)
        {

        }
        public override void printInfo()
        {
            Console.WriteLine(Name + " the otter ");
            Console.Write("Age: " + Age + "\nWeight: " + Weight + " pounds.\n");
        }

        public override void ageUp()
        {
            Age = Age + 1;
        }

        public override void makeNoise()
        {
            Console.WriteLine("\n" + Name + " the otter " + Noise + ".");
        }
    }
}
