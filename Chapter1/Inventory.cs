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

        public void AddGuitar(string serialNumber, double price, Builder builder,
                 string model, Type type, Wood backWood, Wood topWood)

        {
            var guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
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
                var guitarSpec = guitar.Spec;

                if (searchSpec.Builder != guitarSpec.Builder)
                    continue;
                var model = searchSpec.Model;
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitarSpec.Model)))
                    continue;
                
                if (searchSpec.Type != guitarSpec.Type)
                    continue;

                if (searchSpec.BackWood != guitarSpec.BackWood)
                    continue;

                if (searchSpec.TopWood != guitarSpec.TopWood)
                    continue;

                matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
    }
}
