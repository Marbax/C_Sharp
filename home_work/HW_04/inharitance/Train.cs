using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitance
{
    //  Создать базовый класс “Транспорт”. От него наследовать “Авто”, “Самолет”, “Поезд”. 

    public class Train : Transport
    {
        private int _wagons;

        public int Wagons
        {
            get { return _wagons; }
            set { _wagons = value; }
        }

        public override void Beep()
        {
            Console.WriteLine($"Major Pain told you a story about the train whom was able...");
        }
        public Train(string title = "Deffault train", int weight = 155, int speed = 200, int wagons = 16) : base(title, weight, speed) { _wagons = wagons; }

        public override string ToString()
        {
            return base.ToString() +
                $"Wagons count: {_wagons}\n";
        }

    }
}
