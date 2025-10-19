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

        public Rendeles Legdragabb()
        {
            Rendeles maxRendeles = rendelesek[0];
            foreach (Rendeles rendeles in rendelesek)
            {
                if (maxRendeles.Fizetendo < rendeles.Fizetendo)
                {
                    maxRendeles = rendeles;
                }
            }
            return maxRendeles;
        }

        public void KupontalanokFajlba_HM()
        {
            StreamWriter sw = new StreamWriter("nevek.txt");
            // vasarlok[nev]: a "nev" nevű vásárló használt-e kupont?
            Dictionary<string, bool> vasarlok = new Dictionary<string, bool>();
            foreach (Rendeles rendeles in rendelesek)
            {
                if (!vasarlok.ContainsKey(rendeles.Nev))
                {
                    vasarlok.Add(rendeles.Nev, false);
                }
                if (rendeles.Kupon)
                {
                    vasarlok[rendeles.Nev] = true;
                }
            }
            foreach (string nev in vasarlok.Keys)
            {
                if (!vasarlok[nev])
                {
                    sw.WriteLine(nev);
                }
            }
            sw.Close();
        }

        public void KupontalanokFajlba_DIC()
        {
            StreamWriter sw = new StreamWriter("nevek.txt");
            // vasarlok[nev]: a "nev" nevű vásárló hányszor használt kupont?
            Dictionary<string, int> vasarlok = new Dictionary<string, int>();
            foreach (Rendeles rendeles in rendelesek)
            {
                if (!vasarlok.ContainsKey(rendeles.Nev))
                {
                    vasarlok.Add(rendeles.Nev, 0);
                }
                if (rendeles.Kupon)
                {
                    vasarlok[rendeles.Nev]++;
                }
            }
            foreach (string nev in vasarlok.Keys)
            {
                if (vasarlok[nev] == 0)
                {
                    sw.WriteLine(nev);
                }
            }
            sw.Close();
        }

        public void KupontalanokFajlba()
        {
            HashSet<string> nevek = new HashSet<string>();
            HashSet<string> kuponosak = new HashSet<string>();
            foreach (Rendeles rendeles in rendelesek)
            {
                nevek.Add(rendeles.Nev);
                if (rendeles.Kupon)
                {
                    kuponosak.Add(rendeles.Nev);
                }
            }
            // Kik azok, akik a nevek halmazban benne vannak,
            // de a kuponosakban nincsenek?
        }
    }
}
