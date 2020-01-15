using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {
        /*
         * Реализовать метод, который осуществляет поиск элемента в массиве.
         * Метод должен принимать массив Object [] array, в котором должен осуществляться поиск,
         * и делегат, определяющий, является ли элемент искомым.
         */

        public delegate Object SerchDelegate(Object[] array);

        public static Object Search(Object[] array, Object to_find) => array.First(x => x.Equals(to_find));



        static void Main(string[] args)
        {

            Object[] arr = new Object[] { 2, 4, 's', "ss", 3, 's' };
            Console.WriteLine(Search(arr, 1));
        }
    }
}
