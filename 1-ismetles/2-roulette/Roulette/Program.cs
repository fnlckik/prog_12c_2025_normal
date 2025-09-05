using System;

namespace Roulette
{
    internal class Program
    {
        static void Plain(int number, int bet, ref int money)
        {
            Random r = new Random();
            int winner = r.Next(37);
            Console.WriteLine($"Nyertes szám: {winner}");
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

        static void GetBet(out int bet, int money)
        {
            do
            {
                Console.Write("Tét: ");
                bet = int.Parse(Console.ReadLine());
            } while (bet > money || bet <= 0);
        }

        static void Main(string[] args)
        {
            int money = 500;
            while (money > 0)
            {
                Console.Write("Szám: ");
                int number = int.Parse(Console.ReadLine());
                int bet;
                GetBet(out bet, money);
                money -= bet;
                Plain(number, bet, ref money);
                Console.WriteLine($"Aktuális egyenleg: {money}\n");
            }
        }
    }
}
