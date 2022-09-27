using System;

namespace OLAj_ASS_2
{
    internal class Program
    {
        static void ReturnName(string name)//Question one
        {
            Console.WriteLine("Hello ", name);
        }
        static int a;

        static void GetMax(int first, int second)//question two
        {
            if (first > second) a = first;
            else a = second;
        }
        static void GetName(string number)//Question three
        {
            switch (number[number.Length - 1])
            {
                case '1':
                    Console.WriteLine("One");
                    break;
                case '2':
                    Console.WriteLine("Two");
                    break;
                case '3':
                    Console.WriteLine("Three");
                    break;
                case '4':
                    Console.WriteLine("Four");
                    break;
                case '5':
                    Console.WriteLine("Five");
                    break;
                case '6':
                    Console.WriteLine("Six");
                    break;
                case '7':
                    Console.WriteLine("Seven");
                    break;
                case '8':
                    Console.WriteLine("Eight");
                    break;
                case '9':
                    Console.WriteLine("Nine");
                    break;
                case '0':
                    Console.WriteLine("Zero");
                    break;
                default:
                    Console.WriteLine("invalid input.");
                    break;
            }
            static int CountNumber(int number, int[] arr)//Question four
            {
                int counter = 0;

                for (int i = 0; i < arr.Length; i++) if (number == arr[i]) counter++;

                return counter;
            }
            //int numbber = int.MinValue;//Question six

            static void CompareNumber(int[] arrr, int numbber)
            {
               

                for (int i = 1; i < arrr.Length - 1; i++)
                    if (arrr[i] > arrr[i - 1] && arrr[i] > arrr[i + 1])
                    {
                        numbber = arrr[i];
                        break;
                       
                    }
                ;
            }
             static string Reverse(string number)
            {
                char[] charArray = number.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }

            static void Main(string[] args)
            {
                Console.Write("Enter name: ");
                ReturnName(Console.ReadLine());

                Console.Write("Enter first number: ");
                a = Int32.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = Int32.Parse(Console.ReadLine());
                Console.Write("Enter third number: ");
                int c = Int32.Parse(Console.ReadLine());

                GetMax(a, b);
                GetMax(a, c);

                Console.WriteLine($"Biggest number is {a}");
                Console.Write("Enter a number: ");
                string number = Console.ReadLine();

                GetName(number);
                Console.Write("Enter array length: ");
                int length = Int32.Parse(Console.ReadLine());

                int[] arr = new int[length];

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Enter the element: ", i);
                    arr[i] = Int32.Parse(Console.ReadLine());
                }

                Console.Write("Enter number: ");
                int numberr = Int32.Parse(Console.ReadLine());

                Console.WriteLine("{0} was found {1} times.", number, CountNumber(numberr, arr));

                Console.Write("Enter array length: ");
                int lengtht = Int32.Parse(Console.ReadLine());

                int[] arrr = new int[lengtht];

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Enter {0} element: ", i);
                    arrr[i] = Int32.Parse(Console.ReadLine());
                }

                /*int numbber = CompareNumber(arrr);

                 if (numbber == int.MinValue) Console.WriteLine("-1");
                 else Console.WriteLine("{0} is bigger than it's neighbours", numbber);
                Console.Write("Enter number: ");
                string numbers = Console.ReadLine();

                Console.WriteLine(Reverse(numbers));*/

                int lengthe;//Question 8
                int[] Array1 = new int[10000];
                int[] Array2 = new int[10000];

                Console.Write("Enter first number: ");
                string s1 = Console.ReadLine();
                lengthe = s1.Length;

                for (int i = 0; i < s1.Length; i++)
                {
                    Array1[i] = Convert.ToInt32(s1.Substring(s1.Length - 1 - i, 1));
                }

                Console.Write("Enter second number: ");
                String s2 = Console.ReadLine();

                if (s2.Length > length)
                {
                    length = s2.Length;
                }

                for (int i = 0; i < s2.Length; i++)
                {
                    Array2[i] = Convert.ToInt32(s2.Substring(s2.Length - 1 - i, 1));
                }

                for (int i = 0; i < length; i++)
                {
                    Array1[i] += Array2[i];

                    if (Array1[i] >= 10)
                    {
                        Array1[i] -= 10;
                        Array1[i + 1]++;
                    }
                }

                if (Array1[length] == 1)
                {
                    length++;
                }

                Console.WriteLine();
                Console.Write("Result is: ");

                for (int i = 0; i < length; i++)
                {
                    Console.Write(Array1[length - 1 - i]);
                }

                Console.ReadLine();



            }






        }

    }
}
