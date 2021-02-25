using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1.Заполнить одномерный массив случайными числами. Сжать
            массив, удалив из него все 0 и заполнить освободившиеся
            справа элементы значениями -1.
            */
            Console.WriteLine("zipZeros");
            int[] arr=null;
            fillWithRand(out arr,20,0,11);
            printArr(arr);       
            zipZeros(arr);
            printArr(arr);
            /*=======================================================*/
            /*=========================_END_=========================*/

            /*
             2. Заполнить одномерные массив случайными числами.
             Преобразовать массив так, чтобы сначала шли отрицательные
             элементы, а потом положительные.
             */
            Console.WriteLine("sort");
            int[] arr1 = null;
            fillWithRand(out arr1, 20, -10, 11);
            printArr(arr1);
            Array.Sort(arr1);
            printArr(arr1);
            /*=======================================================*/
            /*=========================_END_=========================*/

            /*
            3.В двумерном массиве, размеры которого вводятся с
            клавиатуры, поменять местами заданные столбцы.
            */
            Console.WriteLine("replace Collums");
            Console.WriteLine("Enter rows count =>");
            int row = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter cols count =>");
            int col = Int32.Parse(Console.ReadLine());
            int[,] tdarr = new int[row, col];
            fillWithRand(tdarr,0,10);
            printArr(tdarr);
            Console.WriteLine("Enter indexes of cullums which you want replace ,separate by the Enter =>");
            replaceCollums(tdarr,Int32.Parse(Console.ReadLine()),Int32.Parse(Console.ReadLine()));
            printArr(tdarr);
            /*=======================================================*/
            /*=========================_END_=========================*/
        }

        /// <summary>
        /// Replacing torn array's collums positions
        /// </summary>
        /// <param name="first_col">Collumn to replace</param>
        /// <param name="second_col">Collumn to replace</param>
        static void replaceCollums(int[,]arr,int first_col,int second_col)
        {
            for (var i = 0; i < arr.GetLength(0); i++)
            {
                (arr[i, first_col], arr[i, second_col]) = (arr[i, second_col], arr[i, first_col]);
            }
        }

        static void printArr(int[,] arr)
        {
            for (var i = 0; i < arr.GetLength(0); i++)
            {
                for (var j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i,j] + " ");
                Console.WriteLine();
            }
        }

        static void printArr(int[]arr)
        {
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        /// <summary>
        /// Fill already initialized with size array with rando numbers
        /// </summary>
        /// <param name="arr">Mutable array</param>
        /// <param name="start_range">Feeling range min value</param>
        /// <param name="end_range">Feeling range max value</param>
        static void fillWithRand(int[,] arr, int start_range, int end_range)
        {
            Random rnd = new Random();

            for (var i = 0; i < arr.GetLength(0); i++)
            {
                for (var j = 0;j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rnd.Next(start_range, end_range);
                }
            }
        }

        /// <summary>
        /// Initialize and Fill array with random numbers range
        /// </summary>
        /// <param name="arr">Mutable array</param>
        /// <param name="size">Array size</param>
        /// <param name="start_range">Feeling range min value</param>
        /// <param name="end_range">Feeling range max value</param>
        static void fillWithRand(out int[] arr,int size,int start_range,int end_range)
        {
            arr = new int[size];
            Random rnd = new Random();

            for (var i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(start_range, end_range);
        }

        /// <summary>
        /// Find zeros into the array, remove them and for each add to the end "-1" with no array recreating
        /// </summary>
        static void zipZeros(int[]arr)
        {
            for (var i = 0; i < arr.Length; i++)
                while (arr[i] == 0)
                {
                    for (var j = i; j < arr.Length - 1; j++)
                        arr[j] = arr[j + 1];

                    arr[arr.Length - 1] = -1;
                }
        }

    }

}
