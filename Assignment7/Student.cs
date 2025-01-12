using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Student
    {
        public string name;
        public int[] grade;

        public Student(string name, int[] grades)
        {
            this.name = name;
            this.grade = grades;
        }

        public double CalculateAverage()
        {
            double sum = 0;
            for (int i = 0; i < grade.Length; i++)
            {
                sum += grade[i];
            }

            return sum / grade.Length;
        }

        public void DisplayGrades()
        {
            Console.WriteLine($"Grades for {name}:");
            for (int i = 0;i < grade.Length;i++)
            {
                Console.WriteLine (grade[i]);
            }

            Console.WriteLine($"\nAverage: {CalculateAverage()}");
        }
    }
}
