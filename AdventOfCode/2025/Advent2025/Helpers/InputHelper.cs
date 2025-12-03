namespace Advent2025.Helpers;

internal static class InputHelper
{
    internal static string[] ProcessLines(string multiLine)
    {
        if (string.IsNullOrWhiteSpace(multiLine))
        {
            return [];
        }

        return multiLine.Split('\n', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
    }
}
