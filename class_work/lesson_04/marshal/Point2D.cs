using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marshal
{
    public class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point2D(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        public virtual void move(int dist)
        {
            X += dist;
            Y += dist;
        }

        public override string ToString()
        {
            return $"X: {X} Y: {Y} \n";
        }
    }
}
