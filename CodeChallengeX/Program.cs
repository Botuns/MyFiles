using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;


namespace CodeChallengeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Hello World!");
            //Question One
            string s1 = "asdp";
            string[] arr1 = s1.Split('\u002C');
            
            int s1lenght = s1.Length;
            string s2 = "aspd";
            string[] arr2 = s2.Split('\u002c');
            int s2lenght = s2.Length;
            int count = 0;
            //int w = s1.Where(x => x.Equals(s2).Count();
            for (int i = 0; i < s2lenght; i++)
            {
                if (s1[i].Equals(s2[i]))
                {
                    count++;   //First attempt
                }


            } 
            Console.WriteLine(count);   
            //for(int j = 0; j< arr1.Length-1; j++)
            //{
            //    for (int k = 0; k < arr2.Length-1; k++)
            //    {
            //        if(arr1[j - 1].Equals(arr2[k - 1]))
            //        {
            //            int res = (arr1[j - 1] + arr2[k - 1]+1).Length;
            //            Console.WriteLine(res);
            //        }
            //        else          //second attempt
            //        {
            //            int res1 = (arr1[j - 1] + arr2[k - 1]).Max();
            //            Console.WriteLine(res1);
            //        }
            //    }
                

            //}
            ////End

            ////Question 2
            //int n = 0;
            //string Ply1 = "Richard";
            //string Ply2 = "Luois";
            //int game = 0;
            //if (n >= 1)
            //{
            //    Console.WriteLine(Ply1);
            //    while (n == 1)
            //    {
            //        game++;
            //        if (n % 2 == 0)
            //        {
            //            n /= 2;
            //            if (game % 2 != 0)
            //            {
            //                Console.WriteLine(Ply2);
            //            }
            //            else { Console.WriteLine(Ply1); }
            //            if (n % 2 == 0) { Console.WriteLine(Ply2); }
            //            else { Console.WriteLine(Ply1); }

            //        }

            //    }
            //}
            //Console.WriteLine(Ply2);
            //    //End


        }
    }
}
