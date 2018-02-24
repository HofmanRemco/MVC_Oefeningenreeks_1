using System;
using System.Collections.Generic;
using System.Text;

namespace MyHobbies
{
    class Band
    {
        public int Jaar { get; set; }
        public string Naam { get; set; }
        public LinkedList<Bandlid> Bandleden { get; set; }
    }
}
