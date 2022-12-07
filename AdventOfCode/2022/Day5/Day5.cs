using Common;
using System.Text.RegularExpressions;

namespace Day5
{
	public class Day5
	{
		private const string Text = "move 3 from 2 to 5-move 2 from 9 to 6-move 4 from 7 to 1-move 7 from 3 to 4-move 2 from 9 to 8-move 8 from 8 to 6-move 1 from 7 to 4-move 8 from 6 to 4-move 4 from 5 to 7-move 3 from 4 to 9-move 2 from 6 to 3-move 11 from 4 to 1-move 1 from 3 to 4-move 2 from 3 to 1-move 1 from 7 to 6-move 14 from 1 to 6-move 7 from 4 to 3-move 2 from 5 to 9-move 5 from 6 to 4-move 9 from 6 to 1-move 3 from 4 to 8-move 1 from 7 to 6-move 3 from 4 to 1-move 7 from 3 to 8-move 5 from 9 to 5-move 4 from 1 to 4-move 3 from 7 to 2-move 5 from 6 to 2-move 3 from 4 to 1-move 7 from 8 to 5-move 3 from 6 to 8-move 11 from 2 to 1-move 1 from 4 to 3-move 1 from 3 to 9-move 2 from 2 to 9-move 8 from 5 to 4-move 1 from 1 to 7-move 1 from 9 to 5-move 8 from 4 to 1-move 1 from 6 to 8-move 2 from 9 to 1-move 4 from 5 to 3-move 2 from 7 to 3-move 40 from 1 to 2-move 24 from 2 to 9-move 1 from 5 to 6-move 11 from 2 to 3-move 9 from 3 to 5-move 12 from 9 to 4-move 6 from 5 to 7-move 4 from 7 to 4-move 2 from 5 to 1-move 2 from 1 to 9-move 1 from 6 to 8-move 9 from 4 to 8-move 6 from 4 to 9-move 17 from 9 to 6-move 1 from 4 to 6-move 17 from 6 to 5-move 1 from 1 to 4-move 2 from 7 to 9-move 1 from 6 to 7-move 2 from 2 to 9-move 2 from 7 to 2-move 6 from 3 to 8-move 3 from 5 to 9-move 1 from 4 to 9-move 2 from 3 to 7-move 4 from 5 to 6-move 1 from 7 to 4-move 1 from 4 to 2-move 1 from 7 to 5-move 9 from 8 to 1-move 1 from 1 to 2-move 2 from 9 to 3-move 7 from 2 to 7-move 1 from 9 to 5-move 12 from 8 to 7-move 3 from 1 to 9-move 2 from 6 to 4-move 9 from 9 to 3-move 1 from 6 to 7-move 1 from 9 to 5-move 1 from 6 to 1-move 9 from 7 to 1-move 7 from 1 to 8-move 4 from 3 to 9-move 5 from 7 to 1-move 3 from 9 to 1-move 4 from 7 to 2-move 12 from 1 to 5-move 2 from 9 to 4-move 7 from 8 to 2-move 7 from 5 to 7-move 4 from 3 to 4-move 1 from 8 to 1-move 2 from 2 to 1-move 2 from 3 to 1-move 3 from 2 to 7-move 13 from 5 to 4-move 1 from 8 to 3-move 1 from 3 to 8-move 1 from 3 to 5-move 1 from 8 to 7-move 17 from 4 to 8-move 5 from 2 to 6-move 2 from 1 to 6-move 5 from 6 to 3-move 9 from 7 to 1-move 4 from 4 to 3-move 1 from 6 to 2-move 4 from 7 to 4-move 1 from 6 to 5-move 2 from 3 to 2-move 15 from 1 to 4-move 6 from 5 to 4-move 4 from 3 to 5-move 4 from 5 to 2-move 2 from 2 to 4-move 11 from 8 to 1-move 2 from 8 to 3-move 5 from 3 to 7-move 4 from 2 to 8-move 2 from 2 to 9-move 4 from 7 to 8-move 11 from 4 to 6-move 2 from 5 to 4-move 3 from 6 to 9-move 4 from 1 to 4-move 15 from 4 to 9-move 1 from 7 to 3-move 2 from 1 to 2-move 6 from 4 to 5-move 11 from 8 to 2-move 16 from 9 to 4-move 2 from 9 to 1-move 4 from 2 to 3-move 8 from 4 to 9-move 1 from 8 to 7-move 5 from 4 to 7-move 6 from 7 to 3-move 10 from 9 to 5-move 5 from 3 to 1-move 1 from 1 to 4-move 5 from 1 to 9-move 5 from 1 to 7-move 5 from 4 to 1-move 4 from 1 to 6-move 3 from 1 to 9-move 10 from 5 to 9-move 2 from 7 to 1-move 5 from 3 to 6-move 4 from 5 to 7-move 4 from 2 to 6-move 2 from 5 to 6-move 5 from 2 to 7-move 18 from 6 to 1-move 5 from 9 to 2-move 7 from 9 to 6-move 16 from 1 to 7-move 4 from 6 to 1-move 1 from 2 to 6-move 2 from 2 to 6-move 1 from 2 to 4-move 4 from 9 to 3-move 1 from 2 to 8-move 5 from 7 to 5-move 2 from 9 to 3-move 1 from 5 to 9-move 7 from 3 to 4-move 1 from 9 to 7-move 8 from 1 to 9-move 1 from 8 to 9-move 3 from 6 to 9-move 17 from 7 to 5-move 3 from 4 to 8-move 3 from 4 to 2-move 3 from 8 to 3-move 3 from 3 to 7-move 7 from 9 to 3-move 6 from 5 to 9-move 4 from 9 to 3-move 10 from 7 to 2-move 15 from 5 to 2-move 4 from 6 to 3-move 1 from 3 to 2-move 23 from 2 to 5-move 2 from 4 to 6-move 2 from 6 to 7-move 1 from 7 to 2-move 1 from 6 to 9-move 5 from 9 to 8-move 3 from 8 to 7-move 5 from 2 to 6-move 2 from 2 to 3-move 2 from 6 to 3-move 3 from 6 to 2-move 3 from 6 to 8-move 10 from 5 to 9-move 2 from 7 to 5-move 1 from 5 to 8-move 13 from 9 to 5-move 6 from 5 to 6-move 1 from 6 to 1-move 1 from 7 to 3-move 1 from 7 to 3-move 13 from 5 to 6-move 3 from 3 to 5-move 1 from 2 to 1-move 4 from 8 to 9-move 2 from 2 to 6-move 2 from 5 to 3-move 2 from 3 to 6-move 5 from 6 to 4-move 9 from 5 to 9-move 10 from 6 to 9-move 1 from 1 to 7-move 3 from 3 to 9-move 1 from 8 to 1-move 3 from 6 to 3-move 1 from 7 to 6-move 1 from 8 to 7-move 2 from 6 to 1-move 2 from 6 to 4-move 3 from 4 to 6-move 2 from 1 to 4-move 10 from 9 to 6-move 6 from 4 to 9-move 17 from 9 to 1-move 4 from 9 to 5-move 19 from 1 to 7-move 4 from 5 to 6-move 1 from 9 to 3-move 5 from 3 to 4-move 5 from 4 to 8-move 17 from 6 to 9-move 17 from 9 to 2-move 1 from 6 to 1-move 1 from 1 to 2-move 1 from 8 to 3-move 2 from 3 to 2-move 5 from 7 to 1-move 1 from 7 to 3-move 5 from 2 to 9-move 4 from 8 to 2-move 2 from 7 to 8-move 3 from 9 to 3-move 7 from 3 to 9-move 2 from 8 to 7-move 8 from 2 to 9-move 5 from 9 to 6-move 4 from 3 to 9-move 11 from 2 to 3-move 2 from 6 to 5-move 1 from 9 to 4-move 10 from 7 to 3-move 3 from 1 to 8-move 2 from 6 to 7-move 15 from 3 to 8-move 2 from 3 to 2-move 2 from 1 to 3-move 14 from 9 to 6-move 1 from 4 to 9-move 14 from 6 to 3-move 5 from 7 to 2-move 2 from 9 to 2-move 1 from 5 to 3-move 1 from 5 to 8-move 12 from 3 to 7-move 13 from 7 to 8-move 1 from 6 to 7-move 5 from 2 to 6-move 1 from 6 to 2-move 1 from 7 to 6-move 4 from 6 to 8-move 31 from 8 to 7-move 15 from 7 to 8-move 7 from 7 to 5-move 4 from 2 to 3-move 1 from 6 to 2-move 3 from 5 to 8-move 9 from 7 to 4-move 2 from 2 to 9-move 4 from 5 to 6-move 13 from 3 to 9-move 3 from 3 to 5-move 13 from 9 to 1-move 1 from 3 to 2-move 2 from 6 to 5-move 1 from 3 to 4-move 2 from 6 to 5-move 1 from 9 to 1-move 6 from 8 to 9-move 5 from 5 to 2-move 2 from 9 to 8-move 2 from 1 to 6-move 1 from 9 to 4-move 12 from 8 to 4-move 2 from 6 to 9-move 11 from 4 to 3-move 9 from 4 to 2-move 4 from 9 to 7-move 2 from 5 to 6-move 8 from 3 to 4-move 2 from 3 to 9-move 2 from 8 to 9-move 4 from 4 to 9-move 2 from 6 to 7-move 1 from 3 to 7-move 2 from 9 to 1-move 5 from 4 to 2-move 9 from 1 to 8-move 1 from 4 to 9-move 4 from 9 to 3-move 1 from 3 to 6-move 4 from 8 to 7-move 1 from 3 to 6-move 4 from 1 to 7-move 1 from 3 to 8-move 1 from 1 to 8-move 2 from 6 to 7-move 2 from 9 to 1-move 1 from 4 to 5-move 1 from 1 to 5-move 11 from 8 to 4-move 12 from 2 to 8-move 1 from 9 to 8-move 2 from 4 to 5-move 1 from 1 to 8-move 5 from 2 to 1-move 1 from 3 to 2-move 9 from 7 to 3-move 6 from 7 to 5-move 1 from 3 to 4-move 1 from 5 to 1-move 4 from 2 to 5-move 4 from 4 to 1-move 2 from 7 to 3-move 3 from 4 to 1-move 6 from 3 to 7-move 9 from 8 to 7-move 3 from 8 to 7-move 11 from 5 to 9-move 2 from 4 to 8-move 5 from 8 to 7-move 1 from 9 to 8-move 12 from 9 to 5-move 1 from 4 to 5-move 5 from 1 to 8-move 6 from 8 to 3-move 1 from 3 to 8-move 3 from 7 to 9-move 4 from 7 to 6-move 3 from 1 to 3-move 3 from 1 to 6-move 1 from 8 to 1-move 7 from 6 to 2-move 3 from 1 to 8-move 7 from 3 to 4-move 3 from 4 to 1-move 1 from 4 to 2-move 3 from 1 to 2-move 1 from 7 to 6-move 1 from 8 to 5-move 9 from 5 to 3-move 1 from 6 to 9-move 11 from 3 to 6-move 1 from 4 to 1-move 1 from 3 to 4-move 8 from 6 to 9-move 1 from 3 to 1-move 1 from 9 to 1-move 2 from 6 to 2-move 5 from 5 to 7-move 5 from 9 to 3-move 2 from 8 to 5-move 1 from 1 to 2-move 1 from 9 to 1-move 15 from 7 to 4-move 1 from 1 to 6-move 1 from 6 to 9-move 3 from 9 to 3-move 1 from 3 to 5-move 5 from 5 to 3-move 9 from 2 to 9-move 5 from 4 to 1-move 1 from 6 to 7-move 7 from 9 to 3-move 1 from 4 to 7-move 1 from 9 to 6-move 1 from 6 to 5-move 2 from 1 to 4-move 3 from 9 to 3-move 1 from 5 to 6-move 7 from 4 to 3-move 1 from 9 to 3-move 16 from 3 to 1-move 9 from 1 to 3-move 5 from 4 to 2-move 1 from 6 to 9-move 12 from 1 to 9-move 3 from 2 to 9-move 5 from 7 to 3-move 2 from 4 to 8-move 2 from 7 to 2-move 12 from 3 to 5-move 6 from 2 to 9-move 12 from 3 to 1-move 2 from 8 to 6-move 1 from 6 to 1-move 6 from 5 to 8-move 5 from 3 to 2-move 2 from 5 to 8-move 8 from 1 to 8-move 13 from 9 to 7-move 4 from 7 to 5-move 4 from 1 to 4-move 8 from 5 to 6-move 1 from 1 to 6-move 4 from 7 to 3-move 1 from 3 to 1-move 1 from 1 to 9-move 4 from 9 to 5-move 3 from 3 to 7-move 12 from 8 to 7-move 2 from 4 to 3-move 2 from 6 to 9-move 4 from 8 to 2-move 2 from 3 to 9-move 2 from 4 to 7-move 3 from 5 to 7-move 2 from 9 to 7-move 3 from 6 to 1-move 4 from 6 to 7-move 1 from 5 to 4-move 1 from 9 to 3-move 12 from 2 to 5-move 4 from 9 to 7-move 11 from 5 to 1-move 1 from 6 to 5-move 1 from 1 to 4-move 10 from 1 to 2-move 2 from 5 to 1-move 1 from 3 to 5-move 7 from 2 to 5-move 8 from 7 to 8-move 2 from 2 to 8-move 3 from 9 to 4-move 5 from 4 to 3-move 1 from 5 to 7-move 3 from 7 to 1-move 3 from 5 to 8-move 1 from 2 to 5-move 12 from 7 to 6-move 4 from 1 to 3-move 2 from 5 to 6-move 7 from 3 to 7-move 14 from 6 to 4-move 1 from 5 to 6-move 3 from 1 to 3-move 4 from 3 to 2-move 2 from 5 to 8-move 11 from 7 to 4-move 7 from 4 to 5-move 1 from 3 to 4-move 1 from 5 to 6-move 14 from 8 to 7-move 11 from 7 to 3-move 2 from 2 to 6-move 1 from 2 to 3-move 5 from 5 to 4-move 4 from 6 to 4-move 8 from 7 to 8-move 3 from 7 to 3-move 1 from 2 to 1-move 5 from 8 to 2-move 4 from 4 to 3-move 1 from 2 to 9-move 1 from 1 to 9-move 3 from 2 to 1-move 1 from 5 to 4-move 3 from 8 to 1-move 1 from 7 to 4-move 4 from 3 to 9-move 1 from 8 to 7-move 2 from 9 to 1-move 6 from 3 to 4-move 28 from 4 to 7-move 15 from 7 to 8-move 3 from 3 to 8-move 1 from 2 to 9-move 2 from 3 to 2-move 7 from 1 to 4-move 10 from 4 to 5-move 10 from 5 to 6-move 3 from 8 to 2-move 1 from 1 to 7-move 1 from 4 to 7-move 1 from 9 to 6-move 9 from 6 to 7-move 1 from 2 to 4-move 1 from 9 to 5";
		private const char LineBreak = '-';

		private static readonly Regex ActionRegex = new Regex(@"move (?<amount>\d+) from (?<from>\d+) to (?<to>\d+)");


		private readonly IDictionary<int, IList<char>> Input;

		
		public Day5()
		{
			Input = new Dictionary<int, IList<char>>() {
				{ 1, new List<char>(){ 'N', 'D', 'M', 'Q', 'B', 'P', 'Z' } },
				{ 2, new List<char>(){ 'C', 'L', 'Z', 'Q', 'M', 'D', 'H', 'V' } },
				{ 3, new List<char>(){ 'Q', 'H', 'R', 'D', 'V', 'F', 'Z', 'G' } },
				{ 4, new List<char>(){ 'H', 'G', 'D', 'F', 'N' } },
				{ 5, new List<char>(){ 'N', 'F', 'Q' } },
				{ 6, new List<char>(){ 'D', 'Q', 'V', 'Z', 'F', 'B', 'T' } },
				{ 7, new List<char>(){ 'Q', 'M', 'T', 'Z', 'D', 'V', 'S', 'H' } },
				{ 8, new List<char>(){ 'M', 'G', 'F', 'P', 'N', 'Q' } },
				{ 9, new List<char>(){ 'B', 'W', 'R', 'M' } },
			};
		}


		[Fact]
		public void Test1()
		{
			var splits = Text.Split(LineBreak);

			foreach(var action in splits)
			{
				var match = ActionRegex.Match(action);

				var amount = int.Parse(match.Groups["amount"].Value);
				var from = int.Parse(match.Groups["from"].Value);
				var to = int.Parse(match.Groups["to"].Value);

				for (var i = 0; i < amount; i ++)
				{
					if (Input[from].Count == 0) { throw new Exception(); }

					Input[to].Add(Input[from].RemoveLast());
				}
			}

			var result = string.Join("", Input.Select(kv => kv.Value.LastOrDefault(' '))).Trim();
		}

		[Fact]
		public void Test2()
		{
			var splits = Text.Split(LineBreak);

			var step = 0;

			foreach (var action in splits)
			{
				step++;

				var match = ActionRegex.Match(action);

				var amount = int.Parse(match.Groups["amount"].Value);
				var from = int.Parse(match.Groups["from"].Value);
				var to = int.Parse(match.Groups["to"].Value);

				if (amount > Input[from].Count)
				{
					throw new Exception();
				}

				Input[to].AddRange(Input[from].RemoveLast(amount));
			}

			var result = string.Join("", Input.Select(kv => kv.Value.LastOrDefault(' '))).Trim();
		}
	}
}