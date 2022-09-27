using System;

namespace MY_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Hello World!");
            //QUESTION ONE
            /*Console.WriteLine("Write your number to know if its even or odd");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " " + "is an even number");
            }



            if (a % 2 == 1)
            {
                Console.WriteLine(a + " " + "is not an even number but odd number");
            }
            //end
            // QUESTION 2
            Console.WriteLine("Enter a number to know if divisible by 5 and 7");
            int b = int.Parse(Console.ReadLine());
            bool c = (b % 5 == 0) && (b % 7 == 0);
            Console.WriteLine(c);
            //end
            //Question 5
            Console.WriteLine("calculate your area of trapeziod by ");
            Console.WriteLine("enter your lengh a");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your base b");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height h");
            int f = int.Parse(Console.ReadLine());
            int g = (d + e);
            int h = (g * f);
            int area = (h / 2);
            Console.WriteLine(area);
            // end  
            // QUESTION 6
            Console.WriteLine("calculate the area of rectangle and also its perimeter");
            Console.WriteLine("enter the lenght");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the breath");
            int w = int.Parse(Console.ReadLine());
            int p = ((2 * w) + (2 * l));
            int z = (w * p);
            Console.WriteLine("the area of rectangle the is" + " " + p);
            Console.WriteLine("the perimeter of the rectangle is" + " " + z);
            //end
            // QUESTION 10
            Console.WriteLine("input your figures accordingly");
            int q = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            int u = (q + r + s + t);
            Console.WriteLine(u);
            Console.WriteLine($"{t}{s}{r}{q}");
            Console.WriteLine($"{t}{q}{r}{s}");
            Console.WriteLine($"{q}{t}{r}{s}");
            //end
            // QUESTION 7
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double answer = (0.17 * number);
            Console.WriteLine(answer);
            //end
            //QUESTION B1
            Console.WriteLine("enter three numbers");
            int fig1 = int.Parse(Console.ReadLine());
            int fig2 = int.Parse(Console.ReadLine());
            int fig3 = int.Parse(Console.ReadLine());
            int fig4 = (fig1 + fig2 + fig3);
            Console.WriteLine($"the product is{fig4}");
            //end
            //question b2
            Console.WriteLine("calculate the are and perimeter of a cicle by providing the radius below;");
            double m = int.Parse(Console.ReadLine());
            double o = (2 * 3.142 * m);
            double n = (3.142 * m * m);
            Console.WriteLine($"the perimeter of the circle is{o} and the area of the circle is{n}");
            //end
            //questionb3
            Console.WriteLine("fill below, your company details");
            Console.WriteLine("company name");
            string comName = Console.ReadLine();
            Console.WriteLine("address");
            string comadress = Console.ReadLine();
            Console.WriteLine("phone number");
            string comphonenumber = Console.ReadLine();
            Console.WriteLine("company fax number");
            string comfaxnumber = Console.ReadLine();
            Console.WriteLine("company website");
            string comweb = Console.ReadLine();
            Console.WriteLine("company manager name and phone");
            string commanager = Console.ReadLine();
            Console.WriteLine(comName);
            Console.WriteLine(comadress);
            Console.WriteLine(comphonenumber);
            Console.WriteLine(comfaxnumber);
            Console.WriteLine(comweb);
            Console.WriteLine(commanager);
            //end
            //QUESTION C1
            Console.WriteLine("pls input your numbers accordingly");
            int x = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (x > k)
            {
                Console.WriteLine($"{k == x}");

            }
            if (k > x)
            {
                Console.WriteLine($"{x == k}");
            }
            // QUESTION4 1

            Console.WriteLine("Enter your number");
            int v = int.Parse(Console.ReadLine());
            int i = (v / 100);
            int j = (i % 10);
            if (j == 7)
            {
                Console.WriteLine("The number is 7 ");
            }
            //end
            Console.Write("Enter a number: ");
            int rex = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter hex: ");
            int hex = Convert.ToInt32(Console.ReadLine());
            bool isInside = (rex * hex * hex <= 5) ? true : false;
            Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}", rex, hex, isInside);*/
            //end
            //Console.WriteLine("Enter the numbers to know greater value");
            //int fst = int.Parse(Console.ReadLine());
            //int snd = int.Parse(Console.ReadLine());
            //int max = fst > snd ? fst : snd;
            //Console.WriteLine($"the greater number is {max}");
            ////end
            //Console.WriteLine("Enter the numbers to know greatest value");
            //int fst1 = int.Parse(Console.ReadLine());
            //int snd2 = int.Parse(Console.ReadLine());
            //int fst3 = int.Parse(Console.ReadLine());
            //int fst4 = int.Parse(Console.ReadLine());
            //int fst5 = int.Parse(Console.ReadLine());
            //int maxx = fst1 > snd2 ? fst1 : snd2;
            //int max2 = fst3 > fst4 ? fst3 : fst4;
            //int max3 = maxx > max2 ? maxx : max2;
            //int max4 = max2 > max3 ? max2 : max3;
            //Console.WriteLine($"the greatest number is {max4}");
            ////end
            //Console.WriteLine("Enter two numbers to show their sum");
            //int one = int.Parse(Console.ReadLine());
            //int two = int.Parse(Console.ReadLine());
            //int three = (one + two);
            //Console.WriteLine($" the sum of the two numbers is {three}");
            ////end

            ////question
            //int sum = 0;

            //Console.Write("Enter numbers count: ");
            //int length = Int32.Parse(Console.ReadLine());

            //for (int di = 0; di < length; di++)
            //{
            //    Console.Write("Enter {0} number: ", di + 1);
            //    sum += Int32.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Sum of all numbers is {0}.", sum);
            ////end
            ////question 9



            //Console.Write("Enter number: ");
            //int lengt = Int32.Parse(Console.ReadLine());

            //for (int ci = 1; ci <= lengt; ci++)
            //{
            //    Console.WriteLine(ci);
            //}
            ////end
            //Console.Write("Enter a number : ");
            //int xr = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number: ");
            //int yi = Convert.ToInt32(Console.ReadLine());
            //bool isInside = (xr * yi * yi <= 5);
            //Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}", xr, yi, isInside);
            ////end
            //Console.Write("Enter a number: ");
            //int xi = Convert.ToInt32(Console.ReadKey());
            //Console.Write("Enter number: ");
            //int yt = Convert.ToInt32(Console.ReadKey());
            //bool isInsideCircle = (xi * xi + yt * yt <= 5);
            //bool isOutsideRectangle = (xi < -1 && xi > 5 && yt < 1 && yt > 5);
            //Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}", xi, yt, isInsideCircle);
            //Console.WriteLine("The point O({0},{1}) is outside rectangle ((-1, 1), (5, 5)?: {2}", xi, yt, isOutsideRectangle);
            ////end
            //int na = 35, pi = 6, ii = 1, mask = ii << pi;
            //Console.WriteLine((na & mask) != 0 ? "Third bit is 1" : "Third bit is 0");
            ////end
            //int vs = 350;
            //int pr = 350;
            //int masks = 1 << pr;
            //bool isOne = (vs & mask) != 0;
            //Console.WriteLine("The bit at position {0}of number {1} is 1? {2}", pr, vs, isOne);
            ////end
            //int no = 350;
            //int vo = 0;
            //int po = 3;
            //no = (vo == 0) ? _ = no & (~(1 << po)) : _ = no | (1 << po);
            //Console.WriteLine(no);
            ////end
            //int numberr = 72;
            //bool isPrimer = true;
            //if (numberr > 2)
            //    for (int it = 2; it <= Math.Ceiling(Math.Sqrt(numberr)); ++it)
            //    {
            //        if (numberr % it == 0) isPrimer = false;
            //    }
            //Console.WriteLine("{0} is prime?: {1}", numberr, isPrimer);
            ////end
            //Console.Write("Enter number: ");
            //int vd = Convert.ToInt32(Console.ReadLine());
            //int maskt = 1 << 3;
            //int bitAt3 = (vd & maskt) != 0 ? 1 : 0;
            //maskt = 1 << 4;
            //int bitAt4 = (vd & maskt) != 0 ? 1 : 0;
            //maskt = 1 << 5;
            //int bitAt5 = (vd & maskt) != 0 ? 1 : 0;
            //maskt = 1 << 24;
            //int bitAt24 = (vd & maskt) != 0 ? 1 : 0;
            //maskt = 1 << 25;
            //int bitAt25 = (vd & maskt) != 0 ? 1 : 0;
            //maskt = 1 << 26;
            //int bitAt26 = (vd & maskt) != 0 ? 1 : 0;

            //vd = (bitAt3 == 0) ? vd & (~(1 << 24)) : vd | (1 << 24);
            //vd = (bitAt4 == 0) ? vd & (~(1 << 25)) : vd | (1 << 25);
            //vd = (bitAt5 == 0) ? vd & (~(1 << 26)) : vd | (1 << 26);
            //vd = (bitAt24 == 0) ? vd & (~(1 << 3)) : vd | (1 << 3);
            //vd = (bitAt25 == 0) ? vd & (~(1 << 4)) : vd | (1 << 4);
            //vd = (bitAt26 == 0) ? vd & vd & (~(1 << 5)) : vd | (1 << 5);

            //Console.WriteLine(vd);
            ////End
            //int[] arrt = new int[20];

            //for (int ig = 0; ig < arrt.Length; ig++)
            //{
            //    arrt[ig] = ig * 5;
            //    Console.WriteLine(arrt[ig]);
            //}
            ////end
            //bool arraysEqual = true;

            //Console.Write("Enter lenght of first array: ");
            //int lengthe = Int32.Parse(Console.ReadLine());

            //int[] arrA = new int[lengthe];

            //for (int ic = 0; ic < arrA.Length; ic++)
            //{
            //    Console.Write("Enter element {0}: ", ic);
            //    arrA[ic] = Int32.Parse(Console.ReadLine());
            //}

            //Console.Write("\nEnter lenght of second array: ");

            //if (length != Int32.Parse(Console.ReadLine())) Console.WriteLine("\nArrays have different lengths.");
            //else
            //{
            //    int[] arrB = new int[lengthe];

            //    for (int ic = 0; ic < arrB.Length; ic++)
            //    {
            //        Console.Write("Enter element {0}: ", ic);
            //        arrB[ic] = Int32.Parse(Console.ReadLine());
            //    }

            //    for (int ic = 0; ic < arrA.Length; ic++)
            //    {
            //        if (arrA[ic] != arrB[ic])
            //        {
            //            Console.WriteLine("\nArrays are different.");
            //            arraysEqual = false;
            //            break;
            //        }
            //    }

                //if (arraysEqual) Console.WriteLine("\nArrays are the same.");
                //end
                Console.WriteLine("Enter your number");

                int a = int.Parse(Console.ReadLine());
                int b = (3 * 7);
                int c = a % b;
                for (int i = 0; i < a; i++)
                {

                    Console.WriteLine(c + i);
                    c++;
                }
                //end
                /* Console.WriteLine("Hello World!");
             Console.Write("Enter a value to give the factorial");
             int n = int.Parse(Console.ReadLine());
             decimal factorial = 1;
             while (true)
             {
                 if (n <= 1)
                 {
                     break;
                 }
                 factorial *= n;
                 n--;
             }
             Console.WriteLine("n! = " + factorial);*/
                Console.WriteLine("Enter a number so as to convert");
                decimal nom = decimal.Parse(Console.ReadLine());







            }
        }
    }
}

