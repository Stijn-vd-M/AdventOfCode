namespace Advent2025.Extensions;

internal static class IntExtensions
{
    extension(int v)
    {
        public bool IsEven => v % 2 == 0;
    }
}
