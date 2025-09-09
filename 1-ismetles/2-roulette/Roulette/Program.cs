using System;
using System.Threading;

namespace Roulette
{
    internal class Program
    {
        static void Plain(int number, int bet, ref int money)
        {
            Thread.Sleep(1000);
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
            Console.WriteLine($"Kezdőpénz: {money}");
            //Play(money);
            AutoPlay(money);
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
                Console.Write("Folytassuk? (Szám vagy N): ");
                string choice = Console.ReadLine();
                if (choice == "N")
                {
                    isFinished = true;
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
    }
}
