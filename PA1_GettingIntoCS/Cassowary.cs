using System;
using System.Collections.Generic;
using System.Text;

namespace PA1_GettingIntoCS
{
    class Cassowary : Animal
    {
        public Cassowary() : base("Default Cassowary", "rumbles", -1, -1)
        {

        }

        public Cassowary(string name, int age, int weight) : base(name, "rumbles", age, weight)
        {

        }
        public override void printInfo()
        {
            Console.WriteLine(Name + " the Cassowary ");
            Console.Write("Age: " + Age + "\nWeight: " + Weight + " pounds.\n");
        }

        public override void ageUp()
        {
            Age = Age + 1;
        }

        public override void makeNoise()
        {
            Console.WriteLine("\n" + Name + " the Cassowary " + Noise + ".");
        }
    }
}
