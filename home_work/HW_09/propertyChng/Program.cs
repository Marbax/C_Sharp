using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertyChng
{
    class Program
    {
        /*
         *
         *  Интерфейс INotifyPropertyChanged пространства имен System.
         *  ComponentModel определяет, что наследник содержит событие PropertyChanged,
         *  оповещающее об изменении свойства объекта.
         *  
         *  Изучить данный интерфейс, используя MSDN Library. 
         *  Разработать классы: Author, Client, LibraryCard, Catalogue. 
         *  
         *  Описать их поля, поля инкапсулировать свойствами и для классов реализовать интерфейс INotifyPropertyChanged.
         * 
         */

        static void Main(string[] args)
        {
            Client cl1 = new Client("Petro");
            Console.WriteLine(cl1);
            cl1.Name = "Pavel";
            Console.WriteLine(cl1);
            LibraryCard lb = new LibraryCard("card",cl1);

            Console.WriteLine();
            Console.WriteLine(lb);
            lb.Client = new Client("anton");

            Console.WriteLine();
            Console.WriteLine(lb);
        }
    }
}
