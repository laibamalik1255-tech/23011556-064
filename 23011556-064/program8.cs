using System;

namespace Assignment1
{
    internal class Program8
    {
        public void Run()
        {
            int[] arr = new int[10];
            int max, min;

            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = arr[0];
            min = arr[0];

            for (int i = 1; i < 10; i++)
            {
                if (arr[i] > max)
                    max = arr[i];

                if (arr[i] < min)
                    min = arr[i];
            }

            Console.WriteLine("Maximum number: " + max);
            Console.WriteLine("Minimum number: " + min);
        }
    }
}
