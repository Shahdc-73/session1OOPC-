using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyConsoleApp;


namespace PersonNamespace
{
    public struct Person
    {
        // Fields
        public string Name;
        public int Age;

        // Constructor
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // Method to display person's details
        public void ShowPersons()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}