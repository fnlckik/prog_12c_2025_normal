using System;

namespace Animals
{
    // Az "Animal" őse az "Object"
    internal abstract class Animal
    {
        // public: mindenhol látható
        // protected: látható az osztályban, és a leszármazott osztályokban
        // private: csak az osztályon belül látható
        public string name;
        public int age;
        protected string species;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.species = "Ismeretlen faj...";
        }

        public override string ToString()
        {
            return $"{name} {age} éves. Faj: {this.species} Osztály: {this.GetType()}";
        }

        // virtual: felül lehet írni leszármazott osztályban
        //public virtual void MakeSound()
        //{
        //    Console.WriteLine("Általános állat hangok..");
        //}

        // abstract: olyan metódus, aminek nincs törzse, csak fejléc
        // Fontos! Abstract metódus csak abstract osztályban lehet!
        public abstract void MakeSound();
    }
}
