using System;

namespace Dogs
{
	public class Dog
	{
		private int _weight;
		public string Name { get; }
		public int Weight
		{
			get
			{
				return _weight;
			}
			set
			{
				if (value > 0)
				{
					int oldWeight = _weight;
					_weight = value;
					Handler?.Invoke(this, oldWeight);
				}
			}
		}

		public event EventHandler<int> Handler;

		public Dog(string name, int weight)
		{
			Name = name;
			_weight = weight;
		}

		public override string ToString() => $"Кличка: {Name}. Вес: {Weight}";
	}
}
