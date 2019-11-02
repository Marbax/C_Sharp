using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    static class MathmeticFoos
    {
        static public double expFoo(double d)
        {
            return Math.Exp(d);

        }
        static public double arcSinFoo(double d)
        {
            return Math.Asin(d);

        }

        static public double rangeTwoPoints3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        }

        static public int[,] matrixTranspose(int[,] matrix)
        {
            int[,] trans = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < trans.GetLength(0); i++)
                for (int j = 0; j < trans.GetLength(1); j++)
                    trans[i, j] = matrix[j, i];
            return trans;
        }

        static public int[,] fillTheMatrixNeo(out int[,] matrix,int rows,int cols)
        {
            Random rnd = new Random();
            matrix = new int[rows, cols];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(10,100);
            return matrix;
        }



    }
}
