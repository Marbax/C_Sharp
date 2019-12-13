using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    /*
    Создать обобщенный класс двунаправленного списка(List).
        Для класса List реализовать следующие методы:
            ▪ добавление элемента в конец списка; +
            ▪ добавление элемента в указанную позицию; +
            ▪ добавление диапазона элементов в указанную позицию; +
            ▪ удаление элемента с начала списка; +
            ▪ удаление элемента из указанной позиции; +
            ▪ удаление диапазона элементов из указанной позиции; +
            ▪ вывод на экран содержимого списка; +
    */
    class Program
    {
        static void Main(string[] args)
        {
            DLList<int> ss = new DLList<int>();
            ss.Add(1);
            ss.Add(2);
            ss.Add(3);
            ss.Add(4);
            ss.Add(5);

            Console.WriteLine($"count = {ss.Count},  value at count = {ss[ss.Count]}");
            Console.WriteLine("\nfor");
            for (int i = 0; i < ss.Count; i++)
            {
                Console.WriteLine($"{i} = {ss[i]} ");
            }

            //Console.WriteLine($"\nRemove 1 : {ss.Remove(6)}");
            ss.RemoveAtRange(3,3);

            Console.WriteLine("\nforeach");
            foreach (var item in ss)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nfor");
            for (int i = 0; i < ss.Count; i++)
            {
                Console.WriteLine($"{i} = {ss[i]} ");
            }

            Console.WriteLine("count : " + ss.Count);
            ss.InsertRange(3,9,8,7);

            Console.WriteLine("print");
            ss.Print();



        }
    }
}
