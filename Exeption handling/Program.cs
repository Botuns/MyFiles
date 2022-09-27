using System;

namespace Exeption_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine(int.Parse(Console.ReadLine()));

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
