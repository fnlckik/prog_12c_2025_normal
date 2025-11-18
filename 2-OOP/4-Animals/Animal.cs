using System;

namespace Animals
{
    // Az "Animal" őse az "Object"
    internal class Animal
    {
        public string name;
        public int age;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{name} {age} éves. Osztály: {this.GetType()}";
        }

        // virtual: felül lehet írni leszármazott osztályban
        public virtual void MakeSound()
        {
            Console.WriteLine("Általános állat hangok..");
        }
    }
}
