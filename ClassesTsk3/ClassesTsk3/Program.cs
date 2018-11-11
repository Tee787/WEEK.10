/*Create a class for an animal object with properties for the animal type, 
 * the animals name and an id number. The id number needs to be a 4 digit random number. 
 * This class needs to have a constructor and a method inside of the class that returns 
 * all of the animals details as a string back to the main method to be displayed.*/
using System;

namespace ClassesTsk3
{
    class Animals
    {
        public string name { get; set; }
        public string type { get; set; }
        public int number { get; set; }
        
        public Animals(string name,string type, int id)
        {
            type = type;
            name = name;
            id = number;
        }
        public string AnimalObject()
        {
            return type + " " + name + " " + number;
        }

   
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of animal: ");
            string type = Console.ReadLine();
            Console.WriteLine("Now enter the name of the animal: ");
            string name = Console.ReadLine();
            RandomGenerator generator = new RandomGenerator();
            int rand = generator.RandomNumber(1000, 9999);
            

            Animals a1 = new Animals(type, name, rand);
            Console.WriteLine(a1.AnimalObject());
        }
    }   
    public class RandomGenerator
    {
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }

    
}
