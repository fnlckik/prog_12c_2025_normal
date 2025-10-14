using System;

namespace Bitzeria
{
    internal class Rendeles
    {
        // Field - adattag
        private string nev;
        private bool kupon;
        private int koltseg;
        private string megjegyzes;

        // Constructor overloading
        public Rendeles() { }

        public Rendeles(string nev, bool kupon, int koltseg, string megjegyzes)
        {
            this.nev = nev;
            this.kupon = kupon;
            this.koltseg = koltseg;
            this.megjegyzes = megjegyzes;
        }

        //public string Nev
        //{ 
        //    get
        //    {
        //        return this.nev;
        //    }

        //    set
        //    {
        //        this.nev = value;
        //    }
        //}

        // Property - tulajdonság
        public bool Kupon { get => kupon; }
        public int Koltseg { get => koltseg; }
        public string Nev { get => nev; }

        public int Fizetendo
        {
            get
            {
                if (this.kupon)
                {
                    //return (int)(this.koltseg * 0.85);
                    //return (int)((double)(this.koltseg) / 100 * 85);
                    return Convert.ToInt32(this.koltseg * 0.85);
                }
                else
                {
                    return this.koltseg;
                }
            }
        }

        // Methods - metódusok
        public override string ToString()
        {
            return $"{nev} ({Fizetendo} Ft): {megjegyzes}";
        }
    }
}
