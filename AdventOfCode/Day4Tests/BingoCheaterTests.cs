using Day4;
using FluentAssertions;
using Moq;
using Xunit;

namespace Day4Tests
{
	public class BingoCheaterTests
	{
		private readonly IBingoCheater _bingoCheater;

		public BingoCheaterTests()
		{
			_bingoCheater = new BingoCheater();
		}

		[Theory]
		[InlineData(0)]
		[InlineData(1)]
		[InlineData(2)]
		[InlineData(5)]
		[InlineData(10)]
		[InlineData(999)]
		public void After_Calling_AddCard_Several_Times_Then_AmountOfCards_Should_Be_Increase(int times)
		{
			// Assign

			// Act
			for (var i = 0; i < times; i++)
			{
				_bingoCheater.AddCard(new Mock<IBingoCard>().Object);
			}

			// Assert
			_bingoCheater.AmountOfCards.Should().Be(times);
		}

		[Theory]
		[InlineData(new int[0])]
		[InlineData(1)]
		[InlineData(1, 2)]
		[InlineData(1, 2, 1)]
		[InlineData(1, 123, 560, 42)]
		public void Calling_CallNumbers_With_NonBingo_Value_Should_Return_MinusOne(params int[] numbers)
		{
			// Assign
			var card = new Mock<IBingoCard>();
			card.Setup(c => c.CheckNumber(It.IsAny<int>())).Returns(false);
			card.Setup(c => c.GetSumOfUnmarkedNumbers()).Throws(new System.Exception("Should not call this!"));

			_bingoCheater.AddCard(card.Object);

			// Act
			var result = _bingoCheater.CallNumbers(numbers);

			// Assert
			result.Should().Be(-1);
		}

		[Theory]
		[InlineData(42)]
		[InlineData(1, 42)]
		[InlineData(1, 2, 42)]
		[InlineData(1, 2, 1, 42)]
		[InlineData(1, 123, 560, 42)]
		public void Calling_CallNumbers_With_Bingo_Value_Should_Call_And_Return_SumOfUnMarkedNumbers(params int[] numbers)
		{
			// Assign
			var GetSumOfUnmarkedNumbersCalled = false;
			var card1 = new Mock<IBingoCard>();
			card1.Setup(c => c.CheckNumber(It.IsAny<int>())).Returns(false);
			card1.Setup(c => c.GetSumOfUnmarkedNumbers()).Throws(new System.Exception("Should not call this!"));

			var card2 = new Mock<IBingoCard>();
			card2.Setup(c => c.CheckNumber(It.IsAny<int>())).Returns(false);
			card2.Setup(c => c.CheckNumber(It.Is<int>(a => a == 42))).Returns(true);
			card2.Setup(c => c.GetSumOfUnmarkedNumbers()).Returns(10).Callback(() => GetSumOfUnmarkedNumbersCalled = true);

			_bingoCheater.AddCard(card1.Object);
			_bingoCheater.AddCard(card2.Object);

			// Act
			var result = _bingoCheater.CallNumbers(numbers);

			// Assert
			result.Should().Be(420);
			GetSumOfUnmarkedNumbersCalled.Should().BeTrue();
		}

		[Fact]
		public void Calling_CallNumbers_With_ExampleData_Should_Return_4512()
		{
			// Assign
			_bingoCheater.AddCard(new BingoCardBuilder(
					22, 13, 17, 11,  0,
					 8,  2, 23,  4, 24,
					21,  9, 14, 16,  7,
					 6, 10,  3, 18,  5,
					 1, 12, 20, 15, 19)
				.Build());
			_bingoCheater.AddCard(new BingoCardBuilder(
					 3, 15,  0,  2, 22,
					 9, 18, 13, 17,  5,
					19,  8,  7, 25, 23,
					20, 11, 10, 24,  4,
					14, 21, 16, 12,  6)
				.Build());
			_bingoCheater.AddCard(new BingoCardBuilder(
					14, 21, 17, 24,  4,
					10, 16, 15,  9, 19,
					18,  8, 23, 26, 20,
					22, 11, 13,  6,  5,
					 2,  0, 12,  3,  7)
				.Build());

			var sequence = new int[] { 7, 4, 9, 5, 11, 17, 23, 2, 0, 14, 21, 24, 10, 16, 13, 6, 15, 25, 12, 22, 18, 20, 8, 19, 3, 26, 1 };

			// Act
			var result = _bingoCheater.CallNumbers(sequence);

			// Assert
			result.Should().Be(4512);
		}

		[Fact]
		public void Calling_GetLastWinner_With_ExampleData_Should_Return_1924()
		{
			// Assign
			_bingoCheater.AddCard(new BingoCardBuilder(
					22, 13, 17, 11, 0,
					 8, 2, 23, 4, 24,
					21, 9, 14, 16, 7,
					 6, 10, 3, 18, 5,
					 1, 12, 20, 15, 19)
				.Build());
			_bingoCheater.AddCard(new BingoCardBuilder(
					 3, 15, 0, 2, 22,
					 9, 18, 13, 17, 5,
					19, 8, 7, 25, 23,
					20, 11, 10, 24, 4,
					14, 21, 16, 12, 6)
				.Build());
			_bingoCheater.AddCard(new BingoCardBuilder(
					14, 21, 17, 24, 4,
					10, 16, 15, 9, 19,
					18, 8, 23, 26, 20,
					22, 11, 13, 6, 5,
					 2, 0, 12, 3, 7)
				.Build());

			var sequence = new int[] { 7, 4, 9, 5, 11, 17, 23, 2, 0, 14, 21, 24, 10, 16, 13, 6, 15, 25, 12, 22, 18, 20, 8, 19, 3, 26, 1 };

			// Act
			var result = _bingoCheater.GetLastWinner(sequence);

			// Assert
			result.Should().Be(1924);
		}
	}
}