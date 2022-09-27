using System;

namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Question one
            /*Console.WriteLine("Enter your numbers respectively");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            long k = (a * b * c * d * e * f * g * h * i * j);
            Console.WriteLine("the answer is " + k);*/
            //end
            /*Console.WriteLine("Enter your first text");
            string textone = Console.ReadLine();
            string texttwo = Console.ReadLine();
            string textthree = (textone +  texttwo);
            Console.WriteLine(textthree);*/
            //end
            Console.WriteLine("Fill in your info");
            Console.WriteLine("Your name");
            string a = Console.ReadLine();
            Console.WriteLine("Age");
            string b = Console.ReadLine();
            Console.WriteLine("school");
            string c = Console.ReadLine();
            Console.WriteLine("Your name is" + " "+ a);
            Console.WriteLine("Your age is" + " " + b);
            Console.WriteLine("Your school is" + " " + c);
            //end
            Console.WriteLine("Enter your age for regristration");
            int k = int.Parse(Console.ReadLine());
            if (k > 18)
            {
                Console.WriteLine("congratulation!, you are now cleared for regristration");
                if (k < 18)
                {
                    Console.WriteLine("Sorry try again later");
                    string t = "years";
                    int r = (18 - k);
                    if (k < 18)

                        Console.WriteLine("register again " + " " + r + " " + t);
                    //end



                }
            }
            Console.WriteLine("conversion table of mile to kilometer");
            Console.WriteLine("input a figure");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine(w * 1.609);
            // end 










        }// Question one

    }
}
