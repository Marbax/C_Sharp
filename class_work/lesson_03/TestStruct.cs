using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_03
{
    public struct TestStruct
    {
        public int _data;
        private int _nedata=0;

        public int Data
        {
            get { return _data; }
            set { _data = value; }
        }



    }
}
