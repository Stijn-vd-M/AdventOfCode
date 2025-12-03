namespace Advent2025.Helpers;

internal static class InputHelper
{
    internal static string[] ProcessLines(string multiLine, char splitter = '\n')
    {
        if (string.IsNullOrWhiteSpace(multiLine))
        {
            return [];
        }

        return multiLine.Split(splitter, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
    }
}
