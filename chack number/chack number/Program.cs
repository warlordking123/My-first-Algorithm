﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chack_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press a number");
            string str_input = Console.ReadLine();
            int a = int.Parse(str_input);
            if ((a >= 5) && (a <= 10))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
