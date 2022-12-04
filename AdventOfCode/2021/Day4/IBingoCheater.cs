namespace Day4
{
	public interface IBingoCheater
	{
		int AmountOfCards { get; }

		void AddCard(IBingoCard card);
		int CallNumbers(params int[] numbers);
		int GetLastWinner(params int[] numbers);
	}
}