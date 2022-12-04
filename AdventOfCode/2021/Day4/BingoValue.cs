namespace Day4
{
	public record BingoValue
	{
		public int Number { get; init; }
		public bool Stamped { get; private set; }

		public BingoValue(int number)
		{
			Number = number;
		}

		public void Stamp()
		{
			Stamped = true;
		}
	}
}