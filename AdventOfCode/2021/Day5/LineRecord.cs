namespace Day5
{
	public record LineRecord
	{
		public (int X, int Y) Start { get; init; }
		public (int X, int Y) End { get; init; }

		public bool IsDiagonal { get; init; }

		public LineRecord((int x, int y) start, (int x, int y) end)
		{
			Start = new() { X = start.x, Y = start.y };
			End = new() { X = end.x, Y = end.y };

			IsDiagonal = Start.X != End.X && Start.Y != End.Y;
		}
	}
}