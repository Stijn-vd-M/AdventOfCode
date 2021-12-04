using FluentAssertions;
using System.Linq;
using Xunit;

namespace Day4Tests
{
	public class BingoCardTests
	{
		public BingoCardTests()
		{
		}

		[Fact]
		public void Calling_CheckNumber_With_NonBingoState_Should_All_Result_In_False()
		{
			// Assign
			var bingoCard = new BingoCardBuilder().WithStandardValues().Build();
			var nonBingoValues = new int[] { 1,2,3,4, 6,7,8,10, 11,12,14,15, 16,18,19,20, 22,23,24,25, 0, -1, 99};

			// Act
			var result = nonBingoValues.Select(v => bingoCard.CheckNumber(v)).ToArray();

			// Assert
			result.Should().AllBeEquivalentTo(false);
		}

		[Theory]
		[InlineData(1, 2, 3, 4, 5)]
		[InlineData(6, 7, 8, 9, 10)]
		[InlineData(11, 12, 13, 14, 15)]
		[InlineData(16, 17, 18, 19, 20)]
		[InlineData(21, 22, 23, 24, 25)]

		[InlineData(1, 6, 11, 16, 21)]
		[InlineData(2, 7, 12, 17, 22)]
		[InlineData(3, 8, 13, 18, 23)]
		[InlineData(4, 9, 14, 19, 24)]
		[InlineData(5, 10, 15, 20, 25)]
		public void Calling_CheckNumber_With_BingoState_Should_Finally_Result_In_True(params int[] values)
		{
			// Assign
			var bingoCard = new BingoCardBuilder().WithStandardValues().Build();

			// Act
			var result = values.Select(v => bingoCard.CheckNumber(v)).ToArray();

			// Assert
			result[0].Should().BeFalse();
			result[1].Should().BeFalse();
			result[2].Should().BeFalse();
			result[3].Should().BeFalse();
			result[4].Should().BeTrue();
		}
	}
}
