using System.Collections.Generic;
using System.Linq;

namespace Day5
{
	public class Radar : IRadar
	{
		public int InputCounter => _records.Count;

		private readonly IList<LineRecord> _records = new List<LineRecord>();
		private readonly bool _allowDiagonal;

		public Radar(bool allowDiagonal = false)
		{
			_allowDiagonal = allowDiagonal;
		}

		public void AddInput((int x, int y) start, (int x, int y) end)
		{
			var record = new LineRecord(start, end);
			_records.Add(record);
		}

		public int CountOverlap(int minimum)
		{
			if (!_records.Any())
			{
				return 0;
			}

			var field = new Dictionary<(int x, int y), int>();

			PlaceRecordOnField(field);

			var overlap = 0;

			foreach(var point in field)
			{
				if (point.Value >= minimum)
				{
					overlap++;
				}
			}

			return overlap;
		}

		private void PlaceRecordOnField(Dictionary<(int x, int y), int> field)
		{
			foreach (var record in _records)
			{
				if (!_allowDiagonal && record.IsDiagonal)
				{
					continue;
				}

				var horStep = record.Start.X == record.End.X ? 0 : record.Start.X < record.End.X ? 1 : -1;
				var verStep = record.Start.Y == record.End.Y ? 0 : record.Start.Y < record.End.Y ? 1 : -1;

				var x = record.Start.X;
				var y = record.Start.Y;
				var finalX = record.End.X;
				var finalY = record.End.Y;

				var points = new List<(int x, int y)>();

				while (x != finalX || y != finalY)
				{
					var key = (x: x, y: y);

					points.Add(key);

					if (field.ContainsKey(key))
					{
						field[key]++;
					}
					else
					{
						field.Add(key, 1);
					}

					x += horStep;
					y += verStep;
				}

				var lastKey = (x: finalX, y: finalY);
				points.Add(lastKey);

				if (field.ContainsKey(lastKey))
				{
					field[lastKey]++;
				}
				else
				{
					field.Add(lastKey, 1);
				}
			}
		}
	}
}