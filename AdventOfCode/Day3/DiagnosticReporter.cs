using System;
using System.Collections.Generic;
using System.Linq;

namespace Day3
{
	public class DiagnosticReporter : IDiagnosticReporter
	{
		private const uint BitCompareMask = 0b1000_0000_0000_0000_0000_0000_0000_0000;

		public int LineCount => _binaryLines.Count;

		private readonly IList<uint> _binaryLines = new List<uint>();
		private readonly uint _bitMask;

		public DiagnosticReporter(uint bitMask = uint.MaxValue)
		{
			_bitMask = bitMask;
		}

		public void InsertBinaryLine(uint binaryValue)
		{
			_binaryLines.Add(binaryValue);
		}

		public void InsertBinaryLines(params uint[] binaryValue)
		{
			_binaryLines.AddRange(binaryValue);
		}

		public bool GetLeastCommonBitOnIndex(int bitIndex)
		{
			if ((_bitMask << bitIndex) < BitCompareMask)
			{
				return false;
			}

			var (z, o) = CountBitsOnIndex(bitIndex);
			return o < z; 
		}

		public bool GetMostCommonBitOnIndex(int bitIndex)
		{
			if ((_bitMask << bitIndex) < BitCompareMask)
			{
				return false;
			}

			var (z, o) = CountBitsOnIndex(bitIndex);
			return o > z;
		}

		public uint GetEpsilonRate()
		{
			uint result = 0;

			for (var i = 0; i < 32; i ++)
			{
				result = (result << 1) + (uint)(GetLeastCommonBitOnIndex(i) ? 1 : 0);
			}

			return result;
		}

		public uint GetGammaRate()
		{
			uint result = 0;

			for (var i = 0; i < 32; i++)
			{
				result = (result << 1) + (uint)(GetMostCommonBitOnIndex(i) ? 1 : 0);
			}

			return result;
		}

		public uint GetOxygenGeneratorRating()
		{
			var filteredBitData = _binaryLines.Copy();
			var index = 0;

			while ((_bitMask << index) < BitCompareMask) { index++; }

			while(filteredBitData.Count > 1)
			{
				var (z, o) = CountBitsOnIndex(filteredBitData, index);
				var bitFilter = o >= z;

				filteredBitData = filteredBitData.Where(f => GetBitValueOnIndex(f, index) == bitFilter).ToList();

				index++;
			}

			return filteredBitData.Single();
		}

		public uint GetCO2ScrubberRating()
		{
			var filteredBitData = _binaryLines.Copy();
			var index = 0;

			while ((_bitMask << index) < BitCompareMask) { index++; }

			while (filteredBitData.Count > 1)
			{
				var (z, o) = CountBitsOnIndex(filteredBitData, index);
				var bitFilter = o == z ? false : o < z;

				filteredBitData = filteredBitData.Where(f => GetBitValueOnIndex(f, index) == bitFilter).ToList();

				index++;
			}

			return filteredBitData.Single();
		}


		private (int zeroCount, int oneCount) CountBitsOnIndex(int index)
		{
			return CountBitsOnIndex(_binaryLines, index);
		}

		private static (int zeroCount, int oneCount) CountBitsOnIndex(IList<uint> binaryLines, int index)
		{
			var zero = 0;
			var one = 0;

			foreach (var bits in binaryLines)
			{
				if (GetBitValueOnIndex(bits, index))
				{
					one++;
				}
				else
				{
					zero++;
				}
			}

			return (zero, one);
		}

		private static bool GetBitValueOnIndex(uint bitValue, int index)
		{
			return (bitValue << index) >= BitCompareMask;
		}
	}
}