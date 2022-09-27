using System;

namespace class_and_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Animal dog = new Animal();
            Animal goat = new Animal();
            dog.name = "jack";
            goat.name = "black";
            dog.colour = "blue";
            Console.WriteLine(dog.name);
        }
    }
    public class Animal
    {
        public string name = "rabbit";

        public string colour;
        public string Mine()
        {

        }
    }
}
