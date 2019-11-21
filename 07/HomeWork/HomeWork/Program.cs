using System;
using System.Linq;
using System.Collections.Generic;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> brackets = new Dictionary<char, char>();
            brackets.Add('(', ')');
            brackets.Add('[', ']');
            brackets.Add('{', '}');

            Stack<char> openBrackets = new Stack<char>();

            var result = false;
            var error  = false;

            var input = Console.ReadLine();

            foreach (var character in input)
            {
                if (brackets.ContainsKey(character))
                {
                    openBrackets.Push(character);
                }
                if (brackets.ContainsValue(character))
                {
                    if(openBrackets.Count == 0 || brackets[openBrackets.Peek()] != character)
                    {
                        error = true;
                        break;
                    }

                    openBrackets.Pop();
                }
            }

            if (!error)
            {
                result = openBrackets.Count == 0;
            }

            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
