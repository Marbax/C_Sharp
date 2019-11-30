using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productHierarchy
{
    class ToiletPaper : AHouseChemicals
    {
        private float _length;


        public float Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public ToiletPaper(string name = "NONAME", string manufacturrer_name = "NOMANUFACTURRER", double value = 0,
            double toxicity = 0,
            float length = 0)
            : base(name, manufacturrer_name, value, toxicity)
        {
            _length = length;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nPapper length: {_length}";
        }

    }
}
