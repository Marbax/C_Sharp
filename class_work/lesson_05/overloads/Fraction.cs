using System;

namespace overloads
{
    class Fraction
    {
        #region Props

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

        #endregion


        #region Find Denum

        private static int Clm(int a, int b) // наименьшее кратное/знаменатель
        {
            int max = a > b ? a : b;
            for (int i = max; ; i += max)
                if (i % a == 0 && i % b == 0)
                    return i;
        }

        #endregion

        #region Multy Overlaod

        public static Fraction operator *(Fraction left, Fraction right)
        {
            return new Fraction(left.Num * right.Num, left.Denum * right.Denum);
        }

        public static Fraction operator *(Fraction frac, int number)
        {
            return new Fraction(frac.Num * number, frac.Denum);
        }

        public static Fraction operator *(int number, Fraction frac)
        {
            return frac * number;
        }

        public static Fraction operator *(Fraction frac, MyNum myNum) // у Нама есть такой же пергруз - не гуд
        {
            return new Fraction(frac.Num * myNum.Num, frac.Denum);
        }

        #endregion

        #region Sum Overload

        public static Fraction operator +(Fraction left, Fraction right)
        {
            int clm = Clm(left.Denum, right.Denum); // общий заменатель
            int num_l = left.Num * clm / left.Denum;
            int num_r = right.Num * clm / right.Denum;
            return new Fraction(num_l + num_r, clm);
        }

        public static Fraction operator +(Fraction left, int number)
        {
            return left + new Fraction(number, 1);
        }

        #endregion

        #region Increment Overload

        // перегружает и префиксную и постфиксную формы , "обмануть" как в плюсах - нельзя
        public static Fraction operator ++(Fraction frac)
        {
            frac.Num += frac.Denum;
            return frac;
        }

        #endregion

        #region Logic Overloads

        // возвращает себя с измененными числителем и знаминателем
        public static Fraction operator !(Fraction frac)
        {
            (frac.Num, frac.Denum) = (frac.Denum, frac.Num);
            return frac;
        }

        // нужно перегружать в паре с неравно
        public static bool operator ==(Fraction left, Fraction right)
        {
            // общий заменатель
            int clm = Clm(left.Denum, right.Denum);
            int num_l = left.Num * clm / left.Denum;
            int num_r = right.Num * clm / right.Denum;
            return num_l == num_r;
        }

        public static bool operator !=(Fraction left, Fraction right)
        {
            return !(left == right);
        }

        public static bool operator >(Fraction left, Fraction right)
        {
            // общий заменатель
            int clm = Clm(left.Denum, right.Denum);
            int num_l = left.Num * clm / left.Denum;
            int num_r = right.Num * clm / right.Denum;
            return num_l > num_r;
        }

        public static bool operator <(Fraction left, Fraction right)
        {
            return !(left > right || left == right);
        }

        public static bool operator >=(Fraction left, Fraction right)
        {
            return left > right || left == right;
        }

        public static bool operator <=(Fraction left, Fraction right)
        {
            return !(left > right);
        }

        public static bool operator true(Fraction obj)
        {
            return obj.Num != 0;
        }

        // долженн возвращать истину когда фолс
        public static bool operator false(Fraction obj)
        {
            return obj.Num == 0;
        }

        // чтобы работало -нужно перегрузить тру и фолс , т.к. преобразует в конце к тру или фолсу
        public static Fraction operator &(Fraction left, Fraction right)
        {
            return left.Num != 0 && right.Num != 0 ? left : new Fraction();
        }

        #endregion

        #region Converters

        public static implicit operator double(Fraction frac)
        {
            return (double)frac.Num / frac.Denum;
        }

        public static explicit operator Fraction(double val)
        {
            // после точки
            int tmp_num = (int)((val - (int)val) * 100);
            return new Fraction((int)val * 100 + tmp_num, 100);
        }

        #endregion

        #region Ctors

        public Fraction() : this(0, 1) { }
        public Fraction(int num, int denum)
        {
            _num = num;
            _denum = denum;
        }

        #endregion

        #region Object Overrides

        // тоже что и ==
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (Object.Equals(this, obj))
                return true;
            if (obj is Fraction fraction)
                return this == fraction;
            return false;
        }

        // не может быть, что у одного значения при разных вызовах - разные хеш коды
        public override int GetHashCode()
        {
            // ^ - наложение маски , данный пример не будет различать переврнутые дроби 
            //return Num.GetHashCode() ^ Denum.GetHashCode(); 

            return Num.GetHashCode() ^ Denum.GetHashCode() + Num / Denum;
        }

        public override string ToString() => $"{_num.ToString()}/{_denum.ToString()}";

        #endregion

    }
}
