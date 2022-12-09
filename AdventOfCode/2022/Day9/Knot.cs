namespace Day9
{
	internal class Knot
	{
		public IReadOnlyList<Coord> History => _history.AsReadOnly();

		private Coord _coord { get; set; }

		private Knot? _drags { get; }

		private readonly IList<Coord> _history;


		public Knot(Knot drags, int x, int y) : this(x, y)
		{
			_drags = drags;
		}
		
		public Knot(int x, int y)
		{
			_coord = new Coord(x, y);
			_history = new List<Coord>() { _coord };
		}


		public void Move(Direction direction)
		{
			_coord = _coord.Move(direction);
			_history.Add(_coord);

			if (_drags != null)
			{
				_drags.Drag(_coord.X, _coord.Y);
			}
		}

		protected void Drag(int x, int y)
		{
			var direction = Direction.None;

			if (_coord.X - x > 1)
			{
				direction |= Direction.West;

				if (_coord.Y < y) { direction |= Direction.South; }
				if (_coord.Y > y) { direction |= Direction.North; }
			}
			else if (_coord.X - x < -1)
			{
				direction |= Direction.East;

				if (_coord.Y < y) { direction |= Direction.South; }
				if (_coord.Y > y) { direction |= Direction.North; }
			}
			else if (_coord.Y - y > 1)
			{
				direction |= Direction.North;

				if (_coord.X < x) { direction |= Direction.East; }
				if (_coord.X > x) { direction |= Direction.West; }
			}
			else if (_coord.Y - y < -1)
			{
				direction |= Direction.South;

				if (_coord.X < x) { direction |= Direction.East; }
				if (_coord.X > x) { direction |= Direction.West; }
			}

			Move(direction);
		}
	}
}