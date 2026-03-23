using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kings
{
    internal class King
    {
        public King(string name, int year, string place, int start, int end, string dynasty)
        {
            Name = name;
            Year = year;
            Place = place;
            Start = start;
            End = end;
            Dynasty = dynasty;
        }

        // Adattag, mező (field)
        //private string name;

        // Getter metódus
        //public string getName()
        //{
        //    return Name;
        //}

        // Tulajdonság (property)
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    private set
        //    {
        //        name = value;
        //    }
        //}

        public string Name { get; }
        public int Year { get; }
        public string Place { get; }
        public int Start { get; }
        public int End { get; }
        public string Dynasty { get; }
    }
}
