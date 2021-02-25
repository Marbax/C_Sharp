using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Создать метод, принимающий введенную пользователем
            строку, и выводящий на экран статистику по этой строке.
            Статистика должна включать общее кол-во символов, кол-во
            пробелом, кол-во цифр, кол-во символов пунктуации, кол-во
            букв и кол-во пробелов.
            */
            Console.WriteLine("1.Enter String => ");
            string str = Console.ReadLine();
            stringStatistick(ref str);
            Console.WriteLine();

            /*
             2. Пользователь вводит строку и символ. В строке найти все
            вхождения этого символа и перевести его в верхний регистр, а
            также удалить часть строки, начиная с последнего вхождения
            этого символа и до конца.
            */
            Console.WriteLine("2.Enter String => ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter a character to find it in the string and delete everything after its last finding => ");
            //char chr = Char.Parse(Console.ReadLine());
            char chr = Console.ReadKey();
            charToUpperAndRemoveEnd(ref str1, ref chr);

            /*
             3. Удалить из строки повторяющиеся слова.
            */
            Console.WriteLine("3.Enter String => ");
            string str2 = Console.ReadLine();
            //string str2 = "play play not play with not game in";
            removeReplayedWords(ref str2);

            /*
             4. Преобразовать все слова по правилу: удалить из слова все
            последующие вхождения первого символа.
            */
            Console.WriteLine("4.Enter String => ");
            string str3 = Console.ReadLine();
            //string str3 = "mammba karamkba trultttulu lalala";
            removeReplayedChars(ref str3);


            /*
             5. Преобразовать все слова по правилу: удалить в слове только
            последние вхождения каждого символа.
            */
            Console.WriteLine("5.Enter String => ");
            string str4 = Console.ReadLine();
            //string str4 = "mammba. karamkba, trultttulu lalala";
            removeLastCharOccurrence(ref str4);

        }


        static void stringStatistick(ref string str)
        {
            int spaces = 0, digits = 0, punctuations = 0, letters = 0, lettersAndSpaces = 0;
            char[] buf = str.ToCharArray();
            char[] digits_arr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] punctuations_arr = new char[] { ',', '.', '\'', '\"', '\\','/',':',';','_','{','}',
                '?','!','(',')','{','}','[',']','*'};
            foreach (var sym in buf)
            {
                if (sym == ' ')
                {
                    spaces++;
                }
                else if (digits_arr.Contains(sym))
                {
                    digits++;
                }
                else if (punctuations_arr.Contains(sym))
                {
                    punctuations++;
                }
            }
            lettersAndSpaces = str.Count() - digits - punctuations;
            letters = lettersAndSpaces - spaces;
            Console.WriteLine($"symbols in string {str.Count()}\nspaces {spaces}");
            Console.WriteLine($"digits {digits}\npunctuations {punctuations}\nletters {letters}\nletters and spaces {lettersAndSpaces} ");

        }

        static List<int> charToUpperAndRemoveEnd(ref string str, ref char chr)
        {
            StringBuilder buf_str = new StringBuilder("");
            int counter = 0;
            List<int> positions = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == chr)
                {
                    positions.Add(i);
                    counter++;
                    buf_str.Append(Char.ToUpper(chr)); ;
                }
                else
                    buf_str.Append(str[i]);
            }
            str = buf_str.ToString();
            if (counter > 1)
            {
                str = str.Remove(positions.Last());
            }
            Console.WriteLine($"Edited string => \n{str}\nPositions of a {chr} in the primal string =>");
            foreach (var i in positions)
                Console.Write(i + " ");

            Console.WriteLine();
            return positions;
        }

        static void removeReplayedWords(ref string str)
        {
            string[] str_arr = str.Split(",. :/?!;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            StringBuilder buf_str = new StringBuilder("");
            for (int i = 0; i < str_arr.Length; i++)
            {

                if (!buf_str.ToString().Contains(str_arr[i]))
                    buf_str.Append(str_arr[i]);
                if (i < str_arr.Length - 1)
                    buf_str.Append(' ');

            }
            str = buf_str.ToString();
            Console.WriteLine(str);

        }

        static void removeReplayedChars(ref string str)
        {
            string[] str_arr = str.Split(",. :/?!;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            StringBuilder buf_str = new StringBuilder("");
            StringBuilder str_concat = new StringBuilder("");
            for (int i = 0; i < str_arr.Length; i++)
            {
                buf_str.Append(str_arr[i][0]);
                for (int j = 1; j < str_arr[i].Length; j++)
                {
                    if (str_arr[i][j] != (str_arr[i][0]))
                        buf_str.Append(str_arr[i][j]);
                }

                if (i < str_arr.Length - 1)
                    buf_str.Append(' ');

                str_concat.Append(buf_str);
                buf_str.Clear();

            }

            str = str_concat.ToString();
            Console.WriteLine(str);

        }

        static void removeLastCharOccurrence(ref string str)
        {
            string[] str_arr = str.Split(",. :/?!;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            StringBuilder buf_str = new StringBuilder("");
            StringBuilder str_concat = new StringBuilder("");
            for (int i = 0; i < str_arr.Length; i++)
            {
                for (int j = 0; j < str_arr[i].Length; j++)
                {
                    int counter_next = 0;
                    for (int k = j+1; k < str_arr[i].Length; k++)
                    {
                        if (str_arr[i][j] == str_arr[i][k])
                            counter_next++;
                    }

                    int counter_prev = 0;
                    for (int k = j-1; k >= 0; k--)
                    {
                        if (str_arr[i][j] == str_arr[i][k])
                            counter_prev++;
                    }

                    if (counter_prev > 0 && counter_next == 0)
                    {
                        continue;
                    }
                    else
                        buf_str.Append(str_arr[i][j]);

                }

                if (i < str_arr.Length - 1)
                    buf_str.Append(' ');

                str_concat.Append(buf_str);
                buf_str.Clear();

            }
            str = str_concat.ToString();
            Console.WriteLine(str);

        }
    }
}
