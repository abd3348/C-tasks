using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = "abdallah mdalal";
            int studentAge = 22;
            int studentGrade = 20;
            double studentAverage = 85.5;
            char studentGender = 'M';
            bool IsstudentActive = true;

            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Age: " + studentAge);
            Console.WriteLine("Grade: " + studentGrade);
            Console.WriteLine("Average :" + studentAverage);
            Console.WriteLine("Gender: " + studentGender);
            Console.WriteLine("IsActive: " + IsstudentActive);

            string[] names = { "abdallah", "omar", "moath", "ahmad" };
            Console.WriteLine("student 1 " + names[0]);
            Console.WriteLine("student 2 " + names[1]);
            Console.WriteLine("student 3 " + names[2]);
            Console.WriteLine("student 4 " + names[3]);

            Console.WriteLine("Number of Students: "+ names.Length);

            names[0] = "Ali";
            Console.WriteLine("student 1 " + names[0]);
            Console.WriteLine("student 2 " + names[1]);
            Console.WriteLine("student 3 " + names[2]);
            Console.WriteLine("student 4 " + names[3]);


        }
    }
}
