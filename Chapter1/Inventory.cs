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

        public void AddGuitar(string serialNumber, double price, string builder,
                         string model, string type, string backWood, String topWood)

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

        public Guitar Search(Guitar searchGuitar)
        {
            foreach (Guitar guitar in guitars)
            {
                // Ignore serial number since that's unique
                // Ignore price since that's unique
                var builder = searchGuitar.Builder;
                if ((builder != null) && (!builder.Equals("")) && (!builder.Equals(guitar.Builder)))
                    continue;

                var model = searchGuitar.Model;
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitar.Model)))
                    continue;

                var type = searchGuitar.Model;
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitar.Model)))
                    continue;

                var backWood = searchGuitar.BackWood;
                if ((backWood != null) && (!backWood.Equals("")) && (!backWood.Equals(guitar.BackWood)))
                    continue;

                var topWood = searchGuitar.TopWood;
                if ((topWood != null) && (!topWood.Equals("")) && (!topWood.Equals(guitar.TopWood)))
                    continue;

                return guitar;
            }
            return null;
        }
    }
}
