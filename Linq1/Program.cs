﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //OddNumbers(numbers);
            WholeNumbers(numbers);
            Console.ReadKey();
        }

        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd numbers: ");

            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

            Console.WriteLine(oddNumbers);

            foreach(int i in oddNumbers)
            {
                Console.WriteLine(i);
            }
        }

        static void WholeNumbers(int[] numbers)
        {
            Console.WriteLine("Whole numbers: ");

            IEnumerable<int> wholeNumbers = from number in numbers where number % 2 == 0 select number;

            Console.WriteLine(wholeNumbers);

            foreach(int i in wholeNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
