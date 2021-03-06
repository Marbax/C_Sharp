﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_03
{
    public class Person
    {
        private string _name;
        private readonly DateTime _birthday;
        private static int _counter = 0; // рання инициализация статического поля (зараннее , не перед первым вызовом типа)
        public const string Planet = "Earth";


        public string LastName { get; set; } // публичное поле класса с геттером и сеттером "Автосвойство"

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public static int Counter => _counter; // только геттер

        public DateTime Birthday => _birthday;

        //public string GetName() => _name; // getter в одну строку
        //public void SetName(string _name) => this._name = _name; // присвоение значения в одну строку 

        static Person()
        {
            Console.WriteLine("Static constructor"); // непонятно когда вызывается ,знает только CLR (где то перед созданием класса)
            _counter = 0; // поздняя инициализация , прям перед первым вызовом типа
        }

        public Person() : this("NONAME", DateTime.Now) {} // делегирование своему констроктору (текущее время ,до секунды)
        
        public Person(string _name, DateTime birthday)
        {
            this._name = _name; // ссылка присваевается ссылке из вне она не поменяется ,т.к. строки неизменны
            _birthday = birthday;
            _counter++;
        }

        public static void Swap(ref int a ,ref int b)
        {
            (a, b) = (b,a);
        }

        public override string ToString()
        {
            return $"Name: {_name}\n" +
                $"Surname: {LastName}\n"+
                $"Birthday: {_birthday.ToLongDateString()}\n" +
                $"Planet: {Planet}\n" +
                $"Number of people: {_counter}";
        }
    }
}
