﻿using DSA_Homework1;
using DSA_Homework1.HomeworkClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Decimal:\t");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Binary code:\t" + (new Converter()).DecimalToBinary(num));


            Console.WriteLine("============================================");


            var searcher = new Searcher();
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
            Console.Write("Searching array:\t");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            int result = searcher.TernarySearch(array, 1, 0, array.Length);
            if (result != -1) { Console.WriteLine("Element Found at " + result); }
            else
            {
                Console.WriteLine("Element not found in the array.");
            }
        }
    }

}