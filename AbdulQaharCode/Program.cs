using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbdulQaharCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'a','d', 'e' };
            Console.WriteLine($"{ FunnyString(chars) }");// Question one
            int[] ints = { 724,103, 403, 792, 195, 445, 676, 337, 142, 731, 274, 530, 478, 719, 966, 680, 202, 692, 142, 260, 333, 555, 905, 517, 679, 432, 620, 477, 841, 340, 960, 566, 443, 715, 710, 639, 160, 386, 328, 655, 469, 955, 537, 299, 674, 855, 980, 228, 548, 122, 489, 881, 30 ,746 ,750 ,709 ,531, 370, 539, 372, 710, 499, 938, 505, 215, 0, 144, 727, 738, 825, 734, 207, 780, 271, 507, 806, 127, 839, 387, 675, 313, 228, 908, 343, 974, 658, 53, 857, 380, 592, 230, 442, 443, 520, 947, 10, 521, 444, 738, 259 };
            Console.WriteLine(ToyFunction(ints));//Question two
        }
        static string FunnyString(char[] chars)
        {
            for (int i = 0; i < chars.Length-1; i--)
            {
                List<char> newChar = new List<char>();
                newChar.Add(chars[i]);
                
                byte[] acc1 = Encoding.ASCII.GetBytes(chars);
                byte[] acc2 = Encoding.ASCII.GetBytes(newChar.ToArray());
                foreach(char c in acc1)
                {
                    decimal d = (decimal)c;
                    foreach(char c2 in acc2)
                    {
                        decimal e = (decimal)c2;
                        if (Math.Abs(d) == Math.Abs(e) )
                        {
                            return " Funny String";
                        }

                    }
                }
                
                 
            }
            return "  Not Funny String";
        }
        static int ToyFunction(int[] weights)
        {
            int container = 1;
            
            for (int i = 0; i < weights.Length-1; i++)
            {
                  int current = weights[0];
                if (weights[i] < current + 4)
                {
                    List<int> newweights = new List<int>();
                    newweights.Add(weights[i]);
                    container++;
                }
                break;
                
            }
            return container;
        }
    }
}
