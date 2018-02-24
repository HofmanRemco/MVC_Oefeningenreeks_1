using System;
using System.Collections.Generic;
using System.Text;

namespace MyHobbies
{
    public enum Geslacht
    {
        man,
        vrouw
    }

    public class Bandlid
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
                return DateTime.Now.Year - Geboortejaar;
            }
        }
        public bool Levend { get; set; }

    }
}
