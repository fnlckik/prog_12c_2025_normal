using System;
using System.Collections.Generic;
using System.IO;

namespace Bitzeria
{
    internal class Forgalom
    {
        private List<Rendeles> rendelesek;

        public Forgalom(string fileName)
        {
            rendelesek = new List<Rendeles>();
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split(';');
                string name = temp[0];
                //bool hasCoupon = Convert.ToBoolean(temp[1]);
                bool hasCoupon = temp[1] == "1";
                int cost = int.Parse(temp[2]);
                string comment = sr.ReadLine();
                Rendeles rendeles = new Rendeles(name, hasCoupon, cost, comment);
                rendelesek.Add(rendeles);
            }
            sr.Close();
        }

        public int OrderCount
        {
            get => rendelesek.Count;
        }
    }
}
