using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_03
{
    class Group
    {
        private Person[] _arr;

        public Group()
        {
            _arr = new Person[5]
            {
                new Person("Masha",DateTime.Parse("1231-12-12")),
                new Person("petya",DateTime.Now),
                new Person("Grisha",DateTime.Parse("1993.12.01")),
                new Person("Anton", DateTime.Now),
                new Person("Fillya",DateTime.Now)
            };
        }


        public int Length => _arr.Length; // прокидывание свойства

        public Person this[int index] // перегруз индексации 
        {
            get => _arr[index];
            set => _arr[index] = value;
        }
    }
}
