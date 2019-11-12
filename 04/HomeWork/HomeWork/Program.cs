using System;

namespace HomeWork
{
    class Program
    {
        enum Months : int
        {
            Jan = 1,
            Feb = 2,
            Mar = 3,
            Apr = 4,
            May = 5,
            Ju  = 6,
            Jul = 7,
            Aug = 8,
            Sep = 9,
            Oct = 10,
            Nov = 11,
            Dec = 12
        };
        enum Seasons : int
        {
            winter,
            spring,
            summer,
            autumn
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            int monthNumber = int.Parse(Console.ReadLine());
            if (monthNumber > 0 | monthNumber <= 12)
            {
                int quarter = (int) (Math.Ceiling((decimal) (monthNumber) * 4 / 12));
                int season = (monthNumber / 3) % 4;
                Console.WriteLine($"Месяц - {(Months) monthNumber}");
                Console.WriteLine($"{quarter}-я четверть года");
                Console.WriteLine($"Сезон - {(Seasons) season}");
            }
            else
            {
                Console.WriteLine("Месяца с таким номером нет");
            }
            Console.ReadKey();


        }
    }
}
