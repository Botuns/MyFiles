using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> student = new Dictionary<int, string>
            {
                {1, "Ade" },
                {2, "Bola"},
                {3, "Shola"},
            };
            foreach(var Dictionary in student)
            {
                Console.WriteLine($"{Dictionary.Key}  {Dictionary.Value}");
            }
            student.Add(4, "Depo");
            student.Add(5, "Olajide");
            student.Add(8, "Bisi");
            student.Remove(3);
            foreach(var Dictionary in student)
            {
                Console.WriteLine($"{Dictionary.Key} {Dictionary.Value}");
            }
            HashSet<int> hs = new HashSet<int>
            {
               2,3,4,5
            };
            hs.Add(2);
            for (int i = 0; i < hs.Count; i++)
            {
              // Console.WriteLine(hs.);
            }
            foreach(var c in hs)
            {
                Console.WriteLine(c);
            }
            //Brackets
            

            //Distinct
            List<int> numbers = new List<int> { 21, 46, 46, 55, 17, 21, 55, 55 };

           IEnumerable<int> distinctNumbers = numbers.Distinct();

            Console.WriteLine(" The distinct numbers are: ");

            foreach (int num in distinctNumbers)
            {
                Console.WriteLine(num);
            }
            //
            HashSet<int> hd = new HashSet<int>
            {
                2,33,44,6,6,6,6,8,9,9,9,0,0,0,1,34
            };
            Console.WriteLine("The distinct numbers are: ");

            foreach (int nums in hd)
            {
                Console.Write(nums);
            }
            //Return numbers of occurrence
            string str = "1,1,2,4,5,6,6,7,7,8,9,0,0,0";
            SortedList slt2 = new SortedList();

            for (int i = 0; i < str.Length; i++)
            {
                if (slt2.ContainsKey(str[i]))
                {
                    var index = slt2.IndexOfKey(str[i]);
                    var value = (int)slt2.GetByIndex(index);
                    slt2.SetByIndex(index, value + 1);
                }
                else
                {
                    slt2.Add(str[i], 1);

                }
            }
            for (int i = 0; i < slt2.Count; i++)
            {
                Console.WriteLine($"{slt2.GetKey(i)}  {slt2.GetByIndex(i)}");
            }
            //Pellindrome
            Pellindrome pellindrome = new Pellindrome();
            pellindrome.Pellindromee();
            //Curly braces
            
    }
    }
}
