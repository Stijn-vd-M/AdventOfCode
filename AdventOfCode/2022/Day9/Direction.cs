namespace Day9
{
	[Flags]
	internal enum Direction : byte
	{
		None = 0,

		North = 1,
		South = 2,
		East = 4,
		West = 8,

		NorthEast = North | East,
		NorthWest = North | West,

		SouthEast = South | East,
		SouthWest = South | West,
	}
}