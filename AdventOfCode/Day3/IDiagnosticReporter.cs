namespace Day3
{
	public interface IDiagnosticReporter
	{
		int LineCount { get; }

		void InsertBinaryLine(uint binaryValue);
		void InsertBinaryLines(params uint[] binaryValue);
		bool GetMostCommonBitOnIndex(int bitIndex);
		bool GetLeastCommonBitOnIndex(int bitIndex);
		uint GetGammaRate();
		uint GetEpsilonRate();

		uint GetOxygenGeneratorRating();
		uint GetCO2ScrubberRating();
	}
}