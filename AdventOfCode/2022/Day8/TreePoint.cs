namespace Day8
{
	internal struct TreePoint : IEquatable<TreePoint>
	{
		public int X { get; }
		public int Y { get; }


		public TreePoint(int x, int y)
		{
			X = x;
			Y = y;
		}

		public bool Equals(TreePoint other)
		{
			return X == other.X && Y == other.Y;
		}
	}
}