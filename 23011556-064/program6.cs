using System;

namespace Assignment1
{
    internal class Program6
    {
        public void Run()
        {
            int n, fact = 1, i = 1;
            Console.Write("Enter number: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (i <= n)
            {
                fact = fact * i;
                i++;
            }

            Console.WriteLine("Factorial of " + n + " is: " + fact);
        }
    }
}