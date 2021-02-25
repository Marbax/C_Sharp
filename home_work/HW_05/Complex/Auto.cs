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
            Console.WriteLine(c); // Выведет 130  
            c = b + a; 
            Console.WriteLine(c); // Выведет “12010” 

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



        #region Props
        DataType _data_type;

        int _intVal;
        double _doubleVal;
        string _stringVal;

        #endregion



        #region Ctors
        public auto(int val)
        {
            _data_type = DataType.INT;
            _intVal = val;
        }

        public auto(double val)
        {
            _data_type = DataType.DOUBLE;
            _doubleVal = val;
        }

        public auto(string val)
        {
            _data_type = DataType.STRING;
            _stringVal = val;
        }

        #endregion



        #region Arithmetic Opetaions Overrides
        public static auto operator +(auto left, auto right)
        {
            if (left._data_type == DataType.INT)
                return new auto(left._intVal + (int)right);
            if (left._data_type == DataType.DOUBLE)
                return new auto(left._doubleVal + (double)right);
            return new auto(left._stringVal + (string)right);

        }

        public static auto operator -(auto left, auto right)
        {
            if (left._data_type == DataType.INT)
                return new auto(left._intVal - (int)right);
            if (left._data_type == DataType.DOUBLE)
                return new auto(left._doubleVal - (double)right);
            return new auto(left._stringVal.Replace(left._stringVal, (string)right));
        }

        public static auto operator *(auto left, auto right)
        {
            if (left._data_type == DataType.INT)
                return new auto(left._intVal * (int)right);
            if (left._data_type == DataType.DOUBLE)
                return new auto(left._doubleVal * (double)right);

            StringBuilder tmp = new StringBuilder();
            foreach (var item in (string)left)
            {
                if (right.ToString().Contains(item))
                {
                    tmp.Append(item);
                }
            }
            return new auto(tmp.ToString());
        }

        public static auto operator /(auto left, auto right)
        {
            if (left._data_type == DataType.INT)
                return new auto(left._intVal / (int)right);
            if (left._data_type == DataType.DOUBLE)
                return new auto(left._doubleVal / (double)right);

            StringBuilder tmp = new StringBuilder();
            foreach (var item in (string)left)
            {
                if (!right.ToString().Contains(item))
                {
                    tmp.Append(item);
                }
            }
            return new auto(tmp.ToString());
        }

        #endregion



        #region Logic Operations Ovverides
        public static bool operator ==(auto left, auto right)
        {
            if (left._data_type == DataType.INT)
                return left._intVal == (int)right;
            if (left._data_type == DataType.DOUBLE)
                return left._doubleVal == (double)right;
            return left._stringVal == (string)right;
        }

        public static bool operator !=(auto left, auto right)
        {
            return !(left == right);
        }

        public static bool operator >(auto left, auto right)
        {
            if (left._data_type == DataType.INT)
                return left._intVal > (int)right;
            if (left._data_type == DataType.DOUBLE)
                return left._doubleVal > (double)right;
            return left._stringVal.Length > right.ToString().Length;

        }

        public static bool operator <(auto left, auto right)
        {
            return !(left > right || left == right);
        }

        public static bool operator >=(auto left, auto right)
        {
            return left > right || left == right;
        }

        public static bool operator <=(auto left, auto right)
        {
            return !(left > right);
        }

        #endregion



        #region Converters
        public static explicit operator int(auto obj)
        {
            if (obj._data_type == DataType.DOUBLE)
                return (int)obj._doubleVal;
            if (obj._data_type == DataType.STRING)
            {
                int tmp;
                int.TryParse(obj._stringVal, out tmp);
                return tmp;
            }
            return obj._intVal;
        }

        public static explicit operator double(auto obj)
        {
            if (obj._data_type == DataType.INT)
                return (double)obj._intVal;
            if (obj._data_type == DataType.STRING)
            {
                double tmp;
                double.TryParse(obj._stringVal, out tmp);
                return tmp;
            }
            return obj._doubleVal;
        }

        public static explicit operator string(auto obj)
        {
            if (obj._data_type == DataType.INT)
                return obj._intVal.ToString();
            if (obj._data_type == DataType.DOUBLE)
                return obj._doubleVal.ToString();
            return obj._stringVal;
        }

        #endregion



        #region Object Overrides

        public override string ToString()
        {
            if (_data_type == DataType.INT)
                return _intVal.ToString();
            if (_data_type == DataType.DOUBLE)
                return _doubleVal.ToString();
            return _stringVal;
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
                return _intVal.GetHashCode() ^ _data_type.GetHashCode();
            if (_data_type == DataType.DOUBLE)
                return _doubleVal.GetHashCode() ^ _data_type.GetHashCode();
            return _stringVal.GetHashCode() ^ _data_type.GetHashCode();
        }

        #endregion
    }
}
