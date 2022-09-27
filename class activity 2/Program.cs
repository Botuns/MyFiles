using System;

namespace class_activity_2
{
    internal class Program
    {
        static double Sum(double[]array)
        {
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }
        static double Mean(double sum , double o)
        {
            double mean = (sum / o);
            return mean;

        }
        static double Variance(double[] array, double mean, double o)
        {
            double variance = 0;
          for(int j = 0; j < array.Length; j++)
            {
                 variance =(double)(mean - array[j])/ array[j];
               
            }
            return variance;
        }
        static double Standvar( double variance)
        {
            double standvar = 0;
             standvar = Math.Sqrt(variance);

            return standvar;

        }





        static bool IsEven(int a)
        {
            if(a % 2== 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Arithmetics(3, 4, 5);
            Console.WriteLine("Enter the number to know if true");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(IsEven(number));
            double[]addittion = {1,2,3,4,5,6};
            double addition = Sum(addittion);
            double xb = Mean(addition,addittion.Length);
            double vary = Variance(addittion, xb, addittion.Length);
            double std = Standvar(vary);
            Console.WriteLine(addittion);
            Console.WriteLine(addition);
            Console.WriteLine(xb);
            Console.WriteLine(vary);
            Console.WriteLine(std);







        }
        public static void Arithmetics(int a, int b, int c)
        {
            int add = a + b + c;
            double add2 = (a + b + c) / 3;
            decimal div = a / b / c;
            int mul = a * b * c;
            Console.WriteLine(add);
            Console.WriteLine(add2);
            Console.WriteLine(div);
            Console.WriteLine(mul);

        }
        
    }
}
