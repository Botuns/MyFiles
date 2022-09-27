using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Lenght of the jagged array");
            int jaggedLenght = (int.Parse(Console.ReadLine()));
            int[][]jaggedArray =new int[jaggedLenght][];
            for (int i = 0; i < jaggedLenght; i++)
            {
                for (int j = 0; j < jaggedLenght; j++)
                {
                    Console.WriteLine("Enter the next number");
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());

                }


            }   
            for (int i = 0; i < jaggedLenght; i++)
            {
                Console.WriteLine(i );
            }
            }
        }
}
