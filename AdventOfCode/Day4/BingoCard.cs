using System;
using System.Collections.Generic;

namespace Day4
{
	public class BingoCard : IBingoCard
	{
		private readonly BingoValue[][] _cardValues;

		public BingoCard(params int[] values)
		{
			var valuesPerLines = (int)Math.Sqrt(values.Length);
			var cardValues = new List<BingoValue[]>();

			for (var l = 0; l < valuesPerLines; l ++)
			{
				var line = new List<BingoValue>();

				for (var i = 0; i < valuesPerLines; i ++)
				{
					line.Add(new BingoValue(values[(l * valuesPerLines) + i]));
				}

				cardValues.Add(line.ToArray());
			}

			_cardValues = cardValues.ToArray();
		}

		public bool CheckNumber(int number)
		{
			BingoValue found = null;

			foreach (var line in _cardValues)
			{
				if (found != null)
				{
					break;
				}

				foreach (var c in line)
				{
					if (c.Number == number)
					{
						found = c;
						break;
					}
				}
			}

			if (found != null)
			{
				found.Stamp();

				return IsLineBingo() || IsCollumnBingo();
			}

			return false;
		}

		public int GetSumOfUnmarkedNumbers()
		{
			var result = 0;

			foreach(var line in _cardValues)
			{
				foreach(var value in line)
				{
					if (!value.Stamped)
					{
						result += value.Number;
					}
				}
			}

			return result;
		}

		private bool IsLineBingo()
		{
			foreach(var line in _cardValues)
			{
				var isBingo = true;

				foreach(var space in line)
				{
					if (!space.Stamped)
					{
						isBingo = false;
						break;
					}
				}

				if (isBingo)
				{
					return true;
				}
			}

			return false;
		}

		private bool IsCollumnBingo()
		{
			var totalCollumns = _cardValues[0].Length;

			for (var c = 0; c < totalCollumns; c ++)
			{
				var isBingo = true;

				foreach(var line in _cardValues)
				{
					if (!line[c].Stamped)
					{
						isBingo = false;
						break;
					}
				}

				if (isBingo)
				{
					return true;
				}
			}

			return false;
		}
	}
}