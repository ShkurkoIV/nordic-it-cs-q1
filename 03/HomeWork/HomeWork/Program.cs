using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[,] tab;
            uint columns;
            uint rows;
            Console.WriteLine("Введите число колонок");
            uint.TryParse(Console.ReadLine(), out columns);
            Console.WriteLine("Введите число строк");
            uint.TryParse(Console.ReadLine(), out rows);

            Console.WriteLine($"Колонок: {columns}");
            Console.WriteLine($"Строк: {rows}");

            tab = new uint[columns, rows];

            for (uint i = 0; i < columns; i++)
            {
                for (uint j = 0; j < rows; j++)
                {
                    tab[i, j] = (i + 1) * (j + 1);
                    if (j == 0)
                    {
                        Console.WriteLine();
                    }
                    Console.Write(tab[i, j] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
