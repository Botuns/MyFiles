using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeByAbdQahar
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Question One:
            int prisoners = 10;
            int picesOfCandies = 10;
            int startPosition = 1;
            int permutatedChairs = (picesOfCandies + startPosition) - 1;
            int WarnedPrisoner = permutatedChairs % prisoners;
            if (WarnedPrisoner == 0)
            {
                WarnedPrisoner = prisoners;
            }
            Console.WriteLine(WarnedPrisoner);
            //int SweetFact = (6 * 5 * 4 * 3 * 2);
            //int PrisFact = (4 * 3 * 2);
            //int Possiblities = SweetFact / PrisFact;
            //int warnedChair = SweetFact / Possiblities;
            //Console.WriteLine(warnedChair);


            //End
            //Question 2

            int[] listArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            for (int i = 0; i < listArr.Length; i++)
            {
                if(listArr[listArr[0]] == 1 && listArr.Length == 1)
                {
                    Console.WriteLine(1);
                }
            }
            int[] listArr2 = listArr.Where(x => x % 2 == 0).ToArray();
            for (int i = 0; i < listArr2.Length-1; i++)
            {
                int ase = listArr2[i];
                
                List<int> aser = new List<int>();
                aser.Add(ase);
                ase =+ 2;
                //aser.RemoveAt(ase);

                //int[] listArr3 = listArr2.Where(s => s == (listArr2[i] + 1)).ToArray();
                //for(int j = 0; j < listArr3.Length; j++)
                //{
                //    int[] finalList = listArr3.Where(f => f == (listArr3[j])).ToArray();
                //    for (int k = 0; k < finalList.Length; k++)
                //    {
                //        int s = finalList[k];
                //        Console.WriteLine(s);
                //    }
                //}
                
                if(aser.Count > 1)
                {
                    foreach (var asr in aser)
                    {
                        Console.WriteLine(asr);
                    }
                }
                return;


            }
            //End

        }

        
    }
}
