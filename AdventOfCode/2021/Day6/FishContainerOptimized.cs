using System.Collections.Generic;
using System.Linq;

namespace Day6
{
	public record FishRecord
	{
		public int Age => BaseFish.Age;
		public long FishCount { get; private set; }

		private readonly IFish BaseFish;


		public FishRecord(IFish fish, long amountOfFish)
		{
			BaseFish = fish;
			FishCount = amountOfFish;
		}

		public long NewDay()
		{
			if (BaseFish.GoToNextDay() != null)
			{
				return FishCount;
			}

			return 0;
		}

		public void AddFishAmount(long add)
		{
			FishCount += add;
		}
	}

	public class FishContainerOptimized : IFishContainer
	{
		public long FishCount
		{
			get
			{
				var result = 0L;

				foreach (var record in _records)
				{
					result += record.FishCount;
				}

				return result;
			}
		}

		private readonly IList<FishRecord> _records;


		public FishContainerOptimized(params int[] fishAges)
		{
			_records = new List<FishRecord>();

			var ages = fishAges.GroupBy(a => a).ToDictionary(a => a.Key, a => a.Count());

			foreach(var ageGroup in ages)
			{
				_records.Add(new FishRecord(new Fish(ageGroup.Key), ageGroup.Value));
			}
		}


		public void GoToNextDay()
		{
			var newFishes = 0L;

			foreach(var record in _records)
			{
				newFishes += record.NewDay();
			}

			if (newFishes == 0)
			{
				return;
			}

			var existing = _records.FirstOrDefault(r => r.Age == 8);

			if (existing != null)
			{
				existing.AddFishAmount(newFishes);
			}
			else
			{
				_records.Add(new FishRecord(new Fish(8), newFishes));
			}
		}
	}
}