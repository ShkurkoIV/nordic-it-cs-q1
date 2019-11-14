using System;

namespace HomeWork
{
    class Program
    {
        enum Figures : int
        {
            circle = 1,
            equilateralTriangle = 2,
            rectangle = 3
        }
        static void Main(string[] args)
        {
            Figures type = Figures.circle;
            double area = 0;
            double perimeter = 0;
        TypeSelect:
            Console.WriteLine("Укажите тип фигуры (1 - круг, 2 - равносторонний треугольник, 3 - прямоугольник)");
            try
            {
                type = (Figures)Enum.Parse(typeof(Figures), Console.ReadLine());
                if (!Enum.IsDefined(typeof(Figures), type))
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Неправельный тип фигуры. Попробовать еще раз Y/N ?");
                String answer = "";
                while (!(answer.ToLower() == "y" || answer.ToLower() == "n"))
                {
                    answer = Console.ReadLine();
                }
                if (answer.ToLower() == "y")
                {
                    goto TypeSelect;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        ParameterEntry:
            double r = 0;
            double a = 0;
            double b = 0;
            switch (type)
            {
                case Figures.circle:
                    Console.WriteLine("Укажите диаметр");
                    try
                    {
                        r = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Введено нечисловое значение. Попробовать еще раз Y/N ?");
                        String answer = "";
                        while (!(answer.ToLower() == "y" || answer.ToLower() == "n"))
                        {
                            answer = Console.ReadLine();
                        }
                        if (answer.ToLower() == "y")
                        {
                            goto ParameterEntry;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                    area = Math.Pow(r, 2) * Math.PI;
                    perimeter = 2 * Math.PI * r;
                    break;
                case Figures.equilateralTriangle:
                    Console.WriteLine("Укажите длину стороны");
                    try
                    {
                        a = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Введено нечисловое значение. Попробовать еще раз Y/N ?");
                        String answer = "";
                        while (!(answer.ToLower() == "y" || answer.ToLower() == "n"))
                        {
                            answer = Console.ReadLine();
                        }
                        if (answer.ToLower() == "y")
                        {
                            goto ParameterEntry;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                    area = (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;
                    perimeter = a * 3;
                    break;
                case Figures.rectangle:
                    Console.WriteLine("Укажите ширину и высоту");
                    try
                    {
                        a = double.Parse(Console.ReadLine());
                        b = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Введено нечисловое значение. Попробовать еще раз Y/N ?");
                        String answer = "";
                        while (!(answer.ToLower() == "y" || answer.ToLower() == "n"))
                        {
                            answer = Console.ReadLine();
                        }
                        if (answer.ToLower() == "y")
                        {
                            goto ParameterEntry;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                    area = a * b;
                    perimeter = (a + b) * 2;
                    break;
            }
            Console.WriteLine($"Площадь фигуры {type} равна {area}");
            Console.WriteLine($"Периметр фигуры {type} равен {perimeter}");
            Console.ReadKey();

        }

    }
}
