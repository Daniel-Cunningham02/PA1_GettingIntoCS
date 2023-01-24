# PA1_GettingIntoCS
Assignment Description: We were instructed to created an abstract animal class that has three concrete children.
In my case, it's a Cat, Cassowary, and Otter class. A World class was made that would hold a list of Animals. From there, a menu was made
so that the user can interact with the code using input to either create a new animal in the world, display the info of all the animals,
age up all the animals, or hear the animals make their noises.

## Design Decisions
* Within the menu driven interface, I allowed the user to cycle through continuously until they decide to quit using a bool IsActive and a while loop.
* Within the same menu, I allowed the user to create an instance of the three different animals; however, when it came to displaying information about the animals,
seeing them age up, and hear their noise, I decided to make the program display the information of all the animals within the World instance along with aging up all the animals at once
and "hearing" all of them make their noise at once.
* For my third concrete class, I decided to make an otter which uses the base constructor(in both the default and parameterized constructors) just as the other concrete classes do.
* In general, for the three concrete children, I took the liberty to make their noise set when you create them; therefore, the parameterized constructor
does not take in an argument for the noise private variable. It is set in the class, but it can be changed by using code with the Noise property. However, it may not be changed by the user
in this implementation of this assignment.

