namespace Day8
{
	public class Wire
	{
		public char In { get; init; }
		public bool HasOutOptions => Possibilities != DigitEnum.Unkown;
		public char Out
		{
			get
			{
				switch (Possibilities)
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

		public DigitEnum Possibilities { get; private set; }

		public Wire(char @in)
		{
			In = @in;
			Possibilities = DigitEnum.Unkown;
		}

		public void AddPossibility(char possiblity)
		{
			switch(possiblity)
			{
				case 'A':
					Possibilities = Possibilities | DigitEnum.A;
					return;
				case 'B':
					Possibilities = Possibilities | DigitEnum.B;
					return;
				case 'C':
					Possibilities = Possibilities | DigitEnum.C;
					return;
				case 'D':
					Possibilities = Possibilities | DigitEnum.D;
					return;
				case 'E':
					Possibilities = Possibilities | DigitEnum.E;
					return;
				case 'F':
					Possibilities = Possibilities | DigitEnum.F;
					return;
				case 'G':
					Possibilities = Possibilities | DigitEnum.G;
					return;
			}
		}

		public void AddPossibilities(params char[] possibilities)
		{
			foreach(var p in possibilities)
			{
				AddPossibility(p);
			}
		}

		public void SetOut(char @out)
		{
			switch (@out)
			{
				case 'A':
					Possibilities = DigitEnum.A;
					return;
				case 'B':
					Possibilities = DigitEnum.B;
					return;
				case 'C':
					Possibilities = DigitEnum.C;
					return;
				case 'D':
					Possibilities = DigitEnum.D;
					return;
				case 'E':
					Possibilities = DigitEnum.E;
					return;
				case 'F':
					Possibilities = DigitEnum.F;
					return;
				case 'G':
					Possibilities = DigitEnum.G;
					return;
			}
		}
	}
}