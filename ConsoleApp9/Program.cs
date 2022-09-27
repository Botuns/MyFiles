using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = int.Parse(Console.ReadLine());
            double sgrt = Math.Sqrt(a);
            bool isPrime = true;
            if (a > 2)
            {
                for (int i = 2; i <= sgrt; i++)
                {
                    if(a % i == 0)
                    {
                        isPrime = true;
                        
                        //Console.WriteLine(!isPrime);
                    }
                    else
                    {
                        //Console.WriteLine(isPrime);
                    }

                }

            }
            Console.WriteLine("{0}  is it prime: {1} ", a,isPrime);
            
            
        }
    }
}
