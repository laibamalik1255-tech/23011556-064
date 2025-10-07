using System;

namespace Assignment1
{
    internal class Program4
    {
        public void Run()
        {
            int n, sum = 0;
            Console.Write("Enter number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of numbers from 1 to " + n + " is " + sum);
        }
    }
}
