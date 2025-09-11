using System;
using System.Collections.Generic;
using System.IO;
//using System.Threading;

namespace Roulette
{
    internal class Program
    {
        // static: osztályszintű tagváltozó / metódus
        // (Az osztályhoz tartozik, nem az objektumhoz.)
        // => Nincs szükség példányosításra a használatához!
        static public Random r = new Random();
        static public HashSet<int> red = new HashSet<int>();
        static public HashSet<int> black = new HashSet<int>();

        static char GetColor(int n)
        {
            if (red.Contains(n)) return 'R';
            else if (black.Contains(n)) return 'B';
            else return 'G';
        }

        static void Plain(int number, int bet, ref int money)
        {
            //Thread.Sleep(1);
            //Random r = new Random();
            int winner = r.Next(37);
            char color = GetColor(winner);
            Console.WriteLine($"Nyertes szám: {winner} ({color})");
            if (number == winner)
            {
                Console.WriteLine($"Nyeremény: {bet * 36}");
                money += bet * 36;
            }
            else
            {
                Console.WriteLine("Nem nyert!");
            }
        }

        static void RedBlack(string choice, int bet, ref int money)
        {
            int winner = r.Next(37);
            char color = GetColor(winner);
            Console.WriteLine($"Nyertes szám: {winner} ({color})");
            if (choice == color.ToString())
            {
                Console.WriteLine($"Nyeremény: {bet * 2}");
                money += bet * 2;
            }
            else
            {
                Console.WriteLine("Nem nyert!");
            }
        }

        static void GetBet(out int bet, int money)
        {
            do
            {
                Console.Write("Tét: ");
                bet = int.Parse(Console.ReadLine());
            } while (bet > money || bet <= 0);
        }

        // Beolvas egy sort, és a set halmazba eltárolja.
        static void ReadRow(StreamReader sr, HashSet<int> set)
        {
            string[] temp = sr.ReadLine().Split(' ');
            foreach (string item in temp)
            {
                set.Add(int.Parse(item));
            }
        }

        static void ReadFromFile(string file)
        {
            StreamReader sr = new StreamReader(file);
            sr.ReadLine();
            ReadRow(sr, red);
            ReadRow(sr, black);
            sr.Close();
        }

        static void AutoPlay(int money)
        {
            while (money > 0)
            {
                int number = 1;
                int bet = 100;
                money -= bet;
                Plain(number, bet, ref money);
                Console.WriteLine($"Aktuális egyenleg: {money}\n");
            }
        }

        static void Play(int money)
        {
            bool isFinished = false;
            while (money > 0 && !isFinished)
            {
                Console.Write("Folytassuk? Szám (0-36) | Red (R) | Black (B) | No (N)): ");
                string choice = Console.ReadLine().ToUpper();
                if (choice == "N")
                {
                    isFinished = true;
                }
                else if (choice == "R" || choice == "B")
                {
                    GetBet(out int bet, money);
                    money -= bet;
                    RedBlack(choice, bet, ref money);
                    Console.WriteLine($"Aktuális egyenleg: {money}\n");
                }
                else
                {
                    int number = int.Parse(choice);
                    GetBet(out int bet, money);
                    money -= bet;
                    Plain(number, bet, ref money);
                    Console.WriteLine($"Aktuális egyenleg: {money}\n");
                }
            }
        }

        static void Main(string[] args)
        {
            int money = 500;
            Console.WriteLine($"Kezdőpénz: {money}");
            ReadFromFile("szinek.txt");
            Play(money);
            //AutoPlay(money);
        }
    }
}
