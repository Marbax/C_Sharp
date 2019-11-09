using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitance
{
    //    Создать базовый класс “Транспорт”. От него наследовать “Авто”, “Самолет”, “Поезд”. 
    //    От класса “Авто” наследовать классы “Легковое авто”, “Грузовое авто”. 

    public class Car : Transport
    {
        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public override void Beep()
        {
            Console.Write($"{Title}. "); base.Beep();
            Console.WriteLine($"Like a {Model}");
        }

        public Car(string title = "Deffault car", int weight = 12, int speed = 180, string model = "Toyota") : base(title, weight, speed) { _model = model; }

        public override string ToString()
        {
            return base.ToString() +
                $"Model: {_model}\n";
        }
    }
}

