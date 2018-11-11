/*Create a class called car that contains properties for the cars make, model, 
 * colour and rego along with the necessary getters and setters (No constructor). 
 * Once your class has been created, make 5 car objects and populate them with some details. 
 * Display all of the car objects properties to the user.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTsk1
{
    class Car                                   //Name of our Class to be constructed
    {   //Public properties used for the object of the Car
        public Car(string make, string v1, string model, string v2, string colour, string v3, string rego)
        {
            this.make = make;
            this.model = model;
            this.colour = colour;
            this.rego = rego;
        }
        //Short method of using the getters and setters 
        public string make { get; set; }
        public string model { get; set; }
        public string colour { get; set; }
        public string rego { get; set; }       
       //Public string method used to call our function in our main body
        public string CarDetails()
        {
            return make + " " + model + " " + colour + " " + rego;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the cars details:");
            string car = Console.ReadLine();
            Console.WriteLine("Make: ");
            string make = Console.ReadLine();
            Console.WriteLine("Model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Colour: ");
            string colour = Console.ReadLine();
            Console.WriteLine("Rego number: ");
            string rego = Console.ReadLine();

            Car c1 = new Car(make," ", model," ",colour," ",rego);
            Console.WriteLine(c1.CarDetails());

        }
    }
}
