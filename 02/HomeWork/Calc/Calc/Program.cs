using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = false;
            double number1 = 0;
            double number2 = 0;
            double operationResult = 0;

            Console.WriteLine("Ведите первое число");
            while (!result)
            {
                try
                {
                    number1 = Double.Parse(Console.ReadLine());
                    result = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            result = false;
            Console.WriteLine("Ведите второе число");
            while (!result)
            {
                try
                {
                    number2 = Double.Parse(Console.ReadLine());
                    result = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Выберите операцию: + - * / % ^");
            var operation = Console.ReadLine();
            if (operation == "+")
            {
                operationResult = number1 + number2;
            }
            else if (operation == "-")
            {
                operationResult = number1 - number2;
            }
            else if (operation == "*")
            {
                operationResult = number1 * number2;
            }
            else if (operation == "/")
            {
                operationResult = number2 == 0 ? 0 :  number1 / number2;
            }
            else if (operation == "%")
            {
                operationResult = number1 % number2;
            }
            else if (operation == "^")
            {
                operationResult = Math.Pow(number1, number2);
            }
            else
            {
                Console.WriteLine("Неизвесная операция");
            }
            Console.WriteLine($"Результат: {operationResult}");
            Console.ReadKey();
        }
    }
}
