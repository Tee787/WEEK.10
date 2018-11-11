/*Create a person class that has public properties for First and last names and a private property for their age. 
 * Make a constructor which is used to populate the properties at the time of the objects creation. 
 * Create a Person object and display their full name and age to the user. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTsk2
{

    //class person2
    //{
    //    public string Fname { get; private set; }
    //    public string Lname { get; set; }
    //    public int Age { get; set; }

    //    public person2(string _fname, string _lname, int _age)
    //    {
    //        Fname = _fname;
    //    }
    //}
    class Person
    {
        string fname, lname;
        private int age;
        

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
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person(string fname, string lname, int age)
        {
            Fname = fname;
            Lname = lname;
            Age = age;
        }               
        public string GetFullName()
        {
            return Fname + " " + Lname + " " + age;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your firstname:");
            string fname = Console.ReadLine();
            Console.WriteLine("Now enter your lastname: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Finally enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Person p1 = new Person(fname,lname,age);
            Console.WriteLine(p1.GetFullName());
        }
    }
}
