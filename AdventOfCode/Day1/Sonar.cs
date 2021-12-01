using System;
using System.Collections.Generic;

namespace Day1
{
	public class Sonar : ISonar
	{
		public int DepthMeasurementCount => _depthMeasurements.Count;

		private readonly IList<DepthMeasurement> _depthMeasurements = new List<DepthMeasurement>();

		private Tuple<DepthMeasurement, int?> _cache1;
		private Tuple<DepthMeasurement, int?> _cache2;
		private Tuple<DepthMeasurement, int?> _cache3;


		public void AddDepthMeasurement(int depth)
		{
			_cache3 = _cache2 == null ? null : new(_cache2.Item1, _cache2.Item2);
			_cache2 = _cache1 == null ? null : new(_cache1.Item1, _cache1.Item2);

			var record = new DepthMeasurement(depth);
			_cache1 = new Tuple<DepthMeasurement, int?>(record, depth);
			_depthMeasurements.Add(record);
			
			if (_cache2 != null)
			{
				_cache2.Item1.AddSecondMeasurement(depth);
			}

			if (_cache3 != null)
			{
				_cache3.Item1.AddThirdMeasurement(depth);
			}

		}

		public int GetTotalDepthIncreases()
		{
			if (DepthMeasurementCount < 2)
			{
				return 0;
			}

			var result = 0;

			for (var i = 1; i < DepthMeasurementCount; i ++)
			{
				if (_depthMeasurements[i - 1] < _depthMeasurements[i])
				{
					result++;
				}
			}

			return result;
		}
	}
}