using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static collections.Test; // использовать статического методы  класса без обращения по имени класса 
using static System.Math;
using System.Diagnostics;

namespace collections
{

    class Point<T> where T : struct, IComparable
    {
        private T _x;
        private T _y;

        public T X { get => _x; set => _x = value; }
        public T Y { get => _y; set => _y = value; }

        public Point(T x, T y)
        {
            X = x;
            Y = y;
        }

        public Point()
        {
            X = default(T);
            Y = default(T);
        }

        static public void PrintHello()
        {
            Console.WriteLine("HELLO");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nX = {X} Y = {Y}";
        }
    }

    class Point3D : Point<int>
    {
        int _z;

        public Point3D(int x, int y, int z) : base(x, y)
        {
            _z = z;
        }

        public int Z { get => _z; set => _z = value; }



        public override string ToString()
        {
            return $"{base.ToString()} Z = {Z}";
        }
    }

    class Point3D<T> : Point<T> where T : struct, IComparable
    {
        T _z;
        public T Z { get => _z; set => _z = value; }

        public Point3D(T x, T y, T z) : base(x, y)
        {
            _z = z;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Z = {Z}";
        }
    }

    static class Test
    {
        public static T max<T>(T a, T b) where T : IComparable
        {
            return b.CompareTo(a) > 0 ? b : a;
        }
    }


    class MyCollection : IEnumerable
    {
        private List<int> _list;

        public MyCollection(List<int> list)
        {
            _list = list;
        }
        public MyCollection()
        {
            Random rnd = new Random();
            _list = new List<int>();
            for (int i = 0; i < 25; i++)
            {
                _list.Add(rnd.Next(12, 666));
            }
        }

        public void Print()
        {
            foreach (var item in _list)
            {
                Console.Write($"{item} ");
            }
        }

        /*
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_list).GetEnumerator();
        }
        */

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _list.Count; i++)
            {
                yield return _list[i]; // yield делает отдельный класс, делает обьект который запоминает состояние 
            }
        }
    }

    internal sealed class OperationTimer : IDisposable
    {
        long _startTime;
        string _text;
        int _collectionCount;
        public OperationTimer(string text)
        {
            PrepareForOperation();
            _text = text;
            _collectionCount = GC.CollectionCount(0);
            _startTime = Stopwatch.GetTimestamp();
        }
        public void Dispose()
        {
            Console.WriteLine($"{ _text}\t{(Stopwatch.GetTimestamp() - _startTime) / (double)Stopwatch.Frequency:0.00} секунды(сборок мусора { GC.CollectionCount(0) - _collectionCount})");
        }
        private static void PrepareForOperation()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var point_def = new Point<int>();
            Console.WriteLine(point_def);
            var point_int = new Point<double>(2u, 6u);
            Console.WriteLine(point_int);
            var point_double = new Point<double>(2.1d, 2.5d);
            Console.WriteLine(point_double);
            //var point_string = new Point<string>("2.1", "2.5");
            //Console.WriteLine(point_string);
            Point<decimal>.PrintHello();
            Console.WriteLine();

            var point3d = new Point3D(4, 6, 7);
            Console.WriteLine(point3d);
            var point3d_double = new Point3D<double>(3.3d, 5.5d, 7.7d);
            Console.WriteLine(point3d_double);



            Console.WriteLine();
            Console.WriteLine(max(16.5d, 22)); // Test
            Console.WriteLine(Max(22, 15)); // Math


            Console.WriteLine("My col");
            var my_Col = new MyCollection();
            my_Col.Print();
            Console.WriteLine();
            foreach (var item in my_Col)
            {
                Console.Write(item + " ");
            }


            Console.WriteLine("\nDiffernce between generics and ungenerics");
            long COUNT = 100000000;
            using (new OperationTimer("List"))
            {
                var list = new List<int>();
                for (var n = 0; n < COUNT; n++)
                {
                    list.Add(n);
                    var x = list[n];
                }
                list = null;
            }
            using (new OperationTimer("ArrayList"))
            {
                var array = new ArrayList();
                for (var n = 0; n < COUNT; n++)
                {
                    array.Add(n);
                    var x = (int)array[n];
                }
                array = null;
            }
        }
    }
}
