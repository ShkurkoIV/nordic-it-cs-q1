using System;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число от одного до 100");
            int a = int.Parse(Console.ReadLine());

            string answer = a >= 50 ? "число больше или равно 50" : "число меньше 50";
            Console.WriteLine(answer);
        }
    }
}
