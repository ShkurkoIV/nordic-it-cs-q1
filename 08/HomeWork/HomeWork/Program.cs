using System;
using System.Collections.Generic;

namespace HomeWork
{
    class Program
    {
        class Human
        {
            int age;
            int ageAfterFourYears;
            public string Name { get; set; }
            public int Age {
                get
                {
                    return this.age;
                }
                set
                {
                    age = value;
                    ageAfterFourYears = value + 4;
                }
            }
            int AgeAfterFourYears { get { return ageAfterFourYears; } }
            public string Info { get { return $"Name: {Name}, age in 4 years: {AgeAfterFourYears}."; } }

            public Human(string name, int age)
            {
                Name = name;
                Age = age;
            }

        }
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter name {i + 1}");
                string name = Console.ReadLine();
                Console.WriteLine($"Enter age {i + 1}");
                int age = 0;
                try
                {
                    age = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {

                    throw new Exception("Некорректный ввод!", e);
                }
                
                humans.Add(new Human(name, age));
                
            }

            humans.ForEach(x => Console.WriteLine(x.Info));
            Console.ReadKey();
        }
    }
}
