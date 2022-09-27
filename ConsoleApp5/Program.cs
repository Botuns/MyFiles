using System;

namespace ConsoleApp5
{
    public abstract class Personn
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract void PrintName();
        public abstract void PrintAge();
        public abstract void PrintId();

    }
    public class Studentt
    {
        public string Name = "Olajide Abdul Qahar";
        public static string School = "Government College Ibadan";
        public int Age = 18;
        public static void PrintSchoolName()
        {
            Console.WriteLine(School);
        } 
        public void PrintDetails()
        {
            Console.WriteLine($" {Name}:{Age}");
            
        }
    }
    class Person
    {
        public string Name ="Olajide";
        public int Age = 18;
        public string Address = "Zone d, Kasumu Estate Ibadan";
        public double Height = 4.35;
        public string Message = "Hi";
        
            public Person()
        {
            Name = "Olajide";
            Age = 18;
            Address = "Zone d";
            Height = 4.35;
            Message = "Hi";
        }
        
    }
    //public void PrintDetails()
    //{
    //    Console.WriteLine();

    //}

    class Class1
    {
        public Class1()
        {
            Console.WriteLine("Greetings from empty constructor");
        }
        public Class1(int a)
        {
            Console.WriteLine("Greetings from non empty constructor");
        }

    }
    internal class Program
    {
       public void Arithmetics()
        {
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class1 class1 = new Class1();
            Person one = new Person();
            Person two = new Person();
            Person three = new Person();
            Person four = new Person();
            Person five = new Person();
            Console.WriteLine(one.Name);
            Console.WriteLine(two.Age);
            Console.WriteLine(three.Address);
            Console.WriteLine(four.Height);
            Console.WriteLine(five.Message);
           /* Program.Arithmetics();*/
           Studentt st = new Studentt();
            st.Name = "Olajide Abdul Qahar";
            st.Age = 18;
            st.PrintDetails();

            Studentt.PrintSchoolName();

            




        }
    }
}
