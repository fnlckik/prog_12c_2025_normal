using System;
using System.Collections.Generic;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Példányosítás
            // Fontos! Abstract osztályt nem lehet példányosítani!
            //Animal zsolti = new Animal("Zsolti", 67);
            Dog ubul = new Dog("Ubul", 5, "beagle");
            Animal scooby = new Dog("Scooby", 12, "dándog");
            Cat szofi = new Cat("Szofi", 7);
            //double a = 4;
            Bird rico = new Bird("Rico", 3, false); // pingvin
            Parrot jago = new Parrot("Jago", 5, "piros", false); // TODO
            Duck donald = new Duck("Donald", 8);
            PersianCat uborka = new PersianCat("Uborka", 5);
            
            List<Animal> animals = new List<Animal>
            { 
                ubul, scooby, szofi, rico, jago, donald, uborka
            };

            animals.Sort();

            // ToString()
            Console.WriteLine("--------- ToString() ---------");
            //Console.WriteLine(zsolti);
            //Console.WriteLine(ubul);
            //Console.WriteLine(scooby);
            //Console.WriteLine(szofi);
            //Console.WriteLine(rico);
            //Console.WriteLine(jago);
            //Console.WriteLine(donald);
            //ubul.species = "Hüllő";
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine();

            // MakeSound()
            Console.WriteLine("--------- MakeSound() ---------");
            //zsolti.MakeSound();
            //ubul.MakeSound();
            //scooby.MakeSound();
            //szofi.MakeSound();
            //rico.MakeSound();
            //jago.MakeSound();
            //donald.MakeSound();
            
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
            Console.WriteLine();

            // GivePaw()
            Console.WriteLine("--------- GivePaw() ---------");
            //ubul.GivePaw();
            //Dog dog = scooby as Dog;
            //dog.GivePaw();
            foreach (Animal animal in animals)
            {
                //if (animal is Dog)
                //{
                //    Dog dog = animal as Dog;
                //    dog.GivePaw();
                //}
                Dog dog = animal as Dog;
                dog?.GivePaw(); // ha nem null a dog, akkor hívjuk a metódust
            }
            Console.WriteLine();

            // PerformTrick()
            Console.WriteLine("--------- PerformTrick() ---------");
            //ubul.PerformTrick();
            //jago.PerformTrick();
            foreach (Animal animal in animals)
            {
                //if (animal is Dog)
                //{
                //    Dog dog = animal as Dog;
                //    dog.PerformTrick();
                //}
                //if (animal is Parrot)
                //{
                //    Parrot parrot = animal as Parrot;
                //    parrot.PerformTrick();
                //}
                /*
                if (animal is ITrickPerformer)
                {
                    ITrickPerformer performer = animal as ITrickPerformer;
                    performer.PerformTrick();
                }
                */
                ITrickPerformer performer = animal as ITrickPerformer;
                performer?.PerformTrick();
            }
            Console.WriteLine();

            // Sleep()
            Console.WriteLine("--------- Sleep() ---------");
            foreach (Animal animal in animals)
            {
                animal.Sleep();
            }
        }
    }
}
