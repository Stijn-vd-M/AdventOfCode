namespace Day5
{
	internal static class ListExtensions
	{
		public static T RemoveLast<T>(this IList<T> list) => list.RemoveLast(1)[0];

		public static T[] RemoveLast<T>(this IList<T> list, int amount)
		{
			if (amount < 1)
			{
				throw new ArgumentOutOfRangeException(nameof(amount));
			}

			if (list.Count == 0)
			{
				return Array.Empty<T>();//throw new IndexOutOfRangeException(nameof(list));
			}

			if (amount > list.Count)
			{
				amount = list.Count;
			}

			var r = new Range(list.Count - amount, list.Count);

			var result = list.Take(r).ToArray();

			list.RemoveAtEnd(amount);

			return result.ToArray();
		}

		public static void AddRange<T>(this IList<T> list, IList<T> items)
		{
			foreach(var item in items)
			{
				list.Add(item);
			}
		}

		public static void RemoveAtEnd<T>(this IList<T> list, int amount)
		{
			for (var i = 0; i < amount; i ++)
			{
				list.RemoveAt(list.Count - 1);
			}
		}
	}
}