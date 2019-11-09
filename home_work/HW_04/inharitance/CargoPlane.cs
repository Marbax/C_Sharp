using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitance
{
    //    От класса “Самолет” наследовать классы “Грузовой самолет” и “Пассажирский самолет”. 

    public class CargoPlane : Plain
    {
        private int _volume;

        public int Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }

        public CargoPlane(string title = "Cargo plain", int weight = 26, int speed = 470, int altitude = 250, int volume = 200) :
            base(title, weight, speed, altitude)
        { _volume = volume; }

        public override string ToString()
        {
            return base.ToString() +
                $"Body volume: {_volume} square meters\n";
        }

    }
}
