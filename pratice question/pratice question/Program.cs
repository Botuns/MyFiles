using System;

namespace pratice_question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Enter a value to give the factorial");
            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            while (true)
            {
                if (n <= 1)
                {
                    break;
                }
                factorial *= n;
                n--;
            }
            Console.WriteLine("n! = " + factorial);
            Console.WriteLine("Enter your number");
            
            int a = int.Parse(Console.ReadLine());
            int b = (3 * 7);
            int c = a % b;
            for (int i = 0; i < a; i++)
            {

              Console.WriteLine(c + i);
                c++;
            }
            //practice
            Console.WriteLine("Enter words");
            string words = Console.ReadLine();
            string[] word = words.Split(" ");
            for(int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }










               




            }
    }
}
