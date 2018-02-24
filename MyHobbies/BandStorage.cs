using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyHobbies
{
    interface IBandStorage
    {
        ReadOnlyCollection<Band> GetBands();
        void AddBand(Band b);
    }

    class BandStorage : IBandStorage
    {
        private static Band[] start = { new Band(2002, "Arctic Monkeys"), new Band(1996, "Coldplay") };
        private List<Band> memory = new List<Band>(start);
        public ReadOnlyCollection<Band> GetBands()
        {
            return memory.AsReadOnly();
        }
        public void AddBand(Band b)
        {
            memory.Add(b);
        }
    }
}
