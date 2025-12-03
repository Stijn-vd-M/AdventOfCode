namespace Advent2025.Extensions;

internal static class StringExtensions
{
    extension(string v)
    {
        public bool IsEvenLength => v.Length.IsEven;

        public bool IsEvenlySplittableBy(int split)
            => v.Length % split == 0;

        public string[] EvenlySplit(int split)
        {
            if (!v.IsEvenlySplittableBy(split))
            {
                throw new NotSupportedException($"Not evenly splittable by '{split}'.");
            }

            var span = v.AsSpan();
            var result = new List<string>();
            var step = span.Length / split;

            for (var i = 0; i < span.Length; i += step)
            {
                var sub = new char[step];

                for (var j = 0; j < step; j++)
                {
                    sub[j] = span[i + j];
                }

                result.Add(new string(sub));
            }

            return result.ToArray();
        }
    }
}
