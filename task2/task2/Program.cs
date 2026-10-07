using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            int Age = Convert.ToInt32(Console.ReadLine());
            int Grade = Convert.ToInt32(Console.ReadLine());
            double Average = Convert.ToDouble(Console.ReadLine());
            char Gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"Welcome {Name}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {Grade}");
            Console.WriteLine($"Average: {Average}");
            Console.WriteLine($"Gender: {Gender}");

            Console.WriteLine("");

            Console.WriteLine("Original Name:" + Name);
            Console.WriteLine("Uppercase: " + Name.ToUpper());
            Console.WriteLine("Lowercase: " + Name.ToLower());
            Console.WriteLine("First Character:" + Name[0]);

            Console.WriteLine("");

            Console.WriteLine("Original Average: " + Average);
            Console.WriteLine("Bonus Marks: 5");
            Console.WriteLine("New Average: " + (Average + 5));

            if ((Average + 5) >= 50)
            {
                Console.WriteLine("Result: Passed");
            }
            else
            {
                Console.WriteLine("Result: Failed");
            }

            if (Age >= 18)
            {
                Console.WriteLine("Adult: True");
            }
            else
            {
                Console.WriteLine("Adult: False");
            }
        }
    }
}
