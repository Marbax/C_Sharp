using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitance
{
    /*
    Создать базовый класс “Транспорт”. От него наследовать “Авто”, “Самолет”, “Поезд”. 
    От класса “Авто” наследовать классы “Легковое авто”, “Грузовое авто”. 
    От класса “Самолет” наследовать классы “Грузовой самолет” и “Пассажирский самолет”. 
    Придумать поля для базового класса, а также добавить поля в дочерние классы, которые будут конкретно характеризовать объекты дочерних классов.
    Определить конструкторы, методы для заполнения полей классов(или использовать свойства).
    Написать метод, который выводит информацию о данном виде транспорта и его характеристиках.
    Использовать виртуальные методы.
    */

    class Program
    {
        static void Main(string[] args)
        {
            //Transport car = new Car();
            //Console.WriteLine(car);
            //Transport light = new LightCar();
            //Console.WriteLine(light);
            //Transport truck = new Truck();
            //Console.WriteLine(truck);
            //Transport plain = new Plain();
            //Console.WriteLine(plain);
            //Transport cargo_plain = new CargoPlane();
            //Console.WriteLine(cargo_plain);
            //Transport passenger_plain = new PassengerPlane();
            //Console.WriteLine(passenger_plain);
            //Transport train = new Train();
            //Console.WriteLine(train);

            //car.Beep();
            //Console.WriteLine();
            //train.Beep();


            dynamic kv = new System.Dynamic.ExpandoObject();
            kv.Name = "Petro";
            kv.Name = 007;
            Console.WriteLine(kv.Name);

        }
    }
}
