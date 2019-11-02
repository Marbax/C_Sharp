using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        /*
        1. Придумать класс, описывающий студента и предусмотреть в
           нем следующие поля: имя, фамилия, отчество, группа,
            возраст, массив(рваный) оценок по программированию,
            администрированию и дизайну.Также добавить методы по
            работе с перечисленными данными: возможность установки/
            получения оценки, получение среднего балла по данному
            предмету, распечатка данных о студенте.
            */
        static void Main(string[] args)
        {
            Student Petro = new Student();
            Console.WriteLine(Petro);

            Petro.Group = "p1_c2";
            Petro.Name = "Petro";
            Petro.Surname = "Petruschenko";
            Petro.MiddleName = "Petrov";
            Petro.Age = 44;
            Petro.addProgramming(7);
            Petro.addProgramming(5);
            Petro.addAdministrating(12);
            Petro.addAdministrating(11);
            Petro.addAdministrating(7);
            Petro.setAdministrating(0, 11);
            Petro.addDesign(4);
            Petro.addDesign(8);
            Petro.addDesign(5);
            Console.WriteLine(Petro);

            /*
            2.Написать статический класс, который предоставляет
            статические методы для:
            -расчета экспоненциальной функции;
            -нахождения арксинуса заданного аргумента;
            -нахождения расстояния между двумя точками в трехмерном пространстве;
            -транспонирования матрицы.
            */
            Console.WriteLine(MathmeticFoos.expFoo(12));
            Console.WriteLine(MathmeticFoos.arcSinFoo(0.30));
            Console.WriteLine(MathmeticFoos.rangeTwoPoints3D(0, 0, 0, 3, 3, 3));
            Console.WriteLine();
            int[,] matrix = MathmeticFoos.fillTheMatrixNeo(out matrix, rows: 4, cols: 8);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            matrix = MathmeticFoos.matrixTranspose(matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
