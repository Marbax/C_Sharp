using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marshal
{
    class Point3D : Point2D
    {
        public int Z { get; set; }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public new void move(int dist) // new явно говорит что заменяет базовый метод
        {
            base.move(dist);
            Z += dist;
        }

        public override string ToString() // варианты редактирования строки базового класса 
                                          //( в данном случае обхода перехода на новую строку)
        {
            return base.ToString().Substring(0, base.ToString().Length - 1) + $" Z: {Z}";
            //return base.ToString().TrimEnd('\n') + $" Z: {Z}";
            //return base.ToString().Insert(base.ToString().Length - 1, $" Z: {Z}");
        }
    }
}
