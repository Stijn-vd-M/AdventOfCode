namespace Day9
{
	internal struct Coord : IEquatable<Coord>
	{
		public int X { get; }
		public int Y { get; }


		public Coord(int x, int y)
		{
			X = x;
			Y = y;
		}


		public bool Equals(Coord other)
		{
			return X == other.X && Y == other.Y;
		}

		public Coord Move(Direction direction)
		{
			var x = X;
			var y = Y;

			switch(direction)
			{
				case Direction.NorthEast:
					y--;
					x++;
					break;
				case Direction.NorthWest:
					y--;
					x--;
					break;
				case Direction.SouthEast:
					y++;
					x++;
					break;
				case Direction.SouthWest:
					y++;
					x--;
					break;

				case Direction.North:
					y--;
					break;
				case Direction.South:
					y++;
					break;
				case Direction.East:
					x++;
					break;
				case Direction.West:
					x--;
					break;
			}

			return new Coord(x, y);
		}
	}
}