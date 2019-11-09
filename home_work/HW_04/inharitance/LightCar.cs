using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitance
{
    public class LightCar : Car
    {
        //   От класса “Авто” наследовать классы “Легковое авто”, “Грузовое авто”. 

        private int _passengers;

        public int Passengers
        {
            get { return _passengers; }
            set { _passengers = value; }
        }

        public LightCar(string title = "Light car", int weight = 10, int speed = 150, string model = "Lada", int passengers = 4) :
            base(title, weight, speed, model)
        { _passengers = passengers; }

        public override string ToString()
        {
            return base.ToString() +
                $"Passengers count: {_passengers} persons\n";
        }
    }
}
