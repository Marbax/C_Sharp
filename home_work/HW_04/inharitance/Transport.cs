using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitance
{
    //    Создать базовый класс “Транспорт”. От него наследовать “Авто”, “Самолет”, “Поезд”. 
    abstract public class Transport
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private int _weight;

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        private int _speed;

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public Transport() : this("NONAME", 0, 0) { }
        public Transport(string title, int weight, int speed)
        {
            _title = title;
            _weight = weight;
            _speed = speed;
        }

        virtual public void Beep() { Console.WriteLine("Be-e-e-ep!!"); }
        public override string ToString()
        {
            return $"Vehicle \"{_title}\"\n" +
                $"Weight: {_weight} tons\n" +
                $"Speed: {_speed} killometers\n";
        }

    }
}
