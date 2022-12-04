using Day4;

namespace Day4Tests
{
	public class BingoCardBuilder
	{
		private int[] _values;

		public BingoCardBuilder(params int[] values)
		{
			_values = values;
		}

		public BingoCardBuilder()
		{
		}

		public BingoCardBuilder WithStandardValues()
		{
			return WithValues(
				1, 2, 3, 4, 5,
				6, 7, 8, 9, 10,
				11, 12, 13, 14, 15,
				16, 17, 18, 19, 20,
				21, 22, 23, 24, 25
				);
		}

		public BingoCardBuilder WithValues(params int[] values)
		{
			_values = values;

			return this;
		}

		public IBingoCard Build()
		{
			return new BingoCard(_values);
		}
	}
}