using System;

namespace Assignment1
{
    internal class Program2
    {
        public void Run()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operation (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine($"Result: {num1 / num2}");
                    else
                        Console.WriteLine("Cannot divide by zero!");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }
}