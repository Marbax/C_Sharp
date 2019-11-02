using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marshal
{
    partial class Rectangle
    {
        public override string ToString()
        {
            return $"Height: {Height}\nWidth: {Width}";
        }

        public int Perimetr => (Width + Height) * 2;

    }


    partial class Rectangle
    {
        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private int _width;

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

    }
}
