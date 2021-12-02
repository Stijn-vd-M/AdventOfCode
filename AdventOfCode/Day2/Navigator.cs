namespace Day2
{
	public class Navigator : INavigator
	{
		public int HorizontalPosition { get; private set; }
		public int Depth { get; private set; }

		public void AddVector(Direction direction, int distance)
		{
			switch(direction)
			{
				case Direction.forward:
					HorizontalPosition += distance;
					break;
				case Direction.up:
					Depth -= distance;
					break;
				case Direction.down:
					Depth += distance;
					break;
			}
		}

		public int GetTotalDistance()
		{
			return HorizontalPosition * Depth;
		}
	}
}