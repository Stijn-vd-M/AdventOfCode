using System;
using System.Collections.Generic;

namespace Common
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

		public static IList<T> Copy<T>(this IList<T> list)
		{
			if (list == null)
			{
				return null;
			}

			var result = new List<T>();
			var isCanCopy = typeof(T).IsAssignableTo(typeof(ICanCopy));

			foreach (var item in list)
			{
				if (isCanCopy)
				{
					result.Add((T)((ICanCopy)item).Copy());
				}
				else
				{
					result.Add(item);
				}
			}

			return result;
		}
	}
}