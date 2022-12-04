using Common;
using System.Collections.Generic;

namespace Day6
{
	public class FishContainer : IFishContainer
	{
		public long FishCount => Fishes.Count;

		private readonly IList<IFish> Fishes;


		public FishContainer(params int[] fishAges)
		{
			Fishes = new List<IFish>();

			foreach(var age in fishAges)
			{
				Fishes.Add(new Fish(age));
			}
		}

		public void GoToNextDay()
		{
			var newFishes = new List<IFish>();

			foreach(var fish in Fishes)
			{
				var @new = fish.GoToNextDay();

				if (@new != null)
				{
					newFishes.Add(@new);
				}
			}

			Fishes.AddRange(newFishes);
		}
	}
}