// F1
List<int> numbers = [];
string path = "../../../../meres.txt";
using StreamReader sr = new(path);
// x => int.Parse(x)
numbers = sr.ReadLine()!.Split(", ").Select(int.Parse).ToList();
//Console.WriteLine(numbers.Count);

// F2
Console.WriteLine("2. feladat");
int totalCount = numbers.Where(x => x != -1).Sum();
Console.WriteLine($"Összesen {totalCount} kerékpárost számoltak.");

// F3
Console.WriteLine("\n3. feladat");
Console.WriteLine("Óránkénti mérések:");
int hour = 6;
int sum = 0; // Összegezzük az aktuális óra adatait
for (int i = 0; i < numbers.Count; i++)
{
	if (numbers[i] != -1) sum += numbers[i];
	if (i % 4 == 3)
	{
        Console.WriteLine($"{hour} órától {sum} kerékpáros");
		hour++;
		sum = 0;
	}
}

// F4
Console.WriteLine("\n4. feladat");
int maxValue = numbers.Max();

int maxIndex = numbers.IndexOf(maxValue);
int start = 360; // 6:00
int minute = start + (maxIndex + 1) * 15;
int maxHour = minute / 60;
int maxMinute = minute % 60;

Console.WriteLine($"Az áthaladók maximális száma: {maxValue}; a rögzítés időpontja: {maxHour}:{maxMinute}."); // 8:30