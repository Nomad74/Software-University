﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_in_Range
{
    class NumberInRange
    {
        static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range[1...100]:");
            var n = int.Parse(Console.ReadLine());
            
            while(n<1 || n>100)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Еnter a number in the range[1...100]:");
                n = int.Parse(Console.ReadLine());
            }
         Console.WriteLine($"The number is: {n}");
        }
    }
}
