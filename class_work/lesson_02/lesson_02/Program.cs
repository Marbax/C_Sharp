using System;
using System.Collections.Generic;
using System.Linq; // много полезных ф-й (напр посчитать сумму эллементов массива)
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_02
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            int[] arr = new int [10];
            Random rnd = new Random(); // рандом
            for(var i=0;i<arr.Length;i++)
            {
                arr[i] = rnd.Next(15,32); // рандом от 15-31
            }

            foreach(var item in arr)
            {
                Console.WriteLine(item + " ");
            }
            */

            /*
            Random rnd = new Random(); // рандом
            Console.WriteLine("Enter size : ");
            int row = Int32.Parse(Console.ReadLine());
            int[][] arr = new int[row][]; // массив ссылок на интовые массивы

            for (var i = 0; i < arr.Length; i++) // 12 массивов , каждый
            {
                arr[i] = new int[rnd.Next(3, 15)]; // рваный массив от 3-14 размера

                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rnd.Next(20, 25);
                }
            }

            //for (var i=0; i<arr.GetLength(0);i++)
            Array.Sort(arr, compareArray);

            foreach (var line in arr)
            {
                foreach (var j in line)
                {
                    Console.Write(j + " " );
                }
            }

            Console.WriteLine("\n\n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].GetLength(0); j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n\n" +arr[0].Average() + " " + arr[0].Sum());

            int a=1, b=2, c=3;
            (a, b, c) = (c, a, b);
            Console.WriteLine(a+" "+ b+" " +c);
            */

            /*
            string str = new string(new char[] {'h','e','l','l'});
            string str1 = "Hell";

            Console.WriteLine("HEllo".Insert(2," not "));
            Console.WriteLine("hello".Remove(0, 1));
            Console.WriteLine("hello".Replace("el", "il"));

            Console.WriteLine("\n\n\n" );
            string[] arr = "hello my,friend: and bye".Split(",. :/".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            foreach(var item in arr)
            Console.WriteLine(item);

            Console.WriteLine("helolalalo".Substring(1,3));

            Console.WriteLine("\n\n");
            Console.WriteLine("   . .    trimmer    / /..   ".Trim('.',',',' ','/'));

            Console.WriteLine("hello".CompareTo("Hello"));

            Console.WriteLine("hello".EndsWith("ol"));

            Console.WriteLine("hello".IndexOf("ll"));

            Console.WriteLine("hello".PadLeft(6,'_'));

            Console.WriteLine("today {0} {1} {2}", 19, "october", 2019);
            Console.WriteLine($"today {19} {"October"} {2019}");

            double a = 2.55;
            Console.WriteLine($"{a:0}");


            Console.WriteLine(@"C:\program\
            appdata");
            */

            /*
            StringBuilder sb = new StringBuilder("");

            string id = "";
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                if (i < 5 || i > 10)
                    sb.Append(rnd.Next(5));
                else
                    sb.Append(rnd.Next((char)rnd.Next(65, 93)));
            }
            id = sb.ToString();
            Console.WriteLine(id);
            */


            Gender gender = Gender.Male;
            Console.WriteLine(gender);

            string[]names=Enum.GetNames(typeof(Gender));
            Console.WriteLine(Enum.GetNames(typeof(Gender)));
            foreach(var name in names)
                Console.WriteLine(name);

            foreach (int key in Enum.GetValues(typeof(Keys)))
                Console.WriteLine($"{key}->{Enum.GetName(typeof(Keys),key)}");


        }

        enum Gender:long
        {
            Male,
            Female,
            Unknown
        }
        public static int compareArray(int []a , int []b)
        {
            return a.Length - b.Length;
        }
    }
}
