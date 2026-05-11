using System;

namespace Election
{
    public class Vote
    {
        public Vote(string name, DateTime birth, char @class, string party)
        {
            Name = name;
            Birth = birth;
            Class = @class;
            Party = party;
        }

        public string Name { get; }
        public DateTime Birth { get; }
        public char Class { get; } // Osztálya: A, B, C, T
        public string Party { get; set; } // Melyik pártra szavazott?
    }
}
