using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fstream
{
    class Program
    {
        /*
         * В двух текстовых файлах содержатся фамилии студентов двух групп,
         * которые необходимо объединить вместе, отсортировать и сохранить в третьем файле.
         */

        public static void WriteFileStreamOver(string filePath, string data)
        {
            using (FileStream fs_write = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter sw_to = new StreamWriter(fs_write, Encoding.UTF8))
                {
                    sw_to.WriteLine(data);
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

        public static string SortNUniteInput(params string[] arr_input)
        {
            var output = string.Join("\n\r ", arr_input).Split("\n\r ".ToCharArray());
            Array.Sort(output);
            return output.Aggregate((x, y) => x + '\n' + y).Trim();
        }

        static void Main(string[] args)
        {
            WriteFileStreamOver(@"../../output.txt", SortNUniteInput(ReadFileStream(@"../../surnames1.txt"), ReadFileStream(@"../../surnames2.txt")));

            Console.WriteLine(ReadFileStream(@"../../output.txt"));
        }
    }
}
