using System;

namespace Array_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "I", "am", "a", "boy" };
            int length = array.Length;
            string[] reversed = new string[length];
            for (int i = 0; i < length; i++)
            {
                reversed[length - i -1] = array[i];
            }
            for (int i = 0; i < length; i++)
            {
                // Console.Write($"{reversed[i]}");
                Console.Write(reversed[i] + " ");
            }
            Console.WriteLine($"{String.Join(' ',reversed)}");
            //Question one
            int[]arry = new int[20];
            for (int i = 0; i < arry.Length; i++)
            {
                arry[i] = i*5;
                Console.WriteLine(arry[i]);
            }
            //Question two
            int num1 = new int[3];


        }
    }
}
