using System;

namespace Assignment1
{
    internal class Program3
    {
        public void Run()
        {
            Console.Write("Enter your marks (0-100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 85)
                Console.WriteLine("Grade: A");
            else if (marks >= 70)
                Console.WriteLine("Grade: B");
            else if (marks >= 55)
                Console.WriteLine("Grade: C");
            else if (marks >= 40)
                Console.WriteLine("Grade: D");
            else if (marks >= 0)
                Console.WriteLine("Grade: F");
            else
                Console.WriteLine("Invalid marks!");
        }
    }
}
