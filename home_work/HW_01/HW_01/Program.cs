using System;

namespace HW_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sum of all equals to 3 or 5 is " + findEquals());
            Console.WriteLine("even fibanacci numers sum is " + evenFibanacciSum());
            Console.WriteLine("biggest prime divider is " + biggestPrimeDivider());
            Console.WriteLine("biggest pallindrome is "+ biggestMultPallindrome());
            Console.WriteLine("min divisible number is " + minDivisible());
        }

        static int findEquals(int number = 1000)
        {
            int sum=0;
            for (int i = 1; i < number; i++)
            {
                if (i%3==0 || i%5==0)
                {
                    sum += i;
                }
            }
            return sum;

        }

        static long evenFibanacciSum(int top_bound = 4000000)
        {
            long evens_sum=0;
            int first = 0, second=1,buf=0;

            while (first<=top_bound && second<=top_bound)
            {
                if (first%2==0)
                {
                    evens_sum += first;
                }
                buf = first;
                first += second;
                second = buf;
            }

            return evens_sum;
        }

        //---------------biggestPrimeDivider---------------------------------------
        static long biggestPrimeDivider(long number = 600851475143)//6857
        {
            long biggest = 0;

            for (long i = 1; i <= (long)Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    //Console.WriteLine(i + " " + number / i);
                    if (IsPrime(number/i))
                    {
                        return number / i;
                    }
                    if (IsPrime(i))
                    {
                        biggest = i;
                    }
                }
            }
            return biggest;
        }

        static bool IsPrime(long number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0)
                    return false;
                
            return true;

        }
        //-------------------END---------------------------------------------------

        //---------------biggestMultPallindrome---------------------------------------
        static uint biggestMultPallindrome(uint top_bound = 999)//906609
        {
            uint biggest=0;

            for (uint i=top_bound;  i > top_bound / 10; i--)
            {
                for (uint j = top_bound;  j > top_bound / 10; j--)
                {
                    if (isPallindrome(i * j))
                    {
                        //Console.WriteLine(i + "*" + j);
                        biggest = i * j >biggest?i*j:biggest;
                        break;
                    }

                }
            }
            return biggest;
        }
        static bool isPallindrome(long number)
        {
            char[] reverse_one = number.ToString().ToCharArray();
            Array.Reverse(reverse_one);
            string str1=new string(reverse_one);
            if (number.ToString()==str1)
            {
                return true;
            }

            return false;
        }
        //-------------------END---------------------------------------------------

        static ulong minDivisible(ulong top_bound=20)//232792560
        {
            
            for (var i = top_bound; ; i+=top_bound)
            {
                for (var j = top_bound; j >0; j--)
                {
                    if (i % j != 0)
                        break;
                    else if (j == 1)
                        return i;
                }
            }
        }

    }
}
