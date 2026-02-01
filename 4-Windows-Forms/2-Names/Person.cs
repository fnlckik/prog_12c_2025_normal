namespace _2_Names
{
    internal class Person
    {
        public Person(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary; // fizetés
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Age})";
        }
    }
}
