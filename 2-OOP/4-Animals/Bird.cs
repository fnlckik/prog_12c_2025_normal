using System;

namespace Animals
{
    internal class Bird : Animal
    {
        public bool canFly;

        public Bird(string name, int age, bool canFly) : base(name, age)
        {
            this.canFly = canFly;
            this.species = "Madár";
        }

        public override string ToString()
        {
            string fly = this.canFly ? "repül" : "nem repül";
            return base.ToString() + $" [{fly}]";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{this.name}: Csirip-csirip!");
        }
    }
}
