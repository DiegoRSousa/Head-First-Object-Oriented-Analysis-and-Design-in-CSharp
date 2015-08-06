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
        public int NumStrings { get; private set; }
        public Wood BackWood { get; private set; }
        public Wood TopWood { get; private set; }

        public GuitarSpec(Builder builder, string model, Type type, int numString,
                    Wood backWood, Wood topWood)
        {
            this.Builder = builder;
            this.Model = model;
            this.Type = type;
            this.NumStrings = numString;
            this.BackWood = backWood;
            this.TopWood = topWood;
        }

        public bool Matches(GuitarSpec otherSpec)
        {
            if (Builder != otherSpec.Builder)
                return false;
            if ((Model != null) && (!Model.Equals("")) &&
                (!Model.ToLower().Equals(otherSpec.Model.ToLower())))
                return false;
            if (Type != otherSpec.Type)
                return false;
            if (NumStrings != otherSpec.NumStrings)
                return false;
            if (BackWood != otherSpec.BackWood)
                return false;
            if (TopWood != otherSpec.TopWood)
                return false;
            return true;
        }
    }
}
