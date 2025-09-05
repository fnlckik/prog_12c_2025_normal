using System;

namespace Roulette
{
    internal class Program
    {
        static void Plain(int number, int bet, ref int money)
        {
            Random r = new Random();
            int winner = 5;//r.Next(37);
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

        static void GetBet(out int bet)
        {
            Console.Write("Tét: ");
            bet = int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int money = 500;
            while (money > 0)
            {
                Console.Write("Szám: ");
                int number = int.Parse(Console.ReadLine());
                int bet;
                GetBet(out bet);
                money -= bet;
                Plain(number, bet, ref money);
                Console.WriteLine($"Aktuális egyenleg: {money}\n");
            }
        }
    }
}
