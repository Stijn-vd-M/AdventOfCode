using System.Collections.Generic;
using System.Linq;

namespace Day7
{
	public class FuelChart
	{
		private readonly IDictionary<int, int> _fuels;


		public FuelChart()
		{
			_fuels = new Dictionary<int, int>();
		}

		public void AddTheCrabs(params int[] crabs)
		{
			var min = crabs.Min();
			var max = crabs.Max();

			for (var i = min; i <= max; i ++)
			{
				_fuels.Add(i, 0);

				foreach(var crab in crabs)
				{
					if (crab < i)
					{
						_fuels[i] += (i - crab);
					}
					else
					{
						_fuels[i] += (crab - i);
					}
				}
			}
		}

		public void AddTheCrabsAgainCommaTheRevengering(params int[] crabs)
		{
			var min = crabs.Min();
			var max = crabs.Max();

			for (var i = min; i <= max; i++)
			{
				_fuels.Add(i, 0);

				foreach(var crab in crabs)
				{
					var left = 0;
					var right = 0;
					var subResult = 0;
					var increment = 0;

					if (crab < i)
					{
						left = crab;
						right = i;
					}
					else
					{
						left = i;
						right = crab;
					}

					for (var j = left; j < right; j ++)
					{
						increment++;
						subResult += increment;
					}

					_fuels[i] += subResult;
				}
			}
		}

		public int GetLowestFuelPoint()
		{
			var lowest = int.MaxValue;
			var result = -1;

			foreach(var kv in _fuels)
			{
				if (kv.Value < lowest)
				{
					lowest = kv.Value;
					result = kv.Key;
				}
			}

			return result;
		}

		public int GetTotalConsumptionOfPoint(int point)
		{
			if (!_fuels.ContainsKey(point))
			{
				return -1;
			}

			return _fuels[point];
		}
	}
}