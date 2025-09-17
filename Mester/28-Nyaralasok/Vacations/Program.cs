using System;
using System.Collections.Generic;
using System.IO;

namespace Vacations
{
    internal class Program
    {
        struct Vacation
        {
            public int studentId;
            public string place;
        }

        static void Main(string[] args)
        {
            List<Vacation> vacations = new List<Vacation>();
            ReadFromFile(vacations, out int studentCount, "be1.txt");
            //Console.WriteLine(vacations.Count);
            T1(vacations);
            Dictionary<int, int> studentCounts = T2(vacations);
            T3(vacations);
            //T4(studentCount, studentCounts);
            T4(studentCount, vacations);
        }

        static void T4(int studentCount, List<Vacation> vacations)
        {
            List<bool> hasVacation = new List<bool>();
            // TODO
        }

        static void T4(int studentCount, Dictionary<int, int> studentCounts)
        {
            Console.WriteLine("#");
            int i = 1;
            while (i <= studentCount && studentCounts.ContainsKey(i))
            {
                i++;
            }
            if (i <= studentCount) Console.WriteLine(i);
            else Console.WriteLine(-1);
        }

        static void T3(List<Vacation> vacations)
        {
            Console.WriteLine("#");
            Dictionary<string, int> placeCounts = new Dictionary<string, int>();
            foreach (Vacation vacation in vacations)
            {
                if (placeCounts.ContainsKey(vacation.place))
                {
                    placeCounts[vacation.place]++;
                }
                else
                {
                    placeCounts.Add(vacation.place, 1);
                }
            }
            string maxPlace = "";
            int maxValue = -1;
            // Maximum kiválasztás tétel!
            // Homoki Márk módszer:
            //foreach (KeyValuePair<string, int> item in placeCounts)
            //{
            //    if (item.Value > maxValue)
            //    {
            //        maxValue = item.Value;
            //        maxPlace = item.Key;
            //    }
            //}
            foreach (string place in placeCounts.Keys)
            {
                if (placeCounts[place] > maxValue)
                {
                    maxValue = placeCounts[place];
                    maxPlace = place;
                }
            }
            Console.WriteLine(maxPlace);
        }

        private static Dictionary<int, int> T2(List<Vacation> vacations)
        {
            Console.WriteLine("#");
            Dictionary<int, int> studentCounts = new Dictionary<int, int>();
            foreach (Vacation vacation in vacations)
            {
                if (studentCounts.ContainsKey(vacation.studentId))
                {
                    studentCounts[vacation.studentId]++;
                }
                else
                {
                    studentCounts.Add(vacation.studentId, 1);
                }
            }
            foreach (KeyValuePair<int, int> item in studentCounts)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
            return studentCounts;
        }

        private static void T1(List<Vacation> vacations)
        {
            Console.WriteLine("#");
            HashSet<string> places = new HashSet<string>();
            foreach (Vacation vacation in vacations)
            {
                places.Add(vacation.place);
            }
            Console.WriteLine(places.Count);
        }

        private static void ReadFromFile(List<Vacation> vacations, out int studentCount, string file)
        {
            StreamReader sr = new StreamReader(file);
            string[] temp = sr.ReadLine().Split();
            studentCount = int.Parse(temp[0]);
            while (!sr.EndOfStream)
            {
                Vacation vacation;
                vacation.studentId = int.Parse(sr.ReadLine());
                vacation.place = sr.ReadLine();
                vacations.Add(vacation);
            }
            sr.Close();
        }
    }
}
