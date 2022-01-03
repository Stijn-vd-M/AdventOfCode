using System;
using System.Collections.Generic;
using System.Linq;

namespace Day8
{
	public class Digit
	{
		public Wire A { get; private set; }
		public Wire B { get; private set; }
		public Wire C { get; private set; }
		public Wire D { get; private set; }
		public Wire E { get; private set; }
		public Wire F { get; private set; }
		public Wire G { get; private set; }

		private IDictionary<int, char[]> _combos;

		public Digit()
		{
			A = new('A');
			B = new('B');
			C = new('C');
			D = new('D');
			E = new('E');
			F = new('F');
			G = new('G');

			_combos = new Dictionary<int, char[]>();
		}

		public void AddUniqueInputs(string[] inputs)
		{
			var dict = new Dictionary<char, int>();
			var inputsList = inputs.Select(i => i.ToCharArray()).ToArray();

			foreach(var chars in inputsList)
			{
				foreach(var c in chars)
				{
					if (dict.ContainsKey(c))
					{
						dict[c]++;
					}
					else
					{
						dict.Add(c, 1);
					}
				}
			}

			var one = inputsList.First(i => i.Length == 2);
			C.SetOut(dict[one[0]] == 8 ? one[0] : one[1]);
			F.SetOut(dict[one[0]] == 9 ? one[0] : one[1]);

			var seven = inputsList.First(i => i.Length == 3);
			A.SetOut(Filter(seven, C, F)[0]);

			var four = Filter(inputsList.First(i => i.Length == 4), C, F);
			B.SetOut(dict[four[0]] == 6 ? four[0] : four[1]);
			D.SetOut(dict[four[0]] == 7 ? four[0] : four[1]);

			var five = inputsList.First(i => i.Length == 5 && dict[Filter(i, A, B, D, F)[0]] == 7);
			G.SetOut(Filter(five, A, B, D, F)[0]);

			var two = inputsList.First(i => i.Length == 5 && dict[Filter(i, A, C, D, G)[0]] == 4);
			E.SetOut(Filter(two, A, C, D, G)[0]);
		}

		public int GetValue(string input)
		{
			var chars = input.ToCharArray();
			var result = DigitEnum.Unkown;

			foreach(var c in chars)
			{
				if (IsSameEndPoint(A.Possibilities, c))
				{
					result = result |= DigitEnum.A;
				}
				else if (IsSameEndPoint(B.Possibilities, c))
				{
					result = result |= DigitEnum.B;
				}
				else if (IsSameEndPoint(C.Possibilities, c))
				{
					result = result |= DigitEnum.C;
				}
				else if (IsSameEndPoint(D.Possibilities, c))
				{
					result = result |= DigitEnum.D;
				}
				else if (IsSameEndPoint(E.Possibilities, c))
				{
					result = result |= DigitEnum.E;
				}
				else if (IsSameEndPoint(F.Possibilities, c))
				{
					result = result |= DigitEnum.F;
				}
				else if (IsSameEndPoint(G.Possibilities, c))
				{
					result = result |= DigitEnum.G;
				}
			}

			switch(result)
			{
				case DigitEnum.Zero:
					return 0;
				case DigitEnum.One:
					return 1;
				case DigitEnum.Two:
					return 2;
				case DigitEnum.Three:
					return 3;
				case DigitEnum.Four:
					return 4;
				case DigitEnum.Five:
					return 5;
				case DigitEnum.Six:
					return 6;
				case DigitEnum.Seven:
					return 7;
				case DigitEnum.Eight:
					return 8;
				case DigitEnum.Nine:
					return 9;
				default:
					throw new Exception();
			}
		}

		private static bool IsSameEndPoint(DigitEnum endPoint, char option)
		{
			switch (option)
			{
				case 'A':
					return endPoint.HasFlag(DigitEnum.A);
				case 'B':
					return endPoint.HasFlag(DigitEnum.B);
				case 'C':
					return endPoint.HasFlag(DigitEnum.C);
				case 'D':
					return endPoint.HasFlag(DigitEnum.D);
				case 'E':
					return endPoint.HasFlag(DigitEnum.E);
				case 'F':
					return endPoint.HasFlag(DigitEnum.F);
				case 'G':
					return endPoint.HasFlag(DigitEnum.G);
				default:
					return false;
			}
		}

		private static bool ContainsSameEndPoint(DigitEnum endPoint, char[] options)
		{
			foreach(var option in options)
			{
				if (IsSameEndPoint(endPoint, option))
				{
					return true;
				}
			}

			return false;
		}

		private static char[] Filter(char[] chars, params Wire[] wires)
		{
			foreach(var wire in wires)
			{
				chars = Filter(chars, wire);
			}

			return chars;
		}

		private static char[] Filter(char[] chars, Wire wire)
		{
			return chars.Where(c => !IsSameEndPoint(wire.Possibilities, c)).ToArray();
		}
	}
}