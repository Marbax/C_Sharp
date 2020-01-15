using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stream
{
    class Program
    {
        public static string ReadFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                byte[] readBytes = new byte[(int)fs.Length];
                // считываем данные из файла
                fs.Read(readBytes, 0, readBytes.Length);
                // преобразуем байты в строку
                return Encoding.UTF8.
                GetString(readBytes);
            }
        }

        public static void WriteFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                // получаем данные для записи в файл
                Console.WriteLine("Enter the data to write to the file: ");
                string writeText = Console.ReadLine();
                // преобразуем строку в массив байт
                byte[] writeBytes = Encoding.Default.
                GetBytes(writeText);
                // записываем данные в файл
                fs.Write(writeBytes, 0, writeBytes.Length);
                Console.WriteLine("Information recorded!");
            }
        }

        public static void WriteFileStreamOver(string filePath, string data)
        {
            using (FileStream fs_write = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter sr_to = new StreamWriter(fs_write, Encoding.UTF8))
                {
                    sr_to.WriteLine(data);
                }
            }
        }

        public static string ReadFileStream(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
                    return sr.ReadToEnd();
            }
        }

        // not working
        public static string Foo(string data)
        {
            string[] arr = data.Split('\n', '\r');
            double[] some = new double[arr.Length];
            int i = 0;

            foreach (var item in arr)
            {
                some[i++] = double.Parse(item);
            }

            double sum = some.Sum();

            double[] err = new double[some.Length];

            for (int j = 0; j < some.Length; j++)
            {
                err[j] = Math.Abs(some[j] - some.Average());
            }
            double errsum = err.Sum();

            return $"{some.Average()}\n{errsum / some.Length}";
        }

        public static void CopyFileStream(string from_filePath, string to_filePath)
        {
            using (FileStream fs_read = new FileStream(from_filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr_from = new StreamReader(from_filePath, Encoding.UTF8))
                {
                    using (FileStream fs_write = new FileStream(to_filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        using (StreamWriter sr_to = new StreamWriter(fs_write, Encoding.UTF8))
                        {
                            sr_to.WriteLine(sr_from.ReadToEnd());
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            string input = @"..\..\input.txt";
            string otput = @"..\..\otput.txt";

            // Read - write examples
            /*
            Console.WriteLine(ReadFile(input));

            Console.WriteLine("\n\n\n");

            Console.WriteLine(ReadFileStream(input));

            Console.WriteLine($"\nBefore copied : \n{ReadFileStream(otput)}");
            CopyFileStream(input, otput);
            Console.WriteLine($"\nAfter copied : \n{ReadFileStream(otput)}");
            */


            /*
            WriteFileStreamOver(input, "123\n127\n155\n188\n198\n234\n123");
            Console.WriteLine(ReadFileStream(input));

            CopyFileStream(Foo(ReadFileStream(input)), otput);
            Console.WriteLine(ReadFileStream(otput));
            */

            DataManager damn = new DataManager();
            //damn.InitData();

            //damn.SaveData();

            damn.LoadData();
            //damn.company.Departments[1].InputNewEmploye();
            damn.SaveData();
            //damn.company.Display();

            //Console.WriteLine(damn.company.Departments.Select(x => x.Employes.Where(y => y.Age > 21)).ToList());
            var res = damn.company.Departments[0].Employes.Where(y => y.Age > 22).ToList();

            //var res1 = damn.company.Departments.Select(x => x.Employes.Where(y => y.Age > 22)).ToList();

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }



        }

    }
}
