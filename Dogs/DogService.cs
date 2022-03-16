using System;

namespace Dogs
{
	public static class DogService
	{
		public static void ColorWeight(this Dog dog)
		{
			if (dog.Weight < 50)
			{
				Color(dog, ConsoleColor.Green);
			}
			else
			{
				Color(dog, ConsoleColor.Red);
			}
		}

		private static void Color(Dog dog, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(dog.ToString());
			Console.ResetColor();
		}
	}
}
