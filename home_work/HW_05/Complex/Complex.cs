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
            //----------------------------------------------------------------------------------------
            //--------------------------------------_PROPERTIES_--------------------------------------
            //----------------------------------------------------------------------------------------

            private decimal _real_part;

            public decimal RealPart
            {
                get { return _real_part; }
                set { _real_part = value; }
            }

            private decimal _imag_part;

            public decimal ImaginaryPart
            {
                get { return _imag_part; }
                set { _imag_part = value; }
            }

            //----------------------------------------------------------------------------------------
            //--------------------------------------_CONSTRUCTORS_------------------------------------
            //----------------------------------------------------------------------------------------

            public Complex() : this(0, 0) { }
            public Complex(decimal real_part = 0, decimal imag_part = 0)
            {
                _real_part = real_part;
                _imag_part = imag_part;
            }

            //----------------------------------------------------------------------------------------
            //----------------------------------_OVERRIDE_OPERATORS_----------------------------------
            //----------------------------------------------------------------------------------------

            public static Complex operator +(Complex obj_l, Complex obj_r)
            {
                return new Complex(obj_l._real_part + obj_r._real_part,
                    obj_l._imag_part + obj_r._imag_part);
            }

            public static Complex operator -(Complex obj_l, Complex obj_r)
            {
                return new Complex(obj_l._real_part - obj_r._real_part,
                    obj_l._imag_part - obj_r._imag_part);
            }

            public static Complex operator *(Complex obj_l, Complex obj_r) // 7i^2 = -7
            {
                return new Complex(obj_l._real_part * obj_r._real_part - obj_l._imag_part * obj_r._imag_part,
                    obj_l._imag_part * obj_r._real_part + obj_l._real_part * obj_r._imag_part);
            }

            public static Complex operator /(Complex obj_l, Complex obj_r)
            {
                return new Complex((obj_l._real_part * obj_r._real_part + obj_l._imag_part * obj_r._imag_part) / (obj_r._real_part * obj_r._real_part + obj_r._imag_part * obj_r._imag_part)
                    , (obj_l._imag_part * obj_r._real_part - obj_l._real_part * obj_r._imag_part) / (obj_r._real_part * obj_r._real_part + obj_r._imag_part * obj_r._imag_part));
            }

            public static bool operator ==(Complex obj_l, Complex obj_r)
            {
                return obj_l._real_part == obj_r._real_part && obj_l._imag_part == obj_r._imag_part;
            }

            public static bool operator !=(Complex obj_l, Complex obj_r)
            {
                return !(obj_l == obj_r);
            }

            //-------------------------------------------------------------------------------------------
            //----------------------------------------_CONVERTING_---------------------------------------
            //-------------------------------------------------------------------------------------------

            public static implicit operator Complex(int val) { return new Complex(val, 0); }

            //----------------------------------------------------------------------------------------
            //----------------------------------_OVERRIDE_METHODS_------------------------------------
            //----------------------------------------------------------------------------------------

            public override string ToString()
            {
                string output = $"{_real_part}";
                output += _imag_part < 0 ? " - " : " + ";
                return output + _imag_part;
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                if (obj is Complex complex)
                    return this == complex;
                return false;
            }

            public override int GetHashCode() { return _real_part.GetHashCode() ^ _imag_part.GetHashCode(); }

        }
    }

}