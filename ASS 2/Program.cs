using System;

namespace ASS_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //QUESTION ONE
            int[] arrt = new int[20];

            for (int i = 0; i < arrt.Length; i++)
            {
                arrt[i] = i * 5;
                Console.WriteLine(arrt[i]);
            }
            //END
            //QUESTION TWO
            bool arraysEqual = true;

            Console.Write("Enter lenght of first array: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arrA = new int[length];

            for (int d = 0; d < arrA.Length; d++)
            {
                Console.Write("Enter element : ", d);
                arrA[d] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter lenght of second array: ");
            int lengthh = Int32.Parse(Console.ReadLine());
            int[] arrB = new int[lengthh];

            if (lengthh != Int32.Parse(Console.ReadLine())) Console.WriteLine("Arrays have different lengths.");
            else
            {


                for (int t = 0; t < arrB.Length; t++)
                {
                    Console.Write("Enter element: ", t);
                    arrB[t] = Int32.Parse(Console.ReadLine());
                }

                for (int t = 0; t < arrA.Length; t++)
                {
                    if (arrA[t] != arrB[t])
                    {
                        Console.WriteLine("Arrays are different.");
                        arraysEqual = false;
                        break;
                    }
                }

                if (arraysEqual) Console.WriteLine("Arrays are the same.");

            }
            //QUESTION 3
            char[] arrC = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            char[] arrD = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            if (arrC.Length > arrD.Length)
            {
                Console.WriteLine("The second Array is lexicographically first");
            }
            else if (arrD.Length > arrC.Length)
            {
                Console.WriteLine("The second Array is first lexicographically");
            }
            else
            {
                for (int n = 0; n < arrC.Length; n++)
                {
                    if (arrC[n] < arrD[n])
                    {
                        Console.WriteLine("First array is lexicographicaly first.");
                        break;
                    }
                    if (arrC[n] > arrD[n])
                    {
                        Console.WriteLine("Second array is lexicographicaly first.");
                        break;
                    }
                }
                }
                //QUESTION FIFTEEN

                char[] latinletters = { 'a', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k', 'l', 'm', 'o', 'p', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'b' };
            Console.WriteLine("Enter an alphabet to know its index position");
            char _e = char.Parse(Console.ReadLine());
            char[] latinlatters = { _e };


        }
    }
}
