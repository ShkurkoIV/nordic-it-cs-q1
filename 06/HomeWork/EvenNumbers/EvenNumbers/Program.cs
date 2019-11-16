using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        delegate bool IsEven(int i);
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("Введите натуральное число");
            bool error;
            uint number;
            List<int> result = EvenNumbers(Console.ReadLine(), i => i % 2 == 0 & i != 0, out error, out number);
            if (error)
            {
                Console.WriteLine("Введено неверное значение! Попробуйте ещё раз: \n");
                goto Start;
            }
            Console.WriteLine($"В числе {number} содержится следующее количество четных цифр: {result.Count}");
            Console.ReadKey();
        }
        private static List<int> EvenNumbers(string input, IsEven func, out bool error, out uint number)
        {
            List<int> result = new List<int>();
            error = !uint.TryParse(input, out number) || number == 0;
            if (error)
            {
                return result;
            }
            foreach (var item in input.ToCharArray())
            {
                var i = (int)Char.GetNumericValue(item);
                if (func(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}