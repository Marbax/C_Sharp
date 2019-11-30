using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productHierarchy
{
    class Rum : ANutrition, IBreakable, IExcise, IFlammable, IFillable
    {
        private short _alc_by_volume;


        public short AlcByVolume
        {
            get { return _alc_by_volume; }
            set { _alc_by_volume = value; }
        }

        public bool Breacked { get; private set; }

        public void Break() { Breacked = true; }

        public double ExcisePercent { get; set; }

        public double CalcValueWithExcise() { return this.Value + this.Value * ExcisePercent; }

        public bool Flammable { get; private set; }
        public double Volume { get; private set; }

        public Rum(string name = "NONAME", string manufacturrer_name = "NOMANUFACTURRER", double value = 0,
            double calories = 0,
            short alc_by_voluvme = 0, double excise_percent = 0.0d, double volume = 0.0d)
            : base(name, manufacturrer_name, value, calories)
        {
            _alc_by_volume = alc_by_voluvme;
            ExcisePercent = excise_percent;
            Volume = volume;
            Breacked = false;
            Flammable = true;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nAlchohol by volume: {_alc_by_volume}" +
                $"\nIs Flamable: {Flammable}" +
                $"\nExcise percent: {ExcisePercent * 100}" +
                $"\nValue with excise: {CalcValueWithExcise()}" +
                $"\nVolume: {Volume}" +
                $"\nIs Breacked: {Breacked}";
        }

    }
}
