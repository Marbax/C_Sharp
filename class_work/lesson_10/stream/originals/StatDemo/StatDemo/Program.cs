using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StatDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 -> Считывание исходных данных
            string content;
            string path1 = @"..\..\input.txt";
            using (FileStream fs = new FileStream(path1, 
                FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    content = sr.ReadToEnd();
                }
            }
            Console.WriteLine(content);

            // 2 -> Формирование массива
            string[] parts = content.Split('\n');
            double[] data = new double[parts.Length];
            int i = 0;
            foreach (string p in parts)
            {
                data[i] = double.Parse(p);
                i++;
            }

            // 3 -> Обработка данных - нахождение среднего
            double s = 0;
            foreach (double x in data)
            {
                s += x;
            }
            double aver = s / data.Length;

            // 4 -> Создание массива погрешностей
            double[] err = new double[data.Length];
            double errSum = 0;
            for (int j = 0; j < data.Length; j++)
            {
                err[j] = Math.Abs(data[j] - aver);
                errSum += err[j];
            }
            double dev = errSum / data.Length;

            // 5 -> Запись результата в файл
            string path2 = @"..\..\output.txt";
            using (FileStream fs = new FileStream(path2, 
                FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (double x in data)
                    {
                        sw.Write($"{x} ");
                    }
                    sw.WriteLine($"\naver = {aver}");
                    sw.WriteLine($"dev = {dev}");
                }
            }

            // 6 -> Завершение рботы 
            Console.WriteLine("Результаты сохранены в output.txt");
            Console.WriteLine("\nПрограмма завершена");  
        }
    }
}
