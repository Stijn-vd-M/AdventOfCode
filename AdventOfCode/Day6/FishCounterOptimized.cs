using System;
using System.Collections.Generic;
using System.Linq;

namespace Day6
{
	// FML; nice in concept, but WAAAAAAY to many data for this functionality
	public class FishCounterOptimized
	{
		private const uint _BirthingFish = 0;
		private const uint _emptyFish = ((uint.MaxValue << 2) >> 25) >> 2;

		private readonly IList<uint> _fishies;

		public FishCounterOptimized(params byte[] ages)
		{
			_fishies = Combine(ages);
		}

		public void GoToNextDay()
		{
			var newFishesCount = 0;

			for (var i = 0; i < _fishies.Count; i ++)
			{
				var r = NextDay(_fishies[i]);
				_fishies[i] = r.ages;
				newFishesCount += r.newFishes;
			}

			if (newFishesCount == 0)
			{
				return;
			}

			var lastIndex = _fishies.Count - 1;
			var lastSubIndex = GetFishIndex(_fishies[lastIndex]);

			while (lastSubIndex < 6 && newFishesCount > 0)
			{
				_fishies[lastIndex] = ReplaceAge(_fishies[lastIndex], 8, lastSubIndex);
				lastSubIndex++;
				newFishesCount--;
			}

			if (newFishesCount == 0)
			{
				return;
			}

			var subValue = uint.MaxValue;
			var internalCounter = 0;

			while (newFishesCount > 0)
			{
				if (internalCounter == 6)
				{
					_fishies.Add(subValue);
					subValue = uint.MaxValue;
					internalCounter = 0;
				}

				subValue = ReplaceAge(subValue, 8, internalCounter);
				internalCounter++;
				newFishesCount--;
			}

			if (subValue != uint.MaxValue)
			{
				_fishies.Add(subValue);
			}
		}

		public int GetTotalFishes()
		{
			if (_fishies.Count == 0)
			{
				return 0;
			}

			var fullCount = (_fishies.Count - 1) * 6;
			var lastIndex = GetFishIndex(_fishies.Last());

			return fullCount + lastIndex + (lastIndex == 6 ? 0 : 1);
		}

		private static bool IsEmptyFishSpot(uint combinedAge, int index, out uint bitshiftedAge)
		{
			bitshiftedAge = (combinedAge << ((index * 5) + 2)) >> ((index * 5) + 2 + ((5 - index) * 5));
			
			return bitshiftedAge == _emptyFish;
		}

		private static int GetFishIndex(uint ageCombination)
		{
			//[..|?????|xxxxx|xxxxx|xxxxx|xxxxx|xxxxx]
			if (IsEmptyFishSpot(ageCombination, 0, out _))
			{
				return 0;
			}
			else
			{
				//[xx|xxx..|?????|xxxxx|xxxxx|xxxxx|xxxxx]
				if (IsEmptyFishSpot(ageCombination, 1, out _))
				{
					return 1;
				}
				else
				{
					//[xx|xxxxx|xxx..|?????|xxxxx|xxxxx|xxxxx]
					if (IsEmptyFishSpot(ageCombination, 2, out _))
					{
						return 2;
					}
					else
					{
						//[xx|xxxxx|xxxxx|xxx..|?????|xxxxx|xxxxx]
						if (IsEmptyFishSpot(ageCombination, 3, out _))
						{
							return 3;
						}
						else
						{
							//[xx|xxxxx|xxxxx|xxxxx|xxx..|?????|xxxxx]
							if (IsEmptyFishSpot(ageCombination, 4, out _))
							{
								return 4;
							}
							else
							{
								//[xx|xxxxx|xxxxx|xxxxx|xxxxx|xxx..|?????]
								if (IsEmptyFishSpot(ageCombination, 5, out _))
								{
									return 5;
								}
								else
								{
									return 6;
								}
							}
						}
					}
				}
			}
		}

		private static (uint ages, int newFishes) NextDay(uint ageCombination)
		{
			int newFishes = 0;

			if (IsEmptyFishSpot(ageCombination, 0, out var age1))
			{
				throw new Exception("first fish age is empty!");
			}

			if (age1 == _BirthingFish)
			{
				newFishes++;
				ageCombination = ReplaceAge(ageCombination, 6, 0);
			}
			else
			{
				ageCombination = ReplaceAge(ageCombination, age1 - 1, 0);
			}

			for (var i = 1; i < 6; i ++)
			{
				if (IsEmptyFishSpot(ageCombination, i, out var age))
				{
					break;
				}
				else
				{
					if (age == _BirthingFish)
					{
						newFishes++;
						ageCombination = ReplaceAge(ageCombination, 6, i);
					}
					else
					{
						ageCombination = ReplaceAge(ageCombination, age - 1, i);
					}
				}
			}

			return (ageCombination, newFishes);
		}

		private static IList<uint> Combine(IList<byte> singleAges)
		{
			var result = new List<uint>();
			var internalCounter = 0;
			uint internalValue = uint.MaxValue;

			foreach(var age in singleAges)
			{
				if (internalCounter == 6)
				{
					result.Add(internalValue);

					internalCounter = 0;
					internalValue = uint.MaxValue;
				}

				internalValue = ReplaceAge(internalValue, age, internalCounter);
				internalCounter++;
			}

			if (internalValue != uint.MaxValue)
			{
				result.Add(internalValue);
			}

			return result;
		}

		private static uint ReplaceAge(uint combinedAge, uint singleAge, int index)
		{
			if (index == 6)
			{
				throw new Exception("trying to add a seventh age");
			}

			var leftPart = (combinedAge >> ((6 - index) * 5)) << ((6 - index) * 5);
			var rightPart = index == 5 ? 0 : (combinedAge << (((index + 1) * 5) + 2)) >> (((index + 1) * 5) + 2);
			var middlePart = singleAge << ((5 - index) * 5);

			return leftPart | middlePart | rightPart;
		}
	}
}