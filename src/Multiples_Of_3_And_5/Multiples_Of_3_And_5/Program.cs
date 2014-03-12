using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiples_Of_3_And_5
{
    class Program
    {
        static long target = 1000000000;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("please input a value:");
                int maxValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(GetSum(maxValue));

                Console.WriteLine("use function");
                Console.WriteLine(SumDivisibleBy(3) + SumDivisibleBy(5) - SumDivisibleBy(15));
            }
        }

        static long GetSum(int maxValue)
        {
            long result = 0;
            for (int i = 3; i < maxValue; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            return result;
        }

        static long SumDivisibleBy(long n)
        {
            long p = target / n;

            return n * (p * (p + 1)) / 2;
        }
    }
}
