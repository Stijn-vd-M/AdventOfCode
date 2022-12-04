using System;

namespace Day8
{
	[Flags]
	public enum DigitEnum
	{
		Unkown = 0,
		A = 1,
		B = 2,
		C = 4,
		D = 8,
		E = 16,
		F = 32,
		G = 64,
		Zero =  A | B | C | E | F | G,
		One =   C | F,
		Two =   A | C | D | E | G,
		Three = A | C | D | F | G,
		Four =  B | C | D | F,
		Five =  A | B | D | F | G,
		Six =   A | B | D | E | F | G,
		Seven = A | C | F,
		Eight = A | B | C | D | E | F | G,
		Nine =  A | B | C | D | F | G
	}

	public static class DigitEnumExtensions
	{
		public static char AsLetter(this DigitEnum digit)
		{
			switch (digit)
			{
				case DigitEnum.A:
					return 'A';
				case DigitEnum.B:
					return 'B';
				case DigitEnum.C:
					return 'C';
				case DigitEnum.D:
					return 'D';
				case DigitEnum.E:
					return 'E';
				case DigitEnum.F:
					return 'F';
				case DigitEnum.G:
					return 'G';
				default:
					return '?';
			}
		}
	}
}