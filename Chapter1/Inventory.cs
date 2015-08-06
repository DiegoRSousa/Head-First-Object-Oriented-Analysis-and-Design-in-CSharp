using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, GuitarSpec spec)

        {
            var guitar = new Guitar(serialNumber, price, spec);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (Guitar guitar in guitars)
            {
                if (guitar.SerialNumber.Equals(serialNumber))
                    return guitar;
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            var matchingGuitars = new List<Guitar>();
            foreach (Guitar guitar in guitars)
            {
                if (guitar.Spec.Matches(searchSpec))
                    matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
    }
}
