using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productHierarchy
{
    class AirFreshener : AHouseChemicals, IBreakable, IFlammable, IFillable
    {
        public bool Breacked { get; private set; }

        public bool Flammable { get; private set; }

        public double Volume { get; set; }

        public void Break() { Breacked = true; }

        public AirFreshener(string name = "NONAME", string manufacturrer_name = "NOMANUFACTURRER", double value = 0.0d,
            double toxicity = 0.0d,
            double volume = 0.0d)
            : base(name, manufacturrer_name, value, toxicity)
        {
            Volume = volume;
            Breacked = false;
            Flammable = true;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nVolume: {Volume}" +
                $"\nIs Breacked: {Breacked}" +
                $"\nIs Flammable: {Flammable}";
        }

    }
}
