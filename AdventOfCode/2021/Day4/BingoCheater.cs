using Common;
using System.Collections.Generic;
using System.Linq;

namespace Day4
{
	public class BingoCheater : IBingoCheater
	{
		public int AmountOfCards => _cards.Count;

		private readonly IList<IBingoCard> _cards = new List<IBingoCard>();

		public void AddCard(IBingoCard card)
		{
			_cards.Add(card);
		}

		public int CallNumbers(params int[] numbers)
		{
			foreach (var number in numbers)
			{
				foreach (var c in _cards)
				{
					if (c.CheckNumber(number))
					{
						return c.GetSumOfUnmarkedNumbers() * number;
					}
				}
			}

			return -1;
		}

		public int GetLastWinner(params int[] numbers)
		{
			var filtered = _cards.Copy();

			foreach (var number in numbers)
			{
				if (filtered.Count == 1)
				{
					if (filtered[0].CheckNumber(number))
					{
						return filtered[0].GetSumOfUnmarkedNumbers() * number;
					}

					continue;
				}

				var retry = new List<IBingoCard>();

				foreach(var card in filtered)
				{
					if (!card.CheckNumber(number))
					{
						retry.Add(card);
					}
				}

				filtered = retry;
			}

			return -1;
		}
	}
}