namespace Day1
{
	public record DepthMeasurement
	{
		public bool IsValid => _second.HasValue && _third.HasValue;

		private int _first { get; init; }
		private int? _second { get; set; }
		private int? _third { get; set; }

		public DepthMeasurement(int first)
		{
			_first = first;
		}

		public void AddSecondMeasurement(int measurement)
		{
			_second = measurement;
		}

		public void AddThirdMeasurement(int measurement)
		{
			_third = measurement;
		}

		public static bool operator < (DepthMeasurement a, DepthMeasurement b) => a.IsValid && b.IsValid && (a._first + a._second + a._third) < (b._first + b._second + b._third);
		public static bool operator > (DepthMeasurement a, DepthMeasurement b) => a.IsValid && b.IsValid && (a._first + a._second + a._third) > (b._first + b._second + b._third);
	}
}