using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productHierarchy
{
    class Milk : ANutrition, IPerishable
    {
        public Milk(string name = "NONAME", string manufacturrer_name = "NOMANUFACTURRER", double value = 0,
            double calories = 0,
            DateTime endDate = new DateTime())
            : base(name, manufacturrer_name, value, calories)
        {
            this.EndDate = endDate;
            IsOutOfDate();
        }

        public bool OutOfDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool IsOutOfDate()
        {
            OutOfDate = EndDate < DateTime.Now ? true : false;
            return OutOfDate;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nUse until {EndDate}\n" +
                $"Is out of date \"{OutOfDate}\"";
        }
    }
}
