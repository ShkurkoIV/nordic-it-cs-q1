using System;

namespace ClassWork
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
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
			
			*/

			/*
			int a = 18;
			int b = a++;
			Console.WriteLine(a == b);
			Console.WriteLine(a != b);
			Console.WriteLine(a > b);
			Console.WriteLine(a < b);
			Console.WriteLine(a >= b);
			Console.WriteLine(a <= b);
			*/

			int a = int.Parse(Console.ReadLine());
			double h = double.Parse(Console.ReadLine());
			int n = int.Parse(Console.ReadLine());

			var x = a / (2 * Math.Tan((180 / n) / 57.3));
			var y = (n * a) / 2;

			var sFull = y * (x + Math.Sqrt(Math.Pow(h, 2) + Math.Pow(x, 2)));
			var s = y * (Math.Sqrt(Math.Pow(h, 2) + Math.Pow(x, 2)));
			var v = (h * n * Math.Pow(a, 2)) / (12 * Math.Tan((180 / n) / 57.3));

			Console.WriteLine(sFull);
			Console.WriteLine(s);
			Console.WriteLine(v);


			Console.ReadLine();


		}
	}
}
