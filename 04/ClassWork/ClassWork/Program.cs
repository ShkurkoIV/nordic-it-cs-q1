using System;

namespace ClassWork
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 100;
			int b = 17;

			Console.WriteLine($"a + b = {a + b}");
			Console.WriteLine($"a - b = {a - b}");
			Console.WriteLine($"a * b = {a * b}");
			Console.WriteLine($"a / b = {a / b}");
			Console.WriteLine($"a % b = {a % b}");

			Console.WriteLine();
			double c = 48.13;
			float d = 2.5F;

			Console.WriteLine($"c + d = {c + d}");
			Console.WriteLine($"c - d = {c - d}");
			Console.WriteLine($"c * d = {c * d}");
			Console.WriteLine($"c / d = {c / d}");
			Console.WriteLine($"c % d = {c % d}");

			for (int i = 0; i < 10; ++i)
			{
				Console.WriteLine(i);
			}

			Console.ReadLine();

		}
	}
}
