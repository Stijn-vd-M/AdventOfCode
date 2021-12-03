using System;
using System.Collections.Generic;

namespace Day3
{
	public static class ListExtensions
	{
		public static void AddRange<T>(this IList<T> list, params T[] items)
		{
			if (list == null)
			{
				throw new ArgumentNullException(nameof(list));
			}

			if (items == null || items.Length == 0)
			{
				return;
			}

			foreach(var item in items)
			{
				list.Add(item);
			}
		}

		public static IList<T> Copy<T>(this IList<T> list) where T : struct
		{
			if (list == null)
			{
				return null;
			}

			var result = new List<T>();

			foreach(var item in list)
			{
				result.Add(item);
			}

			return result;
		}
	}
}