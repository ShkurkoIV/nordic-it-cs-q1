﻿using System;
using System.Threading;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine("Привет, {0}", name);
            Thread.Sleep(5000);
            Console.WriteLine("Пока, {0}", name);
            Console.ReadKey();
        }
    }
}
