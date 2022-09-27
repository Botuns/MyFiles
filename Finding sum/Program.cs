using System;

namespace Finding_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("SUMS OF NUMBERS");
            Console.WriteLine("Enter two numbers so as to add the sum");
            Console.Write("First number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Second number : ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine($"The sum of the two numbers is: {result} ");
           
        }
    }
}
