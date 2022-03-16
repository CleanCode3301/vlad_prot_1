using System;

namespace Dogs
{
	internal class DogTest
	{
		public static void TestDog()
		{
			var dogs = new Dog[]
			{
				new Dog("Рататуй", 15),
				new Dog("Шуня", 50),
				new Dog("Шнопс", 100),
				new Dog("Вовка", 20)
			};

			var rnd = new Random();

			foreach (Dog item in dogs)
			{
				item.Handler += Message;
				Console.WriteLine(item);

				for (var i = 0; i < 10; i++)
				{
					item.Weight = rnd.Next(-item.Weight, item.Weight);
				}

				item.ColorWeight();
			}
		}

		private static void Message(object dog, int weight)
		{
			var myDog = (Dog)dog;

			if (myDog.Weight > weight)
			{
				Console.WriteLine($"{myDog.Name} поталстел");
			}
			else if (myDog.Weight < weight)
			{
				Console.WriteLine($"{myDog.Name} похудел");
			}
		}
	}
}
