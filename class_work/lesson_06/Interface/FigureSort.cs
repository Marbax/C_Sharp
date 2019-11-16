using System;
using System.Collections;
using System.Text;

namespace Interface
{
    class FigureSort : IComparable
    {
        public string Type { get; set; }

        private double[] _sides;

        public double this[int index] { get => _sides[index]; set => _sides[index] = value; }

        public FigureSort(string type, params double[] sides)
        {
            Type = type;
            _sides = sides;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"Type = {Type}\nSides: ");
            foreach (var item in _sides)
            {
                sb.Append($"{item} ,");
            }
            return sb.ToString().Substring(0, sb.Length - 1);
        }

        public int CompareTo(object obj)
        {
            return _sides.Length.CompareTo(((FigureSort)obj)._sides.Length);
        }
    }


    class Canvas : IEnumerable // нужно using System.Collections;
    {
        Random _rnd = new Random();
        FigureSort[] _arr;
        public int Length => _arr.Length;

        public FigureSort this[int index] { get => _arr[index]; set => _arr[index] = value; }

        public Canvas(int size)
        {
            _arr = new FigureSort[size];

            for (int i = 0; i < _arr.Length; i++)
            {
                switch (_rnd.Next(4))
                {
                    case 0:
                        _arr[i] = new FigureSort("Triangle",
                            _rnd.Next(10),
                            _rnd.Next(10),
                            _rnd.Next(10));
                        break;
                    case 1:
                        _arr[i] = new FigureSort("Rectangle",
                            _rnd.Next(10),
                            _rnd.Next(10),
                            _rnd.Next(10),
                            _rnd.Next(10));
                        break;
                    case 2:
                        _arr[i] = new FigureSort("Pentagon",
                            _rnd.Next(10),
                            _rnd.Next(10),
                            _rnd.Next(10),
                            _rnd.Next(10),
                            _rnd.Next(10));
                        break;
                    case 3:
                        _arr[i] = new FigureSort("Hexagon",
                            _rnd.Next(10),
                            _rnd.Next(10),
                            _rnd.Next(10),
                            _rnd.Next(10),
                            _rnd.Next(10),
                            _rnd.Next(10));
                        break;
                }
            }
        }

        public void Sort() { Array.Sort(_arr); }

        public IEnumerator GetEnumerator() { return _arr.GetEnumerator(); }

    }
}
