using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productHierarchy
{
    abstract class AProduct : IComparable, ICloneable
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _manufacturrer_name;

        public string ManufacturerName
        {
            get { return _manufacturrer_name; }
            set { _manufacturrer_name = value; }
        }

        private double _value;

        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public AProduct(string name = "NONAME", string manufacturrer_name = "NOMANUFACTURRER", double value = 0)
        {
            _name = name;
            _manufacturrer_name = manufacturrer_name;
            _value = value;
        }

        public override string ToString()
        {
            return $"Name: {_name}\n" +
                $"Manufacturer: {_manufacturrer_name}\n" +
                $"Value: {_value}";
        }


        public virtual int CompareTo(object obj)
        {
            if (obj is AProduct)
                return _name.CompareTo(((AProduct)obj)._name);

            else
                throw new NotImplementedException();
        }

        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
