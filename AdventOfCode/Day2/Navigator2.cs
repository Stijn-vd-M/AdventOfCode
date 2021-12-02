namespace Day2
{
	public class Navigator2 : INavigator2
	{
		public int HorizontalPosition { get; private set; }
		public int Depth { get; private set; }
		public int Aim { get; private set; }

		public void AddCommand(NavigationCommand command, int amount)
		{
			switch(command)
			{
				case NavigationCommand.forward:
					HorizontalPosition += amount;
					Depth += Aim * amount;
					break;
				case NavigationCommand.up:
					Aim -= amount;
					break;
				case NavigationCommand.down:
					Aim += amount;
					break;
			}
		}

		public int GetTotalDistance()
		{
			return HorizontalPosition * Depth;
		}
	}
}