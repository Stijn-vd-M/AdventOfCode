namespace Day1
{
	public interface ISonar
	{
		int DepthMeasurementCount { get; }

		void AddDepthMeasurement(int depth);
		int GetTotalDepthIncreases();
	}
}