﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_Numbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i =1; i<=n; i++)
            {
                var num = double.Parse(Console.ReadLine());

                sum = sum + num;
            }

            Console.WriteLine(sum);

        }
    }
}
