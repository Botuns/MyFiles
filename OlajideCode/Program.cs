using System;
using System.Linq;
using System.Collections.Generic;

namespace OlajideCode
{
    public class Program
    {
        public bool isSorted(string[] words, string order)
        {
            int[] arr = new int[26];
            for (int i = 0; i < order.Length; i++)
            {
                arr[order[i] - 'a'] = i;
            }
            for (int i = 1; i < words.Length; i++)
            {
                if (bigger(words[i - 1], words[i], arr))
                {
                    Console.WriteLine(false);
                }
            }
            Console.WriteLine(true);
            return true; 
        }

        bool bigger(string s1, string s2, int[] arr)
        {
            int n = s1.Length, m = s2.Length;
            for (int i = 0; i < n && i < m; i++)
            {
                if (s1[i] != s2[i])
                {
                    return arr[s1[i] - 'a'] > arr[s2[i] - 'a'];
                }
            }
            return n > m;
        }
        static void Main(string[] args)
        {
            //QUESTION THREE
            //int init = 0;
            int profit = 0;
            int maxProfit = 0;
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            for (int i = 0; i < prices.Length-1; i++)
            {
                for(int j = 1; j < prices.Length; j++)
                {
                    profit = prices[i] - prices[j];
                    if(profit > maxProfit)
                    {
                        
                        //maxProfit = profit-1;
                        maxProfit = Math.Max(maxProfit, profit);
                        Console.WriteLine(maxProfit-1);
                    }
                }
            }
            //END OF QUESTION THREE
            Program program = new Program();
            string[] codearr = { "word ,world, row," };
            //int[] arr = new int[26];
            program.isSorted(codearr,  "hlabcdefgijkmnopqrstuvwxyz") ;//QUESTION ONE
            
            


        }
    }
}
