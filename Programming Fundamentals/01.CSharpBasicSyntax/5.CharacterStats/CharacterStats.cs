﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CharacterStats
{
    class CharacterStats
    {
        static void Main()
        {
            string name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maximumHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.Write($"Health: ");
            Console.Write(new string('|',(currentHealth+1)));
            Console.Write(new string('.', (maximumHealth - currentHealth)));
            Console.WriteLine("|");

            Console.Write($"Energy: ");
            Console.Write(new string('|', (currentEnergy + 1)));
            Console.Write(new string('.', (maximumEnergy - currentEnergy)));
            Console.WriteLine("|");
        }
    }
}
