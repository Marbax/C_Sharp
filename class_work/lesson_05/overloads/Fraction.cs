using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloads
{
    class Fraction
    {
        private int _num;

        public int Num
        {
            get { return _num; }
            set { _num = value; }
        }

        private int _denum;

        public int Denum
        {
            get { return _denum; }
            set { _denum = value; }
        }

        //------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------FIND_DENUM----------------------------------------
        //------------------------------------------------------------------------------------------------------------------------

        private static int Clm(int a, int b) // наименьшее кратное/знаменатель
        {
            int max = a > b ? a : b;
            for (int i = max; ; i += max)
                if (i % a == 0 && i % b == 0)
                    return i;
        }

        //------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------MULTY----------------------------------------
        //------------------------------------------------------------------------------------------------------------------------

        public static Fraction operator *(Fraction obj_l, Fraction obj_r)
        {
            return new Fraction(obj_l.Num * obj_r.Num, obj_l.Denum * obj_r.Denum);
        }

        public static Fraction operator *(Fraction obj, int var)
        {
            return new Fraction(obj.Num * var, obj.Denum);
        }

        public static Fraction operator *(int var, Fraction obj)
        {
            return obj * var;
        }

        public static Fraction operator *(Fraction obj, MyNum var) // у Нама есть такой же пергруз - не гуд
        {
            return new Fraction(obj.Num * var.Num, obj.Denum);
        }

        //------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------SUM----------------------------------------
        //------------------------------------------------------------------------------------------------------------------------

        public static Fraction operator +(Fraction obj_l, Fraction obj_r)
        {
            int clm = Clm(obj_l.Denum, obj_r.Denum); // общий заменатель
            int num_l = obj_l.Num * clm / obj_l.Denum;
            int num_r = obj_r.Num * clm / obj_r.Denum;
            return new Fraction(num_l + num_r, clm);
        }

        public static Fraction operator +(Fraction obj_l, int var)
        {
            return obj_l + new Fraction(var, 1);
        }

        //------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------INCREMENT----------------------------------------
        //------------------------------------------------------------------------------------------------------------------------

        public static Fraction operator ++(Fraction obj)// перегружает и префиксную и постфиксную формы , "обмануть" как в плюсах - нельзя
        {
            obj.Num += obj.Denum;
            return obj;
        }

        //------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------LOGIC_OPERATORS----------------------------------------
        //------------------------------------------------------------------------------------------------------------------------

        public static Fraction operator !(Fraction obj) // возвращает себя с измененными числителем и знаминателем
        {
            (obj.Num, obj.Denum) = (obj.Denum, obj.Num);
            return obj;
        }

        public static bool operator ==(Fraction obj_l, Fraction obj_r) // нужно перегружать в паре с неравно
        {
            int clm = Clm(obj_l.Denum, obj_r.Denum); // общий заменатель
            int num_l = obj_l.Num * clm / obj_l.Denum;
            int num_r = obj_r.Num * clm / obj_r.Denum;
            return num_l == num_r;
        }

        public static bool operator !=(Fraction obj_l, Fraction obj_r)
        {
            return !(obj_l == obj_r);
        }

        public static bool operator >(Fraction obj_l, Fraction obj_r)
        {
            int clm = Clm(obj_l.Denum, obj_r.Denum); // общий заменатель
            int num_l = obj_l.Num * clm / obj_l.Denum;
            int num_r = obj_r.Num * clm / obj_r.Denum;
            return num_l > num_r;
        }

        public static bool operator <(Fraction obj_l, Fraction obj_r)
        {
            return !(obj_l > obj_r || obj_l == obj_r);
        }

        public static bool operator >=(Fraction obj_l, Fraction obj_r)
        {
            return obj_l > obj_r || obj_l == obj_r;
        }

        public static bool operator <=(Fraction obj_l, Fraction obj_r)
        {
            return !(obj_l > obj_r);
        }

        public static bool operator true(Fraction obj)
        {
            return obj.Num != 0;
        }

        public static bool operator false(Fraction obj) // долженн возвращать истину когда фолс
        {
            return obj.Num == 0;
        }

        public static Fraction operator &(Fraction obj_l, Fraction obj_r) // чтобы работало -нужно перегрузить тру и фолс , т.к. преобразует в конце к тру или фолсу
        {
            return obj_l.Num != 0 && obj_r.Num != 0 ? obj_l : new Fraction();
        }

        //------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------CONVERTING----------------------------------------
        //------------------------------------------------------------------------------------------------------------------------


        /*//NOT GOOD
        public static implicit operator double(Fraction obj)
        {
            return (double)obj.Num / obj.Denum;
        }
        */

        public static explicit operator double(Fraction obj)
        {
            return (double)obj.Num / obj.Denum;
        }

        public static explicit operator Fraction(double val)
        {
            int tmp_num = (int)((val - (int)val) * 100);
            return new Fraction((int)val * 100+tmp_num, 100);
        }

        //------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------CONSTRUCTORS----------------------------------------
        //------------------------------------------------------------------------------------------------------------------------

        public Fraction() : this(0, 1) { }
        public Fraction(int num, int denum)
        {
            _num = num;
            _denum = denum;
        }

        //------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------OVERRIDES----------------------------------------
        //------------------------------------------------------------------------------------------------------------------------

        public override bool Equals(object obj)// тоже что и ==
        {
            if (obj == null)
                return false;
            if (obj is Fraction fraction)
                return this == fraction;
            return false;
        }

        public override int GetHashCode() // не может что у одного значения при разных вызовах - разные хеш коды
        {
            //return Num.GetHashCode() ^ Denum.GetHashCode(); // ^ - наложение маски , данный пример не будет различать переврнутые дроби 

            return Num.GetHashCode() ^ Denum.GetHashCode() + Num / Denum;
        }

        public override string ToString()
        {
            return $"{_num}/{_denum}";
        }
    }
}
