using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class Guitar
    {
        public string SerialNumber { get; private set; }
        public Builder Builder { get; private set; }
        public string Model { get; private set; }
        public Type Type { get; private set; }
        public Wood BackWood { get; private set; }
        public Wood TopWood { get; private set; }
        public double Price { get; private set; }

        public Guitar(string serialNumber, double price, Builder builder,
                 string model, Type type, Wood backWood, Wood topWood)
        {
            this.SerialNumber = serialNumber;
            this.Price = price;
            this.Builder = builder;
            this.Model = model;
            this.Type = type;
            this.BackWood = backWood;
            this.TopWood = topWood;
        }
    }
}
