using System;
using System.Collections.Generic;
using System.Text;

namespace MyHobbies
{
    enum Geslacht
    {
        man,
        vrouw
    }

    class Bandlid
    {
        public Bandlid(String naam, Geslacht geslacht, int geboortejaar, bool levend)
        {
            Naam = naam;
            Geslacht = geslacht;
            Geboortejaar = geboortejaar;
            Levend = levend;
        }

        public string Naam { get; set; }
        public Geslacht Geslacht { get; set; }
        public int Geboortejaar { get; set; }
        public int Leeftijd
        {
            get
            {
                return new DateTime().Year - Geboortejaar;
            }
        }
        public bool Levend { get; set; }

    }
}
