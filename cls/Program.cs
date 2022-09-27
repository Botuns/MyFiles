using System;

namespace cls
{
    internal class Program
    {
        static int Series(int a)
        {
            if (a == 0)
            {
                return 0;
            }
            if (a == 1)
            {
                return 1;
            }
            else if (a > 2 )
            {
                return Series(a - 1)+Series(a - 2);
            }
            return a;
        }
        static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;

            }
            else
            {
                return n * Factorial(n- 1);



            }
           
        }
        //public static void  Arithmetics(int a, int b)
        //{
        //    int num = 2;
        //    int num1 = 3;

        //    int mul = num * num1;
        //    Console.WriteLine(mul);
                

        //}
        //public static void  Arithmetics(int a, int b,int c)
        //{
        //    int num = 2;
        //    int num1 = 3;

        //    int add = num + num1;
        //    Console.WriteLine(add);
            

        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = 5;
            long factorial = Factorial(num);
            Console.WriteLine(factorial);
            
            for (int i = 0; i < num; i++)
            {
                //int a = 0;
                
                int fib = 4;
                int fib2 = Series(fib);
                Console.WriteLine(fib2);

            }




        }






    }

        
    }
  

