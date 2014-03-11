using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiples_Of_3_And_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("please input a value:");
                int maxValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(GetSum(maxValue));
            }
        }

        static int GetSum(int maxValue)
        {
            int result = 0;
            for (int i = 3; i < maxValue; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            return result;
        }
    }
}
