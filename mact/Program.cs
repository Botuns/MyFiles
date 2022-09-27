using System;
using System.Collections.Generic;
using System.Linq;

namespace mact
{
    internal class Program
    {
         static char RepeatedCharacter(string s)
        {
            List<char> characters = new List<char>();
            for (int i = 0; i <= s.Length - 1; i++)
            {
                characters.Add(s[i]);
                List<char> duplicates = (List<char>)characters.GroupBy(x => x)
                                           .Where(g => g.Count() > 1)
                                           .Select(x => x.Key);
                return duplicates[0];
            }
            return 'e';
        }
        static void Main(string[] args)
        {
            //RepeatedCharacter("gifyrisuyfisfydsure");

            Console.WriteLine("Hello World!");
            int n = 19;
            for(int i = 1; i < n; i++)
            {
                for(int j = i; j < i; j++)
                {
                    Console.Write($"\n{j}");
                }
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
            Random random = new Random();
            random.Next();
        }
    }
}
