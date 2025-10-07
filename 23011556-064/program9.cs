using System;

namespace Assignment1
{
    internal class Program9
    {
        public void Run()
        {
            int[] arr = new int[10];
            int evenCount = 0, oddCount = 0;

            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (arr[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine("Total even numbers: " + evenCount);
            Console.WriteLine("Total odd numbers: " + oddCount);
        }
    }
}
