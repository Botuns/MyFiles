using System;

namespace ASS_CLS_AND_OBJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello write a year to know if its a leap year");
            //Year one = new Leapyear(3);
            //one.Printprofile();
            
            
        }
    }
    class Year
    {
        public int Leapyear;
        
       public  Year(int a)
        {
            this.Leapyear = a;

            int b = int.Parse(Console.ReadLine());
            if (b % 4 == 0)
            {
                   

                Console.WriteLine("The year is a leap year");
                if (b !=0)
                {            
                        Console.WriteLine("It is not a leap year");
                    
                }
                
            }

            
            

        }
        
        

    }
}
