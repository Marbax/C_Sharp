using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productHierarchy
{
    class AHouseChemicals : AProduct
    {
        private double _toxicity;


        public double Toxicity
        {
            get { return _toxicity; }
            set { _toxicity = value; }
        }

        public AHouseChemicals(string name = "NONAME", string manufacturrer_name = "NOMANUFACTURRER", double value = 0,
            double toxicity = 0)
            : base(name, manufacturrer_name, value)
        {
            _toxicity = toxicity;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nToxicity: {_toxicity}";
        }

    }
}
