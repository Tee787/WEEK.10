/*Create an application that contains a class called Employee. This Employee class needs to contain the following:

4 auto properties - First name, Last name, Gross annual salary, tax rate (as a percentage)

A method called NetSalary() that can return the employee objects net salary (after tax). (You may need to use Math.Round())

A constructor for all of the Employees properties.

From the main method you need to:

Prompt the user to enter the data necessary to fill the employee properties and save them to appropriate variables.

Create an Employee object and use the variables to populate the constructor.

Use the objects properties to display the information back to the user.

Call the employee objects method to display the net salary to the user.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    class Employee
    {
        string fname, lname;
        double grossAnnualSalary;
        double taxRate;
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }
        public double GrossAnnualSalary
        {
            get { return grossAnnualSalary; }
            set { grossAnnualSalary = value; }
        }
        public double TaxRate
        {
            get { return taxRate; }
            set { taxRate = value; }
        }
        public string EmployeeDetails()
        {
            return Fname + " " + Lname;
        }
        public double NetSalary()
        {
            return GrossAnnualSalary * TaxRate;
        }
    }

    class Program
    {               

        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************************");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("**********************************************************");

            Console.WriteLine("Enter your firstname: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Now enter your lastname: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Now enter your gross annual salary: ");
            double grossAnnualSalary = double.Parse(Console.ReadLine());

            if (grossAnnualSalary >= 140000)
            {
                Console.WriteLine("Your taxrate is 10.5%");
                Console.ReadLine();
            }
            else if (grossAnnualSalary < 14000 || grossAnnualSalary >= 48000)
            {
                Console.WriteLine("Your taxrate is 17.5%");
                Console.ReadLine();
            }
            else if (grossAnnualSalary < 48000 || grossAnnualSalary >= 70000)
            {
                Console.WriteLine("Your taxrate is 30%");
                Console.ReadLine();
            }
            else if (grossAnnualSalary < 70000)
            {
                Console.WriteLine("Your taxrate is 33%");
                Console.ReadLine();
            }
            else
                return;
            Employee e1 = new Employee()


        }
    }
}
