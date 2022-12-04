namespace Day5
{
	public interface IRadar
	{
		public int InputCounter { get; }

		public void AddInput((int x, int y) start, (int x, int y) end);
		public int CountOverlap(int minimum);
	}
}