﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern05_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start.");

            var obj1 = Singleton.GetInstance();
            var obj2 = Singleton.GetInstance();

            if(obj1 == obj2)
            {
                Console.WriteLine("SAME!!");
            }

            Console.WriteLine("End.");
        }
    }
}
