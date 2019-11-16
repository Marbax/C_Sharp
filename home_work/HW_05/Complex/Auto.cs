using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto
{
    /*
     Реализовать класс auto - «Универсальная переменная».
     Объекты экземпляры этого класса способны хранить в себе значения следующих типов:
        int,
        double,
        string.


        Для класса auto необходимо перегрузить арифметические операторы: +, -, *, / и операторы сравнения: <, >, <=, >=, ==, !=. 
        В переменной типа auto в любой момент времени может храниться только одно значение (или int, или double, или string). 
        При перегрузке операторов учитывать следующее: 
            если в операции типы значений двух операндов типа auto разные, 
            то необходимо приводить (конвертировать) значение из второго операнда к типу значения первого операнда и 
            только после этого выполнять операцию. (При этом значение (и тип) второго операнда в самом объекте auto не меняется) 
        Например: 
            auto a = new auto(10), b = new auto(“120”), c;
            c = a + b;
            Console.WriteLine(c); // Выведет 130  c = b + a; Console.WriteLine(c); // Выведет “12010” 

        Для типа Строка операция * должна возвращать новую строку, состоящую только из символов первой строки, которые есть во второй строке, 
        например:
            auto a = new auto(“Microsoft”), b = new auto(“Windows”), c; c = a * b;
            Console.WriteLine(c); // Выведет “ioso” 

        Для типа Строка операция / должна возвращать новую строку, состоящую из символов первой строки, которых нет во второй строке, 
        например: 
            auto a = new auto(“Microsoft”), b = new auto(“Windows”), c; c = a / b;
            Console.WriteLine(c); // Выведет “Mcrft” 
 
        Добавить в класс auto преобразования к типам: int, double, string 
     */


    class auto
    {
        enum DataType
        {
            INT = 0,
            DOUBLE,
            STRING
        };

        //----------------------------------------------------------------------------------------
        //--------------------------------------_PROPERTIES_--------------------------------------
        //----------------------------------------------------------------------------------------

        DataType _data_type;

        int _int_val;
        double _double_val;
        string _string_val;


        //----------------------------------------------------------------------------------------
        //--------------------------------------_CONSTRUCTORS_------------------------------------
        //----------------------------------------------------------------------------------------

        public auto(int val)
        {
            _data_type = DataType.INT;
            _int_val = val;
        }

        public auto(double val)
        {
            _data_type = DataType.DOUBLE;
            _double_val = val;
        }

        public auto(string val)
        {
            _data_type = DataType.STRING;
            _string_val = val;
        }

        //----------------------------------------------------------------------------------------
        //----------------------------------_OVERRIDE_ARIFMET_OPERATORS_--------------------------
        //----------------------------------------------------------------------------------------

        public static auto operator +(auto obj_l, auto obj_r)
        {
            if (obj_l._data_type == DataType.INT)
                return new auto(obj_l._int_val + (int)obj_r);
            if (obj_l._data_type == DataType.DOUBLE)
                return new auto(obj_l._double_val + (double)obj_r);
            return new auto(obj_l._string_val + (string)obj_r);

        }

        public static auto operator -(auto obj_l, auto obj_r)
        {
            if (obj_l._data_type == DataType.INT)
                return new auto(obj_l._int_val - (int)obj_r);
            if (obj_l._data_type == DataType.DOUBLE)
                return new auto(obj_l._double_val - (double)obj_r);
            return new auto(obj_l._string_val.Replace(obj_l._string_val, (string)obj_r));
        }

        public static auto operator *(auto obj_l, auto obj_r)
        {
            if (obj_l._data_type == DataType.INT)
                return new auto(obj_l._int_val * (int)obj_r);
            if (obj_l._data_type == DataType.DOUBLE)
                return new auto(obj_l._double_val * (double)obj_r);

            StringBuilder tmp = new StringBuilder();
            foreach (var item in (string)obj_l)
            {
                if (obj_r.ToString().Contains(item))
                {
                    tmp.Append(item);
                }
            }
            return new auto(tmp.ToString());
        }

        public static auto operator /(auto obj_l, auto obj_r)
        {
            if (obj_l._data_type == DataType.INT)
                return new auto(obj_l._int_val / (int)obj_r);
            if (obj_l._data_type == DataType.DOUBLE)
                return new auto(obj_l._double_val / (double)obj_r);

            StringBuilder tmp = new StringBuilder();
            foreach (var item in (string)obj_l)
            {
                if (!obj_r.ToString().Contains(item))
                {
                    tmp.Append(item);
                }
            }
            return new auto(tmp.ToString());
        }

        //----------------------------------------------------------------------------------------
        //----------------------------------_OVERRIDE_LOGIC_OPERATORS_----------------------------
        //----------------------------------------------------------------------------------------

        public static bool operator ==(auto obj_l, auto obj_r)
        {
            if (obj_l._data_type == DataType.INT)
                return obj_l._int_val == (int)obj_r;
            if (obj_l._data_type == DataType.DOUBLE)
                return obj_l._double_val == (double)obj_r;
            return obj_l._string_val == (string)obj_r;
        }

        public static bool operator !=(auto obj_l, auto obj_r)
        {
            return !(obj_l == obj_r);
        }

        public static bool operator >(auto obj_l, auto obj_r)
        {
            if (obj_l._data_type == DataType.INT)
                return obj_l._int_val > (int)obj_r;
            if (obj_l._data_type == DataType.DOUBLE)
                return obj_l._double_val > (double)obj_r;
            return obj_l._string_val.Length > obj_r.ToString().Length;

        }

        public static bool operator <(auto obj_l, auto obj_r)
        {
            return !(obj_l > obj_r || obj_l == obj_r);
        }

        public static bool operator >=(auto obj_l, auto obj_r)
        {
            return obj_l > obj_r || obj_l == obj_r;
        }

        public static bool operator <=(auto obj_l, auto obj_r)
        {
            return !(obj_l > obj_r);
        }

        //-------------------------------------------------------------------------------------------
        //----------------------------------------_CONVERTING_---------------------------------------
        //-------------------------------------------------------------------------------------------

        public static explicit operator int(auto obj)
        {
            if (obj._data_type == DataType.DOUBLE)
                return (int)obj._double_val;
            if (obj._data_type == DataType.STRING)
            {
                int tmp;
                int.TryParse(obj._string_val, out tmp);
                return tmp;
            }
            return obj._int_val;
        }

        public static explicit operator double(auto obj)
        {
            if (obj._data_type == DataType.INT)
                return (double)obj._int_val;
            if (obj._data_type == DataType.STRING)
            {
                double tmp;
                double.TryParse(obj._string_val, out tmp);
                return tmp;
            }
            return obj._double_val;
        }

        public static explicit operator string(auto obj)
        {
            if (obj._data_type == DataType.INT)
                return obj._int_val.ToString();
            if (obj._data_type == DataType.DOUBLE)
                return obj._double_val.ToString();
            return obj._string_val;
        }

        //----------------------------------------------------------------------------------------
        //----------------------------------_OVERRIDE_METHODS_------------------------------------
        //----------------------------------------------------------------------------------------

        public override string ToString()
        {
            if (_data_type == DataType.INT)
                return _int_val.ToString();
            if (_data_type == DataType.DOUBLE)
                return _double_val.ToString();
            return _string_val;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj is auto auto_obj)
                return this == auto_obj;
            return false;
        }

        public override int GetHashCode()
        {
            if (_data_type == DataType.INT)
                return _int_val.GetHashCode() ^ _data_type.GetHashCode();
            if (_data_type == DataType.DOUBLE)
                return _double_val.GetHashCode() ^ _data_type.GetHashCode();
            return _string_val.GetHashCode() ^ _data_type.GetHashCode();
        }
    }
}
