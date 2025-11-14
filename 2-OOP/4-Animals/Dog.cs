using System;

namespace Animals
{
    internal class Dog : Animal
    {
        public string breed; // fajta

        public Dog(string name, int age, string breed) : base(name, age)
        {
            this.breed = breed;
        }

        // Itt a hiba! Nem írtuk felül!
        public void MakeSound()
        {
            Console.WriteLine($"{name}: Vau!");
        }
    }
}
