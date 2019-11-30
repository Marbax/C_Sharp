using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productHierarchy
{
    abstract class ANutrition : AProduct
    {
        private double _calories;

        public double Calories
        {
            get { return _calories; }
            set { _calories = value; }
        }

        public ANutrition(string name = "NONAME", string manufacturrer_name = "NOMANUFACTURRER", double value = 0,
            double calories = 0)
            : base(name, manufacturrer_name, value)
        {
            _calories = calories;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nCalories: {_calories}";
        }
    }
}
