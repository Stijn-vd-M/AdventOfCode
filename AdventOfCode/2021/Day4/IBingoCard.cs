namespace Day4
{
	public interface IBingoCard
	{
		bool CheckNumber(int number);
		int GetSumOfUnmarkedNumbers();
	}
}