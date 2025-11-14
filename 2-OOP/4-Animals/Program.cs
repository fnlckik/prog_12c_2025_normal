using System;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Példányosítás
            Animal zsolti = new Animal("Zsolti", 67);
            Dog ubul = new Dog("Ubul", 5, "beagle");
            Animal scooby = new Dog("Scooby", 12, "dándog");
            //double a = 4;

            // ToString()
            Console.WriteLine("--------- ToString() ---------");
            Console.WriteLine(zsolti);
            Console.WriteLine(ubul);
            Console.WriteLine(scooby);
            Console.WriteLine();

            // MakeSound()
            Console.WriteLine("--------- MakeSound() ---------");
            zsolti.MakeSound();
            ubul.MakeSound();
            scooby.MakeSound();
            Console.WriteLine();
        }
    }
}
