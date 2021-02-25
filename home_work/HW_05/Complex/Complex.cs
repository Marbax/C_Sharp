namespace auto
{

    namespace Complex
    {
        /*
         Реализовать класс для хранения комплексного числа. 
         Выполнить в нем перегрузку всех необходимых операторов для успешной компиляции следующего фрагмента кода:
            Complex z = new Complex(1,1); 
            Complex z1; z1 = z - (z * z * z - 1) / (3 * z * z); 
            Console.WriteLine($“z1 = {z1}”); 
         */



        class Complex
        {
            #region Props

            private decimal _realPart;

            public decimal RealPart
            {
                get { return _realPart; }
                set { _realPart = value; }
            }

            private decimal _imaginePart;

            public decimal ImaginaryPart
            {
                get { return _imaginePart; }
                set { _imaginePart = value; }
            }

            #endregion

            #region Ctors
            public Complex() : this(0, 0) { }
            public Complex(decimal realPart = 0, decimal imaginePart = 0)
            {
                _realPart = realPart;
                _imaginePart = imaginePart;
            }

            #endregion


            #region Operators Overrides
            public static Complex operator +(Complex left, Complex right)
            {
                return new Complex(left._realPart + right._realPart,
                    left._imaginePart + right._imaginePart);
            }

            public static Complex operator -(Complex left, Complex right)
            {
                return new Complex(left._realPart - right._realPart,
                    left._imaginePart - right._imaginePart);
            }

            // 7i^2 = -7
            public static Complex operator *(Complex left, Complex right)
            {
                return new Complex(left._realPart * right._realPart - left._imaginePart * right._imaginePart,
                    left._imaginePart * right._realPart + left._realPart * right._imaginePart);
            }

            public static Complex operator /(Complex left, Complex right)
            {
                return new Complex((left._realPart * right._realPart + left._imaginePart * right._imaginePart) / (right._realPart * right._realPart + right._imaginePart * right._imaginePart)
                    , (left._imaginePart * right._realPart - left._realPart * right._imaginePart) / (right._realPart * right._realPart + right._imaginePart * right._imaginePart));
            }

            public static bool operator ==(Complex left, Complex right)
            {
                return left._realPart == right._realPart && left._imaginePart == right._imaginePart;
            }

            public static bool operator !=(Complex left, Complex right)
            {
                return !(left == right);
            }

            #endregion

            //-------------------------------------------------------------------------------------------
            //----------------------------------------_CONVERTING_---------------------------------------
            //-------------------------------------------------------------------------------------------

            public static implicit operator Complex(int val) { return new Complex(val, 0); }

            //----------------------------------------------------------------------------------------
            //----------------------------------_OVERRIDE_METHODS_------------------------------------
            //----------------------------------------------------------------------------------------

            public override string ToString()
            {
                string output = $"{_realPart}";
                output += _imaginePart < 0 ? " - " : " + ";
                return output + _imaginePart;
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                if (obj is Complex complex)
                    return this == complex;
                return false;
            }

            public override int GetHashCode() { return _realPart.GetHashCode() ^ _imaginePart.GetHashCode(); }

        }
    }

}