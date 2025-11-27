using System;

namespace Animals
{
    internal class Parrot : Bird, ITrickPerformer
    {
        public string color;

        public Parrot(string name, int age, string color, bool canFly = true) : base(name, age, canFly)
        {
            this.color = color;
            this.canFly = true;
        }

        public void PerformTrick()
        {
            Console.WriteLine($"{name} viccet mesél.");
        }
    }
}
