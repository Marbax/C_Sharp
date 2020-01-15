using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univer
{
    /*
     * Ваша задача - разработать прототип системы управления 
     * персональными данными студентов Университета на основе агрегирования по цепочке: 
     *      студент-группа-факультет-Универ. 
     * 
     * Следует задействовать бинарную сериализацию.
     */

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DataManager dm = new DataManager();
                dm.LoadData();



                Console.WriteLine(dm.Univer.Faculties[0].Groups[1].Students[0]);

                dm.Univer.Faculties[0].Groups[1].Students[0].FullName = "Petrovich";

                Console.WriteLine(dm.Univer.Faculties[0].Groups[1].Students[0]);

            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }



    }
}

