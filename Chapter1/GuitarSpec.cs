using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    public class GuitarSpec
    {
        public Builder Builder { get; private set; }
        public string Model { get; private set; }
        public Type Type { get; private set; }
        public Wood BackWood { get; private set; }
        public Wood TopWood { get; private set; }

        public GuitarSpec(Builder builder, string model, Type type,
                    Wood backWood, Wood topWood)
        {
            this.Builder = builder;
            this.Model = model;
            this.Type = type;
            this.BackWood = backWood;
            this.TopWood = topWood;
        }
    }
}
