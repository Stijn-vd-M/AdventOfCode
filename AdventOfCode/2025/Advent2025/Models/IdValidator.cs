using Advent2025.Extensions;

namespace Advent2025.Models;

internal class IdValidator
{
    internal virtual ulong GetTotalInvalidIds(string start, string end)
    {
        ulong result = 0;

        for (ulong i = ulong.Parse(start); i <= ulong.Parse(end); i++)
        {
            var id = i.ToString();

            if (!id.IsEvenLength)
            {
                continue;
            }

            var left = id.Substring(0, id.Length / 2);
            var right = id.Substring(id.Length / 2);

            if (left.Equals(right))
            {
                result += i;
            }
        }

        return result;
    }
}
