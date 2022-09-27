using System;
using System.Collections.Generic;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "abcd";
            string b = "abdc";
            List<string> list = new List<string>();
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        list.Add(a[i].ToString());
                        
                        
                        break;
                       
                    }



                }
            }
            int count = list.Count;
            Console.WriteLine(count);
            List<string> list2 = new List<string> { "a", "b", "c", "d",  };
            List<string> list3 = new List<string> { "a", "b", "d", "c",  };
            List<string> list4 = new List<string>();
            foreach (string s in list2)
            {
                foreach(string s2 in list3)
                {
                    if (s.Equals(s2) == false)
                    {
                        list4.Add(s);
                    }
                }
            }
            Console.WriteLine(list4.Count);

        }
    }
}
