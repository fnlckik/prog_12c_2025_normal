using System;

namespace Animals
{
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
            return $"{name} {age} éves. Osztály: {this.GetType().Name}";
        }

        public void MakeSound()
        {
            Console.WriteLine("Általános állat hangok..");
        }
    }
}
