using System;

namespace ASS_TUESDAY
{
    internal class Program
    {
        
        static void ReturnName(string name)//one
        {
            Console.WriteLine($"Hello {name}");
            Console.Write("Enter first number: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());

            GetMax(a, b);
            GetMax(a, c);

            Console.WriteLine($"Biggest number is{a}");
        }
        static int a;

        static void GetMax(int first, int second)
        {
            if (first > second)
            {
                a = first;
            }
            
            else a = second;
        }
        static int numbers (int[]array,int num)
        {
            int counter = 0;
            for(int i = 0;i < array.Length; i++)
            {
                if (array[i] == num)
                counter++;
            }
            return counter;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");//num 1
            ReturnName(Console.ReadLine());
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine("Enter the numbers");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(array.Length);
            Console.WriteLine(num);
        }
        static void LastLetter(string mum)
        {
            char lastindex = mum[mum.Length - 1];
            switch (lastindex)
            {
                case '1':
                    Console.WriteLine("one");
                    break;
                case '2':
                    Console.WriteLine("two");
                    break;
                case '3':
                    Console.WriteLine("three");
                    break;
                case '4':
                    Console.WriteLine("four");
                    break ;
                case '5':
                    Console.WriteLine("five");
                    break;
                case '6':
                    Console.WriteLine("six");
                    break;
                case '7':
                    Console.WriteLine("seven");
                    break;
                case '8':
                    Console.WriteLine("eight");
                    break;
                case '9':
                    Console.WriteLine("nine");
                    break;
                case '0':
                    Console.WriteLine("zero");
                    break ;
                default:
                    Console.WriteLine("your input is wrong");
                    break;


            }
        }










    }

 
}
 