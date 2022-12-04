namespace Day2
{
	public class Day2
	{
		private const string Text = "A+X-B+Z-C+Z-B+Z-B+Z-A+Y-A+Y-A+Z-A+Y-B+Y-A+Y-B+Y-B+Z-A+Y-C+X-B+X-A+Y-B+Z-B+X-A+Y-A+Y-A+Z-B+Z-B+Z-C+Y-C+Y-B+Z-A+Y-A+Y-B+Z-B+X-B+Z-A+Z-A+X-C+X-A+Y-B+Z-A+Y-B+Z-B+Z-B+Z-B+Z-A+Y-A+Y-C+Y-A+Y-A+Y-A+Y-B+Z-A+Y-A+Z-B+X-B+Z-A+Y-A+Y-A+Y-B+Z-C+X-B+Z-A+Y-B+Z-A+Y-A+Y-A+Y-A+Z-A+X-C+X-A+Y-C+Z-C+X-C+X-B+Z-A+Z-A+Z-B+Z-A+Z-A+X-C+X-A+X-C+X-A+Y-B+Z-A+Z-B+Z-A+Y-B+Z-C+X-A+Y-B+Z-A+Z-B+Z-A+Y-A+Z-B+Z-A+X-C+X-A+X-A+Y-B+Z-B+Z-A+Y-B+Z-B+Z-C+Z-A+Y-A+Y-C+Y-A+Z-B+Z-A+Y-C+X-A+Y-B+Z-A+Y-C+X-A+Y-B+Z-A+Y-C+X-C+X-B+Z-B+Z-B+Z-A+Y-A+X-C+X-A+Y-A+Y-A+Y-A+Y-A+Y-A+Y-B+Z-A+Z-A+Y-A+Z-B+Z-B+Z-B+Z-A+Y-B+Z-A+X-A+Y-A+Z-A+Z-A+Y-A+Y-B+Z-A+Y-C+X-B+Z-A+Y-B+Z-C+X-A+Y-A+Y-B+Z-C+X-A+Y-A+Y-A+X-A+Z-A+Y-A+Z-A+Y-A+Y-B+Z-B+Z-A+Y-C+X-B+Z-B+Y-A+Y-C+Y-A+Y-A+Z-B+Y-B+X-A+X-B+Z-B+Z-A+Y-A+X-A+Y-A+Y-A+Y-A+Z-A+Y-A+X-B+Z-A+Z-A+Z-A+Y-C+Z-A+Y-B+Z-C+X-A+Z-C+X-B+Z-A+Y-C+Z-A+Z-B+Z-A+Y-A+Y-B+Z-A+Y-C+X-C+X-A+Z-A+Z-A+Y-A+Y-A+Y-A+Y-C+X-C+X-A+Z-A+Z-C+X-B+Z-C+Y-A+Y-A+Y-A+Y-A+Z-B+X-C+Z-A+Y-B+Z-A+Z-A+X-A+Y-A+Y-B+Z-C+Y-A+Y-A+Z-A+Y-C+X-C+X-A+Z-A+Y-B+Z-A+Y-A+Z-C+X-A+Z-A+Y-A+Y-A+Z-B+Z-A+Y-A+Y-C+X-A+Y-C+X-B+Z-A+X-B+Z-B+Z-A+Y-A+Y-A+Y-A+Y-A+Y-A+Y-B+Z-A+Y-A+Y-A+Z-B+Z-A+Y-A+Y-A+Z-B+Z-A+Y-C+X-A+Y-B+Y-B+Z-A+Y-B+Z-A+Y-A+Y-A+X-A+Z-A+X-B+Z-B+Z-A+Y-A+Y-C+X-A+Z-A+X-A+Y-A+Y-A+Y-C+X-A+Y-A+Z-B+Z-A+X-B+Z-A+Y-A+Z-C+X-B+X-A+Y-C+X-A+Y-A+Y-A+Y-A+Y-B+Z-C+X-B+X-A+Y-B+Z-A+Z-C+X-B+Z-B+Z-C+X-A+Z-C+X-B+Z-C+Y-B+Z-B+Y-B+Z-B+Z-B+Z-C+Z-C+X-A+Y-C+X-B+Z-A+Y-A+X-B+Z-C+X-A+Y-A+Y-A+Z-B+Z-B+Z-C+X-B+Z-A+X-B+Z-A+Y-A+Y-B+Z-A+Y-A+Y-A+X-A+Z-B+Z-B+Z-A+Z-A+Z-A+Y-B+X-A+Y-C+X-A+X-A+Y-A+X-A+Y-A+X-C+X-B+Z-A+Y-B+Z-A+Y-B+Z-B+X-B+Z-A+Y-B+Z-B+Z-C+X-A+Z-A+Y-B+Z-B+Z-C+Y-A+Y-B+X-B+Z-B+Z-A+Y-B+Z-C+X-A+Y-A+Y-B+Z-B+Z-B+Z-C+X-A+Y-A+Z-C+X-A+Z-C+X-B+Z-A+Y-A+Y-B+Z-A+Y-B+Y-B+Y-A+Z-A+Y-B+Z-A+Y-C+X-A+Z-A+Y-A+Z-A+X-A+Y-A+Y-A+Z-C+X-B+Z-A+Y-A+Y-A+Y-C+X-B+Z-C+Y-A+Y-B+X-B+Z-B+Y-B+Z-A+Y-A+X-A+Y-A+X-A+X-B+Z-A+Y-A+Z-B+Z-B+X-A+Y-C+Z-C+X-B+Z-B+Z-C+X-A+Y-B+Z-A+Y-B+Z-B+Z-A+Y-A+Y-B+Y-A+Y-B+Z-B+Z-A+X-B+Z-A+Y-A+Y-B+X-A+Y-B+X-C+X-B+Z-A+Y-B+X-A+Z-A+Y-A+Y-A+Y-B+Z-C+X-A+Y-B+Z-C+Y-A+Y-B+Z-A+Z-C+X-A+Y-A+Y-C+X-A+Y-B+Y-A+Z-A+X-A+Y-C+X-B+Z-C+X-B+Z-A+Y-A+Z-B+X-B+Y-C+X-B+Z-A+Y-C+Z-A+Y-B+Z-B+Z-A+Z-B+Z-B+Z-B+Z-B+X-A+Z-B+Z-B+Z-C+X-A+Y-A+Z-B+Z-A+Y-B+Z-A+Z-C+X-A+Y-B+Z-C+Z-C+X-B+Z-C+X-A+Y-A+Y-A+X-A+Y-B+X-A+Z-A+Y-C+Z-C+X-A+Z-A+Y-B+Z-A+Y-A+Y-A+Y-A+Z-B+Z-B+Z-C+X-A+Y-A+Y-A+Y-A+Y-A+Z-A+Y-C+X-B+X-B+Z-C+X-A+Y-A+Y-A+Z-C+X-A+Y-A+Y-A+Y-B+Z-A+Y-B+Y-A+Y-B+Z-B+Z-B+Z-A+X-C+X-A+Y-B+Y-A+Z-C+X-A+Y-A+Y-A+Y-B+Z-A+Y-A+Y-C+Y-A+Y-A+Y-A+Y-C+X-A+Z-A+Y-A+Y-A+Y-C+X-B+Z-A+Y-C+X-B+X-A+Z-A+Z-A+X-A+Z-A+Y-B+Y-C+X-B+Z-C+X-C+Z-A+Y-C+X-A+Z-C+X-B+Z-B+Z-A+X-B+Y-B+Z-C+Y-B+Z-A+Z-C+X-A+X-B+Z-B+Z-A+Y-A+Y-A+Y-A+X-A+Z-B+Z-A+Y-A+Y-A+Y-A+Y-A+Z-B+Z-B+Z-B+Z-A+X-A+Y-B+Z-A+Z-B+Y-A+Y-A+Y-A+Z-A+Y-C+Z-A+Z-B+Z-A+Y-C+X-A+Y-C+X-B+Z-B+Z-B+Z-A+Y-A+Y-C+X-B+Z-C+X-A+Z-A+Y-C+Y-C+X-C+X-A+Y-C+X-B+Z-B+Z-B+X-C+X-B+Z-A+Y-A+Y-A+Y-A+Y-A+Y-B+X-A+Y-C+X-C+X-A+Y-B+Z-C+X-C+X-A+Y-C+Y-B+Z-B+Z-C+X-A+Z-B+Z-A+Y-A+Z-A+Z-A+Y-A+Y-A+Y-B+Y-B+Z-A+X-A+Y-A+Y-B+Z-C+X-C+X-B+Z-B+Z-A+Y-B+X-C+X-B+Z-A+Y-B+Z-A+Z-A+X-A+Y-A+X-B+Z-A+Z-B+Z-A+Z-B+Z-A+Y-A+Y-A+Y-B+Z-A+X-A+Y-A+Y-C+Z-A+Y-A+Y-C+X-A+Z-A+Z-B+Z-B+X-A+Y-A+X-A+Y-C+X-C+X-B+Z-B+Z-B+Z-A+Y-A+Y-A+Z-A+Y-C+X-C+X-A+Z-A+X-A+Z-B+Z-A+Z-A+X-B+Z-A+Y-B+Z-A+Z-C+X-C+X-C+Y-A+Y-A+Y-A+Y-C+Y-A+Y-B+Z-A+X-A+Y-A+Z-A+Y-B+Z-A+Z-B+Z-B+Z-A+X-C+X-A+Y-A+Y-B+Z-B+Z-A+X-A+Z-A+X-C+X-B+Z-A+Z-A+Z-A+Y-A+Z-B+Z-C+X-A+Z-B+Z-A+Y-A+Z-A+Y-C+X-A+Y-A+Y-B+Z-B+Z-B+Z-A+Y-A+Y-B+Z-B+X-C+X-A+Y-A+Z-A+Z-B+Z-C+X-B+Y-A+Z-A+Z-B+X-C+Z-C+X-A+Y-A+Z-A+Z-C+X-B+Z-B+Z-B+Z-A+Y-A+Y-B+Z-B+Z-A+Z-C+X-B+Z-B+Z-A+Y-A+Y-A+Z-A+Y-C+X-B+X-A+Z-C+X-A+Y-B+Z-A+Y-A+Z-A+Y-A+Y-B+Z-B+Z-C+X-A+Y-A+Y-B+Z-A+Z-A+Y-A+Y-A+Y-A+Y-C+Z-A+X-B+Z-B+Z-A+Y-A+Y-C+X-A+Y-C+X-B+Z-B+Z-A+Z-A+Y-A+Y-A+Y-A+Y-C+X-B+Z-A+Y-B+Z-A+X-A+Y-A+Y-A+Y-C+Y-A+Y-B+Z-C+X-A+Y-A+Y-A+Y-A+Y-A+Y-A+Y-A+Z-A+X-B+Y-B+Z-B+Z-A+Y-C+Y-C+X-A+Y-B+Z-A+Y-B+X-A+X-B+Z-A+Y-A+Y-A+Y-A+Y-C+Y-A+Y-B+Z-A+Y-B+Z-A+Z-B+Z-A+Y-A+Y-A+Z-B+Z-A+Y-A+Y-A+Y-B+Z-A+Y-B+Z-B+Z-A+Y-A+Y-A+Y-A+Y-A+Z-A+Y-A+X-A+Y-B+Y-B+Z-B+Z-A+Y-C+X-B+Z-B+Y-B+Y-C+Z-C+X-A+Y-B+Z-B+Y-B+Z-B+X-A+Z-A+Y-C+X-A+Y-A+Y-C+X-A+Y-C+Y-B+Y-C+X-A+Z-A+Z-A+Y-A+Y-A+X-C+X-B+Z-C+X-C+X-C+X-A+Y-A+Y-A+Y-A+Z-C+Y-A+Z-B+Z-C+X-B+Z-A+Z-A+Y-B+Z-C+X-B+Z-C+Z-C+X-B+X-A+Y-C+Z-C+Z-B+Z-B+Z-A+Y-B+Y-B+Z-A+Y-A+Y-B+Z-A+Z-C+X-A+Z-A+Z-A+Z-B+Y-B+Z-A+Y-A+Y-B+Z-A+Y-A+Z-C+X-A+Y-A+Z-A+Z-A+Y-A+Y-B+Z-A+Y-A+Y-A+Y-A+Y-A+Y-A+Z-B+Z-A+Y-B+Z-B+X-A+Y-A+Z-B+Z-A+Z-A+Y-B+Z-A+Y-B+Z-A+Y-C+X-A+Y-B+Z-A+Y-B+Z-A+Y-A+Y-A+Y-B+Z-A+Y-B+Z-C+X-B+Z-B+Z-A+Y-A+X-A+X-A+X-A+Y-C+Y-A+X-B+Z-A+X-C+X-C+X-C+X-B+Z-A+Y-C+X-C+X-C+Y-B+Z-A+X-A+Y-A+X-A+X-B+Y-C+Z-A+Y-C+X-B+Z-C+Y-B+Z-B+Z-C+Z-A+Y-B+Z-C+X-A+Y-C+X-B+Z-A+Y-A+Y-A+Z-A+Y-A+Y-B+Z-A+Y-C+X-C+X-B+Z-B+Z-C+X-A+X-A+Y-B+Y-A+X-A+X-A+Z-B+Z-A+Z-C+X-A+X-A+Y-B+Z-A+Y-A+Y-A+X-A+Y-A+Y-A+Z-A+Y-B+Z-C+Z-B+Z-B+Z-A+Y-C+X-A+Y-A+Y-B+Z-C+Y-C+X-A+Y-A+Y-A+Y-A+Z-A+Y-A+Y-A+Y-B+Z-C+X-A+Z-C+X-B+Z-A+Y-B+X-B+Z-B+Z-A+Y-A+Y-C+X-B+Z-A+X-C+X-A+Z-B+Z-B+Z-C+X-B+Y-C+X-A+Y-A+Z-C+X-A+Y-B+Z-C+X-A+Y-A+X-A+X-A+Y-C+Y-B+X-A+Y-B+X-A+Y-A+Y-C+X-A+Z-A+Y-A+Z-B+Z-A+Y-C+X-A+Z-B+Z-A+Y-C+Z-A+X-C+X-A+X-C+Y-A+Y-A+Z-B+Y-C+X-B+Z-A+Y-C+X-A+Y-A+Y-A+Y-B+Y-A+X-C+X-A+Y-A+Y-C+X-B+Z-A+Z-A+X-A+Y-A+Y-A+Y-A+Z-A+Z-B+Z-A+Z-A+Y-A+Z-A+Y-C+X-A+Z-C+X-B+Z-B+Z-A+X-A+Y-B+X-B+Z-B+Z-A+Y-B+X-A+X-A+X-A+Y-A+Y-C+X-C+X-A+Y-C+Y-A+Y-C+X-B+Z-C+X-B+Z-A+Z-B+Y-A+Y-B+Z-A+Y-C+Y-B+Z-B+Z-A+Y-A+Y-B+Z-A+Y-B+Z-B+Z-A+Z-A+Y-A+X-A+Y-A+Y-A+Y-A+Y-A+Z-B+Z-A+Y-A+Y-A+Y-B+Z-A+Y-C+X-C+X-B+Z-A+Y-B+Z-B+X-A+Y-C+Z-A+Z-A+Y-B+Z-A+X-C+X-B+X-A+Y-A+Z-A+Y-A+Y-B+Z-A+Y-B+Z-A+Y-C+X-A+Y-A+X-A+Y-C+X-A+Y-C+X-C+X-B+Z-A+Y-B+Z-A+X-B+Z-A+Z-C+X-B+Z-A+Y-A+Y-A+Z-B+Z-A+X-A+Y-A+Y-A+Z-A+Y-A+X-A+Y-C+Y-A+Y-A+Y-A+Y-A+Z-A+Y-B+Z-B+Z-A+Y-A+X-C+X-B+Z-B+Z-A+Z-A+Y-A+Z-B+Z-A+Y-A+Y-C+X-B+Z-A+X-A+Y-B+Z-A+Y-B+Z-B+Z-B+Z-A+X-B+Z-B+Z-A+Y-A+Y-A+Y-B+Z-A+Y-A+X-B+Z-A+Y-B+Z-A+Y-A+Y-B+Z-A+Y-A+Y-B+Z-A+X-A+Z-B+X-A+Y-B+Z-C+X-A+Y-A+Y-C+Z-A+Y-C+X-A+X-B+Z-A+Y-C+X-A+Z-A+Y-B+Z-A+Z-A+X-A+Y-C+X-A+Z-A+X-A+Y-A+X-B+Z-B+X-A+Y-A+Y-A+Y-C+X-A+Y-A+Y-B+Z-B+X-B+Z-B+Z-C+X-C+X-B+Z-B+Z-B+Z-A+Y-B+Z-A+Z-A+Y-C+X-B+Z-A+Y-A+Y-B+Z-C+X-A+Y-C+X-A+Y-B+Z-A+Z-A+Y-A+Y-A+Y-B+X-C+X-B+Z-B+X-A+Y-A+Y-C+X-A+Y-A+Z-C+X-A+Y-A+Z-B+Z-A+Y-A+Y-A+Y-A+Y-A+Y-B+Z-A+Y-C+X-A+Y-B+Z-C+X-A+X-B+Z-C+X-A+Y-A+Y-A+Y-A+Z-A+X-A+Y-C+Y-A+Y-A+Z-A+Y-A+Y-B+Z-A+Y-B+Z-A+Y-C+Y-A+Z-A+Y-C+Z-A+X-A+Y-A+Y-C+Y-A+Z-A+X-C+X-B+X-A+Y-C+X-A+Y-A+Y-A+Y-C+Y-C+X-A+Y-B+Z-A+Y-A+Y-A+Y-A+Z-A+X-A+Y-A+Y-A+Y-B+Z-C+Y-B+Z-A+Y-B+Z-B+Z-A+Z-B+Z-A+X-B+Z-C+Y-A+Y-A+Y-C+X-B+Z-A+Y-A+Z-C+X-B+Z-A+Z-B+Z-C+X-B+X-C+X-C+X-C+X-A+Z-A+Y-A+Z-A+Y-B+Z-A+Y-B+Z-C+X-A+Y-B+Z-B+Z-A+Y-A+Y-B+Z-A+X-A+Z-B+Z-B+Z-A+Y-A+Y-A+Z-C+X-A+X-B+Y-A+Y-B+Z-C+X-A+Y-A+Y-A+Y-A+Y-A+Y-B+Z-B+Z-B+Z-A+Y-A+X-A+Y-A+X-B+Y-B+Z-A+Z-A+Y-A+Y-A+Y-B+Z-B+Y-C+X-A+Z-C+Z-A+Z-C+Y-B+Z-A+Z-C+Z-A+Y-B+Z-A+Y-A+Z-A+Y-A+Y-A+Y-A+Y-A+Y-B+Z-A+Z-A+Y-B+X-C+Y-C+X-A+Y-B+Z-B+Z-A+Y-B+Y-B+Z-B+Z-C+X-C+X-C+X-B+Z-A+X-B+Z-A+Y-A+Y-B+X-A+Z-A+Y-B+Z-A+Z-A+Y-B+Z-B+Z-C+Y-B+Z-B+Z-B+Z-B+Z-A+Z-B+Z-A+Y-B+Z-A+Y-C+X-A+Y-B+Z-A+Y-A+Y-C+X-A+Y-A+Y-A+Y-A+Y-B+Z-A+Y-A+Y-A+Y-A+Z-C+X-A+Y-A+Y-A+Y-B+Z-C+X-A+X-A+Y-B+X-C+X-A+Z-A+X-B+Z-A+Y-C+Y-C+X-A+Y-A+Z-B+Z-A+Y-A+Y-A+Z-A+Y-A+Y-B+Z-C+Z-C+X-A+Y-A+Y-C+X-A+Y-A+X-B+Z-C+Z-A+Y-B+Z-C+X-B+Y-A+Y-B+X-A+Y-A+Y-B+Z-B+Z-A+X-A+Z-A+Z-B+Z-A+Y-B+Z-A+Y-A+Y-B+Z-B+Z-B+X-A+Y-B+X-C+X-B+Z-B+X-A+Y-B+Y-C+X-A+Y-A+Z-A+Y-B+Z-A+Y-B+Z-A+Y-B+Z-A+Y-A+Y-A+Y-A+Z-B+Z-A+Y-B+X-B+X-B+Z-B+Z-A+Z-B+Z-B+Z-A+Y-C+X-C+Y-B+Z-A+Z-A+Z-A+Z-B+Z-B+Z-A+Y-C+X-A+Y-A+Y-C+Y-A+Z-A+Y-A+Y-A+Y-A+Y-A+Y-B+Z-A+Y-C+Y-B+Z-B+Z-A+Y-A+Y-A+Y-A+Y-A+Y-B+Z-B+Z-A+Y-B+Z-B+Z-B+Z-A+Y-A+Y-C+Z-B+Y-A+Y-C+X-A+Z-B+Z-B+Z-B+Z-B+Z-A+X-A+Y-A+X-B+Z-A+Y-A+X-A+Y-B+Z-B+Z-C+X-C+Y-B+Z-A+Y-A+Z-B+X-A+Z-A+Y-A+Z-A+Y-C+X-B+Z-A+Y-C+Z-A+Z-B+Z-A+Y-C+X-B+Z-A+Z-A+Y-A+Y-A+Y-A+Z-C+X-B+X-A+Y-C+X-A+Y-A+Y-A+Y-C+X-A+Y-A+Y-A+Y-A+Y-A+Y-A+Y-B+Z-A+Y-B+Z-B+Z-B+Z-A+Y-A+Y-A+Y-A+Y-A+Z-A+Y-B+Z-B+Z-C+X-B+Z-A+Z-B+Z-A+Z-A+Y-A+X-B+Z-A+Y-A+Y-B+Z-B+Z-A+Y-B+Z-B+Z-A+Y-A+Y-B+Z-B+Z-A+X-B+Z-A+Z-B+Z-C+X-B+Z-A+Y-B+Y-A+Y-B+Z-A+Y-C+X-A+Z-B+Z-A+Y-A+Y-C+X-A+X-A+Z-A+Y-A+Y-A+Y-B+Z-A+X-A+Z-A+Y-A+Y-A+Y-A+Y-C+X-C+X-B+Z-B+Z-A+Y-A+X-C+X-B+Z-B+Z-B+Z-A+Z-B+Z-B+Z-B+Z-A+Z-A+X-A+Y-B+Z-A+X-B+Z-A+X-B+X-B+X-B+Z-A+Z-C+X-A+X-B+Z-B+Z-A+Y-C+Y-B+Z-B+Z-B+Z-B+Z-A+Y-C+X-B+Z-B+Z-A+X-B+Z-A+Y-C+X-C+Z-A+Y-A+Y-B+Z-B+Z-A+Z-A+Y-B+Z-C+X-B+Z-A+Y-A+Y-C+X-A+Y-A+Y-A+X-A+Y-A+Y-A+Z-C+X-A+X-B+Z-C+X-A+X-A+Y-A+Y-B+Z-A+Z-A+Y-A+X-B+Z-A+Y-A+Y-A+Z-A+Y-A+Y-A+Y-B+Z-C+X-C+X-A+Y-A+Y-A+X-A+Z-A+Y-B+X-C+X-C+X-B+Z-A+Y-B+Z-B+Z-A+Y-A+Y-A+Y-A+X-B+X-A+Y-B+Z-A+Y-A+X-A+Y-C+Y-A+Y-B+Z-A+Y-A+X-B+X-B+Z-A+Y-B+Z-B+Z-C+X-A+Z-A+Y-B+Z-A+X-A+Y-A+Y-C+X-B+Z-B+Z-A+Z-A+Y-A+Z-A+Z-B+Z-B+Z-A+X-A+Y-C+X-A+Y-B+Z-B+Z-A+Y-A+Y-A+Z-A+Y-A+Y-A+Y-A+Y-C+X-B+Z-A+Y-B+Z-A+Z-B+Z-A+Y-B+Z-A+Y-B+Z-A+Y-C+X-A+X-A+Y-B+X-C+X-B+Z-A+Y-A+Y-A+Z-A+Y-A+Y-A+Y-A+Y-A+Y-A+Y-B+Z-A+X-B+Z-B+Z-A+Y-C+X-A+Y-C+X-A+Z-A+Y-C+X-A+Y-A+Y-A+Y-C+X-A+X-A+Y-C+Y-A+Y-A+Y-B+Y-B+Z-C+X-A+Y-B+Z-B+Z-A+Y-A+Y-B+Z-A+Y-A+Y-B+Z-A+X-A+X-B+Y-B+X-A+Y-A+Z-C+X-A+Y-A+Y-A+Y-A+Z-C+Z-A+Z-A+Y-A+Z-A+Y-A+X-B+Z-B+Z-C+X-B+Z-C+X-C+X-A+Z-A+Y-A+Y-A+Y-A+Y-A+Y-C+X-B+Z-B+Y-B+Z-A+Y-B+Y-A+Y-A+Y-A+Y-B+Z-A+Z-C+Z-A+Z-B+Y-A+Y-A+Y-B+Z-B+Y-A+Z-A+Y-A+Z-A+Y-C+X-B+Z-B+Z-A+Z-A+X-C+X-A+X-A+X-B+Z-C+X-A+Y-A+Y-A+Z-C+X-C+Y-C+X-A+Y-B+Z-A+Y-A+X-A+Z-B+Z-A+Y-A+Y-A+Y-B+Z-A+Y-B+Z-B+Y-B+Z-B+Z-B+Z-B+Z-A+Y-B+Z-B+Z-A+X-C+Y-C+X-A+Y-A+Z-B+Z-A+Y-A+Y-A+Y-A+Y-A+Y-A+Y-B+Z-B+Z-A+Y-B+Y-B+Z-A+Y-A+Y-A+Z-A+Y-A+Y-A+Y-B+Y-B+Z-C+X-A+Z-A+Z-B+Z-C+Y-C+Z-A+Z-A+Z-A+Y-B+Z-B+Z-B+Z-A+Z-A+Z-B+Y-A+Y-A+X-A+Y-B+Z-A+Y-B+Z-A+Y-A+Y-A+Z-B+Z-A+Y-A+X-A+Y-A+Y-A+Y-A+Y-A+Y-C+X-A+Y-B+Z-A+Z-A+Y-A+Y-A+Y-C+X-A+Y-A+Y-A+Y-A+Y-B+Z-A+Z-A+Y-B+X-B+Z-B+Z-B+Z-B+Z-A+Y-A+Y-C+X-A+Y-A+Y-B+Z-C+X-B+Z-B+Y-A+Y-A+Y-A+Y-B+Z-B+Z-B+Z-A+Y-B+Z-B+X-B+Z-A+Y-A+Y-B+Z-A+Y-B+Z-C+Z-A+Y-B+Z-A+Z-A+Y-B+Z-A+Y-B+Z-C+X-B+Z-A+Y-A+Y-A+Y-A+Z-B+Z-C+X-B+X-A+Y-A+Y-A+Y-C+Y-B+Z-B+Z-A+Y-A+Y-C+X-A+Y-C+Y-B+Z-A+Y-C+X-A+Z-A+Y-A+Y-A+Z-A+Y-A+Y-B+Z-B+Z-C+X-A+Z-A+Y-A+Y-A+X-A+Y-C+X-A+Y-B+Z-A+X-A+Z-B+Z-C+X-A+Y-A+Y-A+Y-A+Y-A+Y-A+Y-A+Z-C+X-A+Y-A+Y-B+Z-A+Z-A+Z-A+Z-A+Y-B+X-A+Y-C+X-A+Y-A+Y-A+X-B+Z-A+Y-A+Z-A+Y-A+Y-A+Z-B+Z-B+Z-A+Y-A+Y-A+Y-A+Z-A+X-A+Z-C+X-A+Y-B+Z-A+Y-A+X-A+Y-A+Z-A+Y-A+Z-A+Y-B+Z-A+Y-B+Z-B+Z-B+Z-A+Y-C+X-B+Z-A+Y-A+Y-C+X-A+Y-A+Z-B+Z-B+Z-A+Y-C+X-A+Y-A+Y-A+Y-B+Z-A+Z-A+Z-C+X-B+Z-C+Y-B+Z-A+Y-A+Y-A+Y-A+Y-A+Y-C+X-A+X-A+Z-A+Y-A+Y-B+Z-A+Y-B+Z-B+Z-A+Y-C+X-B+Z-B+Z-A+Y-A+Y-B+X-C+X-B+Z-A+Y-B+Z-B+Z-C+Y-B+Z-C+X-A+Y-A+Y-A+Y-C+X-A+Y-B+Z-A+Z-B+Z-A+Y-A+Y-C+X-A+X-A+Y-A+Z-A+Y-A+Z-A+Y-A+Y-C+X-A+X-A+X-C+Y-A+Y-A+Y-A+Y-A+Y-B+Z-C+X-B+Z-A+X-A+Y-A+X-A+X-A+X-A+Y-B+Z-A+Z-B+X-C+Y-C+X-C+X-C+X-B+Z-B+Z-B+Z-A+X-A+Y-A+Y-B+Z-C+X-A+Y-A+Y-A+Z-A+Y-A+Y-A+X-C+X-B+Z-B+Z-C+X-A+Y-A+Y-A+Y";

		private const char LineBreak = '-';
		private const char Space = '+';

		[Fact]
		public void Test1()
		{
			var plays = Text.Split(LineBreak);
			var totalScore = 0;

			foreach(var play in plays)
			{
				var s = play.Split(Space);

				var opponent = ConvertOpponent(s[0][0]);
				var me = ConvertMe(s[1][0]);

				totalScore += (int)me;

				if (opponent == me)
				{
					totalScore += 3;
				}
				else
				{
					switch(opponent)
					{
						case Hand.Rock:
							if (me == Hand.Paper)
							{
								totalScore += 6;
							}
							break;
						case Hand.Paper:
							if (me == Hand.Scissors)
							{
								totalScore += 6;
							}
							break;
						case Hand.Scissors:
							if (me == Hand.Rock)
							{
								totalScore += 6;
							}
							break;
					}
				}
			}

			var finalScore = totalScore;
		}

		[Fact]
		public void Test2()
		{
			var plays = Text.Split(LineBreak);
			var totalScore = 0;

			foreach (var play in plays)
			{
				var s = play.Split(Space);

				var opponent = ConvertOpponent(s[0][0]);

				switch(s[1][0])
				{
					case 'X': // loose
						totalScore += (int)Loose(opponent);
						break;
					case 'Y': // loose
						totalScore += 3;
						totalScore += (int)opponent;
						break;
					case 'Z': // win
						totalScore += 6;
						totalScore += (int)Win(opponent);
						break;
				}
			}

			var finalScore = totalScore;
		}

		private Hand ConvertOpponent(char value)
		{
			switch (value)
			{
				case 'A':
					return Hand.Rock;
				case 'B':
					return Hand.Paper;
				case 'C':
					return Hand.Scissors;
				default:
					throw new NotImplementedException();
			}
		}

		private Hand ConvertMe(char value)
		{
			switch (value)
			{
				case 'X':
					return Hand.Rock;
				case 'Y':
					return Hand.Paper;
				case 'Z':
					return Hand.Scissors;
				default:
					throw new NotImplementedException();
			}
		}

		private Hand Loose(Hand opponent)
		{
			switch (opponent)
			{
				case Hand.Rock:
					return (Hand)(int)CounterLoose.Rock;
				case Hand.Paper:
					return (Hand)(int)CounterLoose.Paper;
				case Hand.Scissors:
					return (Hand)(int)CounterLoose.Scissors;
				default:
					throw new NotImplementedException();
			}
		}

		private Hand Win(Hand opponent)
		{
			switch (opponent)
			{
				case Hand.Rock:
					return (Hand)(int)CounterWin.Rock;
				case Hand.Paper:
					return (Hand)(int)CounterWin.Paper;
				case Hand.Scissors:
					return (Hand)(int)CounterWin.Scissors;
				default:
					throw new NotImplementedException();
			}
		}
	}
}