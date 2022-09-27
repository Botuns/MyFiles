using System;

namespace pro_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your score");
            int s = int.Parse(Console.ReadLine());

            switch (s)
            {
               
                case >= 70:
                    Console.WriteLine("A");
                    break;
                case >= 60:
                    Console.WriteLine("B");
                    break;
                case >= 50:
                    Console.WriteLine("C");
                    break;
                case < 50:
                    Console.WriteLine("D");
                    break;
                default: 
                    Console.WriteLine("F");
                    break;
            }



            object container = 5;
            Console.WriteLine(container);

            string name = "ade";
            int age = 72;

            //string interpolatiion
            Console.WriteLine($"my name is {name} and I'm {age} years old ");

            Console.WriteLine("\"Hello jude\",He\n said");


            int a = 5;
            int b = 7;

            //ternary operator
            Console.WriteLine(a>b?"a>b":"b<=a");


            //for loop
            for(int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }


            int counter = 25;
            while (counter <= 20)
            {
                Console.WriteLine(counter);
                counter++;
            }


            //infinite loop
/*            while (true)
            {

            }*/

            Console.WriteLine("Enter a number:");
            int Num = int.Parse(Console.ReadLine());
            int divider = 2;
            int MaximumDivider = (int)Math.Sqrt(Num);

            while(divider <= MaximumDivider)
            {
                if(Num % divider == 0)
                {
                    Console.WriteLine("This is not a prime number");
                    break;
                }
                divider++;

            }
            Console.WriteLine("Enter a number");
            int Number = int.Parse(Console.ReadLine());
            int div = 2;
            int Maxdiv = (int)Math.Sqrt(Number);
            for (int i = 0; i < Number; i++)
            {
                if(Number % div == 0)
                {
                    Console.WriteLine("This is not a prime number");
                    break;

                }
            }
            div++;
           /* Console.WriteLine("Enter number to print sequence");
             int N = int.Parse(Console.ReadLine());
            int  num1 = 0;
            int num2 = 1;
            
            if(N < 1)
            {
                Console.WriteLine("the number is not valid");
            }
            else
            {
                Console.Write(num1 + " ");
                for(int i = 1; i < N; i++)
                {
                    int Next = num1 + num2;
                    num1 = num2;
                    num2 = Next;
                    Console.Write(num1 + " ");
                }
            }*/

            
                
            



        }



        
    }
}
            