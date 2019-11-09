using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitance
{
    //  От класса “Авто” наследовать классы “Легковое авто”, “Грузовое авто”. 

    public class Truck : Car
    {
        private int _carrying;

        public int Carrying
        {
            get { return _carrying; }
            set { _carrying = value; }
        }

        public Truck(string title = "Truck car", int weight = 50, int speed = 90, string model = "Truck Monster", int carrying = 40) :
            base(title, weight, speed, model)
        { _carrying = carrying; }

        public override string ToString()
        {
            return base.ToString() +
                $"Carrying weight: {_carrying} tons\n";
        }

    }
}
