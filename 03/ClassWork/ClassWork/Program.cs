using System;

namespace ClassWork
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[5];

			for (int i = 0; i < array.Length; i++)
			{
				//Console.WriteLine(array[i]);
			}
			foreach (var item in array)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}

		
	
	}
}
