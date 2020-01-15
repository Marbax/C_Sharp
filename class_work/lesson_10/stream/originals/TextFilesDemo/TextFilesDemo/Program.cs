using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFilesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Считывание данных из файла:
            string content;
            string path1 = @"..\..\input.txt";
            using (FileStream fs = new FileStream(path1, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    content = sr.ReadToEnd();
                }
            }
            Console.WriteLine(content);

            // 2 - Создание массива фамилий:
            Console.WriteLine();
            string[] names = content.Split('\n');
            Console.WriteLine(names[0]);
            Array.Resize(ref names, names.Length - 1);

            // 3 - Сортировка:
            Array.Sort(names);
            Console.WriteLine();
            int k = 0;
            foreach (string name in names)
            {
                k++;
                Console.WriteLine($"{k}. {name}");
            }

            // 4 - Запись отсортированного списка в файл:
            string path2 = @"..\..\output.txt";
            using (FileStream fs = new FileStream(path2, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    int n = 0;
                    foreach (string name in names)
                    {
                        n++;
                        sw.Write($"{n}. {name}");
                    }
                }
            }
            Console.WriteLine("\n> Данные успешно сохранены");

            // # - Finish
            Console.WriteLine("\nПрограмма завершена");
        }
    }
}
