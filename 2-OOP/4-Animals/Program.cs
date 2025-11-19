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
            Cat szofi = new Cat("Szofi", 7);
            //double a = 4;
            Bird rico = new Bird("Rico", 3, false); // pingvin
            Parrot jago = new Parrot("Jago", 5, "piros", false); // TODO

            // ToString()
            Console.WriteLine("--------- ToString() ---------");
            Console.WriteLine(zsolti);
            Console.WriteLine(ubul);
            Console.WriteLine(scooby);
            Console.WriteLine(szofi);
            Console.WriteLine(rico);
            Console.WriteLine(jago);
            Console.WriteLine();

            // MakeSound()
            Console.WriteLine("--------- MakeSound() ---------");
            zsolti.MakeSound();
            ubul.MakeSound();
            scooby.MakeSound();
            szofi.MakeSound();
            rico.MakeSound();
            jago.MakeSound();
            Console.WriteLine();
        }
    }
}
