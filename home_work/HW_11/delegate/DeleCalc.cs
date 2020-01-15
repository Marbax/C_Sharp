using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    delegate double CalculateDelegate(double a, double b);

    class DeleCalc
    {
        CalculateDelegate[] calcD;

        public CalculateDelegate this[int index]
        {
            get { return calcD[index]; }
        }

        public DeleCalc()
        {
            calcD = new CalculateDelegate[]
            {
                Sum, Sub, Multy, Div
            };
        }

        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Multy(double a, double b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }

    }
}
