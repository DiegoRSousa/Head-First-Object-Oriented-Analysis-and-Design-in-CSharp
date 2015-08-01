﻿using System;
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

        public List<Guitar> Search(Guitar searchGuitar)
        {
            var matchingGuitars = new List<Guitar>();
            foreach (Guitar guitar in guitars)
            {
                // Ignore serial number since that's unique
                // Ignore price since that's unique
                if (searchGuitar.Builder != guitar.Builder)
                    continue;
                var model = searchGuitar.Model;
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitar.Model)))
                    continue;
                
                if (searchGuitar.Type != guitar.Type)
                    continue;

                if (searchGuitar.BackWood != guitar.BackWood)
                    continue;

                if (searchGuitar.TopWood != guitar.TopWood)
                    continue;

                matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
    }
}
