using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitance
{
    //    Создать базовый класс “Транспорт”. От него наследовать “Авто”, “Самолет”, “Поезд”. 
    //    От класса “Самолет” наследовать классы “Грузовой самолет” и “Пассажирский самолет”. 

    public class Plain : Transport
    {
        private int _altitude;

        public int Altitude
        {
            get { return _altitude; }
            set { _altitude = value; }
        }

        public Plain(string title = "Deffault plain", int weight = 33, int speed = 500, int altitude = 300) : base(title, weight, speed) { _altitude = altitude; }

        public override string ToString()
        {
            return base.ToString() +
                $"Flight altitude: {_altitude} killometers\n";
        }

    }
}
