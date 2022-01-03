using System;
using System.Linq;

namespace Day8
{
	public class DigitGuesser
	{
		private readonly string[] _uniquePatterns;
		private readonly string[] _values;
		private readonly Digit _digit;

		public DigitGuesser(string input)
		{
			_digit = new Digit();

			var splitted = input.ToUpper().Split('|', StringSplitOptions.TrimEntries);
			_uniquePatterns = splitted[0].Split(' ');
			_values = splitted[1].Split(' ');

			GuessDigits(_uniquePatterns);
		}

		public void GuessDigits(string[] patterns)
		{
			_digit.AddUniqueInputs(patterns);
		}

		public int[] GetOutput()
		{
			return _values.Select(v => _digit.GetValue(v)).ToArray();
		}
	}
}