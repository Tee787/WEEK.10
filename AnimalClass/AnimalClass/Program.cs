/*Create an application that contains a class call Animal. This animal class needs to contain the following:
•	2 properties - one for the animals name and one for the sound the animal makes.
•	The necessary getters and setters for the properties.
•	A method called animalSays() that can build the string "The xxxx says zzzz" eg. "The cow says moo"
•	A constructor for all of the Animals properties. Make sure it uses the properties setters and not the property itself.
From the main method you need to:
•	Prompt the user to enter the name for the animal and save it in an appropriate variable.
•	Prompt the user to enter the sound for the animal and save it in an appropriate variable.
•	Create an Animal object and use the variables to populate the constructor.
•	Use the objects AnimalSays() method to display the information back to the user.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClass
{
    class Animal
    {
        public string name { get; set; }
        public string sound { get; set; }

        public Animal(string name, string sound)
        {
            name = name;
            sound = sound;
        }

        public string AnimalSays()
        {
            return "The " + name + " says " + sound;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the animal type ie. Cow, Duck, Cat: ");
            string name = Console.ReadLine();
            Console.WriteLine("Now enter the sound the animal makes: ");
            string sound = Console.ReadLine();

            Animal animal1 = new Animal(name, sound);
            Console.WriteLine(animal1.AnimalSays());
        }
    }
}
