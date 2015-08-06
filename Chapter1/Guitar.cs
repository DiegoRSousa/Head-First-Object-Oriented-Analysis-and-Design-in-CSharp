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
        public double Price { get; private set; }
        public GuitarSpec Spec { get; private set; }

        public Guitar(string serialNumber, double price, Builder builder,
                 string model, Type type, Wood backWood, Wood topWood)
        {
            this.SerialNumber = serialNumber;
            this.Price = price;
            this.Spec = new GuitarSpec(builder, model,type, backWood, topWood);
        }
    }
}
