namespace Day6
{
	public interface IFish
	{
		int Age { get; }

		IFish GoToNextDay();

		string ToString()
		{
			return Age.ToString();
		}
	}
}