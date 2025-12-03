using Advent2025.Extensions;

namespace Advent2025.Models;

internal sealed class IdValidatorMulti : IdValidator
{
    internal override ulong GetTotalInvalidIds(string start, string end)
    {
        List<ulong> found = [];

        for (ulong i = ulong.Parse(start); i <= ulong.Parse(end); i++)
        {
            var id = i.ToString();

            for (int j = 2; j <= id.Length; j++)
            {
                if (!id.IsEvenlySplittableBy(j))
                {
                    continue;
                }

                var splits = id.EvenlySplit(j);

                if (Equal(splits))
                {
                    found.Add(i);
                }
            }
        }

        var dist = found.Distinct();
        var result = 0UL;

        foreach (var d in dist)
        {
            result += d;
        }

        return result;
    }

    private static bool Equal(string[] subs)
    {
        for (var i = 1; i < subs.Length; i++)
        {
            if (!subs[0].Equals(subs[i]))
            {
                return false;
            }
        }

        return true;
    }
}
