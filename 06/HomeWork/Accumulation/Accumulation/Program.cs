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
            double contribution;
            double income;
            double accumulation;
            try
            {
                Console.WriteLine("Введите сумму первоначального взноса в рублях");
                contribution = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите ежедневный процент дохода в виде десятичной дроби");
                income = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите желаемую сумму накопления в рублях");
                accumulation = Double.Parse(Console.ReadLine());
                if (contribution <= 0 || income <= 0 || accumulation <= 0 || (accumulation < contribution))
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода. Попробуйте еще раз \n");
                goto Start;
            }
            double amountPerDay = contribution;
            int days;
            for (days = 0; amountPerDay < accumulation; days++)
            {
                amountPerDay += amountPerDay * income;
            }
            Console.WriteLine($"Необходимое количество дней для накопления желаемой суммы: {days}.");
        }
    }
}