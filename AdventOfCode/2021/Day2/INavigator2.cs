namespace Day2
{
	public interface INavigator2
	{
		int HorizontalPosition { get; }
		int Depth { get; }
		int Aim { get; }

		void AddCommand(NavigationCommand command, int amount);
		int GetTotalDistance();
	}
}