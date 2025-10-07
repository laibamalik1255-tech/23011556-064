using System;

namespace Assignment1
{
    internal class Program7
    {
        public void Run()
        {
            int num, reverse = 0, remainder;

            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                remainder = num % 10;            // get last digit
                reverse = reverse * 10 + remainder; // add to reverse
                num = num / 10;                  // remove last digit
            }

            Console.WriteLine("Reverse is: " + reverse);
        }
    }
}