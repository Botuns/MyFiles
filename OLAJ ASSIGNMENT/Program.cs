using System;

namespace OLAJ_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Question one Arrays
            int[] arrt = new int[20];

            for (int i = 0; i < arrt.Length; i++)
            {
                arrt[i] = i * 5;
                Console.WriteLine(arrt[i]);
                //end

            }
            //Question two Arrays
            bool arraysEqual = true;

            Console.Write("Enter lenght of first array: ");
            int lengthe = Int32.Parse(Console.ReadLine());

            int[] arrA = new int[lengthe];

            for (int ic = 0; ic < arrA.Length; ic++)
            {
                Console.Write("Enter element : ", ic);
                arrA[ic] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter lenght of second array: ");

            if (lengthe != Int32.Parse(Console.ReadLine())) Console.WriteLine("Arrays have different lengths.");
            else
            {
                int[] arrB = new int[lengthe];

                for (int ic = 0; ic < arrB.Length; ic++)
                {
                    Console.Write("Enter element {0}: ", ic);
                    arrB[ic] = Int32.Parse(Console.ReadLine());
                }

                for (int ic = 0; ic < arrA.Length; ic++)
                {
                    if (arrA[ic] != arrB[ic])
                    {
                        Console.WriteLine("Arrays are different.");
                        arraysEqual = false;
                        break;
                    }
                }

                if (arraysEqual) Console.WriteLine("Arrays are the same.");
            }//end
            //Question three
            bool ArrayEquals = true;
            char[] arA = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            char[] arB = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            if (arA.Length > arB.Length)
            {
                Console.WriteLine("The second array is lexicographically first");
            }
            else if(arB.Length > arA.Length)
            {
                Console.WriteLine("The first array is lexicographically first");
            }
            for (int i = 0; i < arA.Length; i++)
            {
                if (arA[i] < arB[i])
                {
                    Console.WriteLine("First array is lexicographically first");
                    ArrayEquals=false;
                    break;
                }
                if (ArrayEquals) Console.WriteLine("The Arrays are lexicographically equal");
            }//end
             //Question four
            int count = 1, tempCount = 1, number = 0;

            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter the element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    tempCount++;
                
                }
                else tempCount = 1;
                if (tempCount > count)
                {
                    count = tempCount;
                    number = arr[i];
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write( number);
            } //end
              //Question five
            Console.Write("Enter array length: ");
            int lengthh = Int32.Parse(Console.ReadLine());

            int[] arrr = new int[lengthh];
            int sames = 1, bestSames = 1, bestStart = 0, lastElement = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter  element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 == arr[i + 1])
                {
                    sames++;
                    if (sames > bestSames)
                    {
                        bestSames = sames;
                        lastElement = i + 1;
                        bestStart = lastElement - bestSames + 1;
                    }
                }
                else sames = 1;
            }

            for (int i = bestStart; i < bestSames + bestStart; i++)
            {
                Console.Write( arr[i]);

            }
            int counter = 0, tempIndex, tempCounter;
            //end
            //Question six
            Console.Write("Enter array length: ");
            int lengt = Int32.Parse(Console.ReadLine());

            int[] ary = new int[length];
            int[] result = new int[length];

            for (int i = 0; i < lengt; i++)
            {
                Console.Write("Enter  element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < lengt; i++)
            {
                int[] tempResult = new int[lengt];
                tempIndex = tempCounter = 1;
                tempResult[0] = arr[i];

                for (int jj = i + 1; jj < lengt; jj++)
                {
                    if (arr[jj] > tempResult[tempIndex - 1])
                    {
                        tempResult[tempIndex] = arr[jj];
                        tempIndex++;
                        tempCounter++;
                    }
                    else if (tempIndex > 1 && arr[jj] > tempResult[tempIndex - 2] && arr[jj] < tempResult[tempIndex - 1]) tempResult[tempIndex - 1] = arr[jj];
                }

                if (counter < tempCounter)
                {
                    counter = tempCounter;
                    result = tempResult;
                }
            }

            for (int i = 0; i < counter; i++) Console.Write( result[i]);
            //end
            //Question seven
            int Counter = 0, tempindex, tempcounter;

            Console.Write("Enter array length: ");
            int lengthn = Int32.Parse(Console.ReadLine());

            int[] arre = new int[lengthn];
            int[] resultt = new int[lengthn];

            for (int i = 0; i < lengthn; i++)
            {
                Console.Write("Enter element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < lengthn; i++)
            {
                int[] tempResult = new int[lengthn];
                tempindex = tempcounter = 1;
                tempResult[0] = arr[i];

                for (int jf = i + 1; jf < lengthn; jf++)
                {
                    if (arr[jf] > tempResult[tempindex - 1])
                    {
                        tempResult[tempindex] = arr[jf];
                        tempindex++;
                        tempcounter++;
                    }
                    else if (tempindex > 1 && arr[jf] > tempResult[tempindex - 2] && arr[jf] < tempResult[tempindex - 1]) tempResult[tempindex - 1] = arr[jf];
                }

                if (Counter < tempcounter)
                {
                    Counter = tempcounter;
                    result = tempResult;
                }
            }

            for (int i = 0; i < Counter; i++)
            {
                Console.Write(result[i]);

            }
            //end
            //Question eight
            int ii, j, iMin, temp;

            Console.Write("Enter array length: ");
            int lenggth = Int32.Parse(Console.ReadLine());

            int[] arrl = new int[length];

            for (ii = 0; ii < lenggth; ii++)
            {
                Console.Write("Enter {0} element: ", ii);
                arrl[ii] = Int32.Parse(Console.ReadLine());
            }

            for (j = 0; j < lenggth - 1; j++)
            {
                iMin = j;

                for (ii = j + 1; ii < lenggth; ii++)
                {
                    if (arrl[ii] < arrl[iMin]) iMin = ii;

                }
                if (iMin != j)
                {
                    temp = arrl[j];
                    arrl[j] = arr[iMin];
                    arrl[iMin] = temp;
                }
                for (ii = 0; ii < lenggth; ii++)
                {
                    Console.Write(arrl[ii]);

                }
                //end
                //Question fifteen
                char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                Console.Write("Enter a word: ");
                char[] word = (Console.ReadLine()).ToCharArray();

                for (int i = 0; i < word.Length; i++)
                    for (int  k= 0; k < alphabet.Length; k++)
                        if (word[i] == alphabet[k]) Console.Write("{0} ", k);
                //Question 

            }

            
        }














    }
}
