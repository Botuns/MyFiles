using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //for loop
            //for (int i = 1; i < 100; i++)
            //{
            //  if (i % 2 != 0)
            //{
            //  Console.WriteLine(i);
            //}
            //}

            //while loop

            //int j = 0;
            //while (j < 100)
            //{
            //if (j % 2 != 0)
            //{
            //  Console.WriteLine(j);
            //}

            //  j++;

            //}


            //int k = 1;
            //do
            //{


            //Console.WriteLine(k);

            //  k++;

            //}
            // while (k < 10);


            //for (int i = 0; i < 10; i++)
            //{//
            // if //(i == 4 || i == 8)
            // {//
            //   break;
            // }
            //   Console.WriteLine(i);
            //  }

            /*int n = int.Parse(Console.ReadLine());
            for(int i = 1;i < n; i++ )
            {
                
                if ( (i % 3 == 0) && ( i % 7 ==0) )
                {
                    continue;
                }
                Console.WriteLine(i);*/


            //Console.WriteLine(n);
            // }
          /*  int a = int.Parse(Console.ReadLine());
            long fact = 1;
            for (int i = 1; i > a; i++)
            {
                fact = i;

            }
            Console.WriteLine(fact);*/

            int[] myArray = new int[5];

            int[] myArray2 = { 2, 3, 4, 5, 5 };

            for (int i = 0; i <= myArray2.Length - 1; i++)
            {
                Console.WriteLine(myArray2[i]);
            }


            Console.WriteLine("How many scores do you want to record?");
            int n = int.Parse(Console.ReadLine());

            int[] StudentScores = new int[n];

            //insertion of elements in array 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the next score:");
                StudentScores[i] = int.Parse(Console.ReadLine());
            }

            //printing elements in an array
           /* for (int i = 0; i <= StudentScores.Length - 1; i++)
            {
                Console.WriteLine($"score at positiion {i}");
                Console.WriteLine(2 *StudentScores[i]);
            }*/

            int sum = 0;
            for (int i = StudentScores.Length - 1; i >= 0; i--)
            {
                sum += StudentScores[i];
                Console.WriteLine(StudentScores[i]);
                
               
            }





        }


    }
}

