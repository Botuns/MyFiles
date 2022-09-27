using System;
using Teaching;

    namespace Teaching
    {
        class Teacher
        {
           
        }
    }
    namespace Learning
    {
        class Student
        {
            Teacher teacher = new Teacher();
        }
    }
    internal class Program
    {
    
        
    
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           Student one = new Student("Ade", 2 , "123exneu" , 4.64);
        Student two = new Student(2, "123exneu");
        Student three = new Student("123exneu", 4.64);
            two.Printprofile();
            three.Printprofile();




           one.Printprofile();
        Mammal goat = new Mammal();
        goat.Eating();
        goat.Sound();
    }
        }
class Student
{
    public string Name;
    public int Age;
    public string Matricnumber;
    public double Cpga;
   public Student(string Name , int Age ,string Matricnumber , double Cpga)
    {
        this .Name = Name;
        this.Age = Age;
    }
    public Student(int Age, string Matricnumber )
    {
        this.Age = Age;
        this.Matricnumber = Matricnumber; 

    }
    public Student(string Matricnumber , double Cpga)
    {
        this.Matricnumber = Matricnumber;
        this.Cpga = Cpga;
    }
    public void Printprofile()
    {
        Console.WriteLine($" My name is {Name},My age is {Age}");
        Console.WriteLine($"My age is {Age} and my matric number is {Matricnumber}");
        Console.WriteLine($" My Cpga is {Cpga}");
     
    }
    
 }
class Animal
{
    //string skincolour;
    public virtual void Eating()
    {
        Console.WriteLine("I am eating");
    }
}
class Mammal : Animal
{
   
    public void Sound()
    {
        Console.WriteLine("It usually barks as barking is its sound");
    }
    public  override void Eating()
    {
        Console.WriteLine("I am chewing");
    }

}

