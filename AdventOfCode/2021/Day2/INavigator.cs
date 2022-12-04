namespace Day2
{
	public interface INavigator
	{
		int HorizontalPosition { get; }
		int Depth { get; }

		void AddVector(Direction direction, int distance);
		int GetTotalDistance();
	}
}