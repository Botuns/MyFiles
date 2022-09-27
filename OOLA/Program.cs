using System;

namespace OOLA
{
    class Week
    {
        
        public Week()
        {
            
        }
        public void WeekDays(string Week)
        {
            switch (Week)
            {
                case "1":
                    Console.WriteLine("Sunday");
                    break;
                case "2":
                    Console.WriteLine("monday");
                    break;
                case "3":
                    Console.WriteLine("tuesday");
                    break;
                case "4":
                    Console.WriteLine("wednesday");
                    break;
                case "5":
                    Console.WriteLine("thursday");
                    break;
                case "6":
                    Console.WriteLine("friday");
                    break;
                case "7":
                    Console.WriteLine("saturday");
                    break;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Pls input a year to confirm if its leap or not leap year");
            int a = int.Parse(Console.ReadLine());
            if (a % 4 == 0)
            {
                Console.WriteLine("It is a leap year");
            }
            else if (a % 4 != 0)
            {
                Console.WriteLine("It is not a leap year");
            }
            Console.WriteLine("Enter day of the week");
            string num = Console.ReadLine();
            Week day = new Week();
        }
    }
}
