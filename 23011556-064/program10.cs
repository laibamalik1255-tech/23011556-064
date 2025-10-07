using System;

namespace Assignment1
{
    internal class Program10
    {
        public void Run()
        {
            int[] arr = new int[10];
            int searchNum;
            bool found = false;

            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nEnter a number to search: ");
            searchNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (arr[i] == searchNum)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine("Number " + searchNum + " is found in the array.");
            else
                Console.WriteLine("Number " + searchNum + " is NOT found in the array.");
        }
    }
}