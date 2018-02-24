using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyHobbies
{
    public class Band
    {
        private List<Bandlid> Bandleden;

        public Band(int jaar, String naam)
        {
            Jaar = jaar;
            Naam = naam;
            Bandleden = new List<Bandlid>();
        }

        public int Jaar { get; set; }
        public string Naam { get; set; }
        public ReadOnlyCollection<Bandlid> GetBandleden()
        {
            return Bandleden.AsReadOnly();
        }
        public void AddBandlid(Bandlid b)
        {
            Bandleden.Add(b);
        }
        public void RemoveBandlid(Bandlid b)
        {
            Bandleden.Remove(b);
        }
    }
}
