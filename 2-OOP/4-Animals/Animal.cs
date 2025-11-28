using System;

namespace Animals
{
    // Az "Animal" őse az "Object"
    internal abstract class Animal : IComparable<Animal>
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

        // +: this > other (+1)
        // -: this < other (-1)
        // 0: this == other
        public int CompareTo(Animal other)
        {
            if (this.age > other.age ||
                this.age == other.age && this.name.CompareTo(other.name) > 0)
            {
                return 1;
            }
            if (this.age < other.age ||
                this.age == other.age && this.name.CompareTo(other.name) < 0)
            {
                return -1;
            }
            return 0;
            //return this.age - other.age;
        }

        //public int CompareTo(object obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
