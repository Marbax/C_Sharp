﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloads
{
    class MyNum
    {
        private int _num;

        public int Num
        {
            get { return _num; }
            set { _num = value; }
        }

        public MyNum() : this(0) { }
        public MyNum(int val) { _num = val; }

        public static MyNum operator *(Fraction obj, MyNum var) // не будет ясно какой метод вызывать т.к. у Fraction есть перегрузка умножения с такими же параметрами
        {
            return new MyNum(obj.Num * var.Num / obj.Denum);
        }
        public override string ToString() { return $"{_num}"; }

    }
}
