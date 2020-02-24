using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            // new Animal();
            Duck duck = new Duck("With Shoes");

            duck.MakeSound();
            Console.WriteLine(duck.GetFullName());

            Console.WriteLine(duck.LastName);
            duck.LastName = "Smith";
            Console.WriteLine(duck.LastName);
            Console.WriteLine(duck.GetFullName());

            Animal perro = new Perro("Dark");
            Animal duck2 = new Duck("Pedro");

            Animal[] pets = new Animal[2];
            pets[0] = perro;
            pets[1] = duck2;
        }
    }
}
