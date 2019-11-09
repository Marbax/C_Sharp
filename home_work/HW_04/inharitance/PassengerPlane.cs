using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitance
{
    //    От класса “Самолет” наследовать классы “Грузовой самолет” и “Пассажирский самолет”. 

    class PassengerPlane : Plain
    {
        private int _passengers;

        public int Passengers
        {
            get { return _passengers; }
            set { _passengers = value; }
        }

        public PassengerPlane(string title = "Passenger plain", int weight = 33, int speed = 700, int altitude = 330, int passengers = 200) :
    base(title, weight, speed, altitude)
        { _passengers = passengers; }

        public override string ToString()
        {
            return base.ToString() +
                $"Passengers carrying: {_passengers} persons\n";
        }

    }
}
