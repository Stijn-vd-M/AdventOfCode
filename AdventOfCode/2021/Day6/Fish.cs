namespace Day6
{
	public class Fish : IFish
	{
		public int Age { get; private set; }


		public Fish(int startingAge)
		{
			Age = startingAge;
		}


		public IFish GoToNextDay()
		{
			if (Age > 0)
			{
				Age--;

				return null;
			}

			Age = 6;

			return new Fish(8);
		}
	}
}