using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {this.name}\n" +
                $"Age: {this.age}\n");
        }
    }
}
