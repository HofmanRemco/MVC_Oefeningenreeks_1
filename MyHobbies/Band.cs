using System;
using System.Collections.Generic;
using System.Text;

namespace MyHobbies
{
    class Band
    {
        public Band(int jaar, String naam) {
            Jaar = jaar;
            Naam = naam;
            Bandleden = new LinkedList<Bandlid>();
        }

        public int Jaar { get; set; }
        public string Naam { get; set; }
        public LinkedList<Bandlid> Bandleden { get; set; }
    }
}
