/* Name: Daniel Cunningham
 * Date: 1/24/23
 * Includes the main driver for the program that loops over a menu allowing the user to add animals
 * to a world where you can age up your animals, "listen" to them, and display their information.
 * It also includes the World object which contains the List of animals
 */


using System;
using System.Collections.Generic;

namespace PA1_GettingIntoCS
{
    class World
    {
        List<Animal> Animals = new List<Animal>();
        static void Main(string[] args)
        {
            bool isActive = true;
            World world = new World();
            while(isActive) {
                Console.Write("1)Add an animal to the world\n2)Display the information of an animal\n3)Would you like to see the animals age up?\n4)Hear the animals make their noises.\n5)Quit\n");
                Console.WriteLine("Enter the number for the Menu you wish to go to: ");
                int selection = Int32.Parse(Console.ReadLine());
                    switch (selection)
                    {
                        case 1:
                            Console.Write("\n\nWhat type of animal would you like to create?\n1)Cat\n2)Cassowary\n3)Otter\n");
                            int selection2 = Int32.Parse(Console.ReadLine());
                            switch (selection2)
                            {
                                case 1:
                                Console.Write("\nWhat is the Cat's name? ");
                                string name = Console.ReadLine();
                                Console.Write("What is " + name + "'s age? ");
                                int age = Int32.Parse(Console.ReadLine());
                                Console.Write("What is " + name + "'s weight? ");
                                int weight = Int32.Parse(Console.ReadLine());
                                Console.Write("\n\n");
                                world.Animals.Add(new Cat(name, age, weight));
                                break;

                                case 2:
                                Console.Write("\nWhat is the Cassowary's name? ");
                                name = Console.ReadLine();
                                Console.Write("What is " + name + "'s age? ");
                                age = Int32.Parse(Console.ReadLine());
                                Console.Write("What is " + name + "'s weight? ");
                                weight = Int32.Parse(Console.ReadLine());
                                Console.Write("\n\n");
                                world.Animals.Add(new Cassowary(name, age, weight));
                                break;

                                case 3:
                                Console.Write("\nWhat is the Otters's name? ");
                                name = Console.ReadLine();
                                Console.Write("What is " + name + "'s age? ");
                                age = Int32.Parse(Console.ReadLine());
                                Console.Write("What is " + name + "'s weight? ");
                                weight = Int32.Parse(Console.ReadLine());
                                Console.Write("\n\n");
                                world.Animals.Add(new Otter(name, age, weight));
                                break;
                                default:

                                Console.Write("Please go back through the menus and select a valid option.");
                                Console.ReadKey();
                                break;
                            }
                            break;

                        case 2:
                        Console.WriteLine();
                        foreach(Animal animal in world.Animals)
                        {
                            animal.printInfo();
                        }
                        break;
                            
                        case 3:
                        Console.WriteLine("\nEvery animal in the world has aged up.\n");
                        foreach (Animal animal in world.Animals)
                        {
                            animal.ageUp();
                        }
                        break;

                        case 4:
                        Console.WriteLine("\n");
                        foreach (Animal animal in world.Animals)
                        {
                            animal.makeNoise();
                        }
                        Console.WriteLine("");
                        break;
                        case 5:
                        isActive = false;
                        break;

                        default:
                            Console.Write("Please restart the program and select a valid selection...");
                            Console.ReadKey();
                            break;
                    
                }
            }
        }
    }
}
