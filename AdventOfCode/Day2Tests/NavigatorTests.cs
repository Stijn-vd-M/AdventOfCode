using Day2;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace Day2Tests
{
	public class NavigatorTests
	{
		private INavigator _navigator;

		public NavigatorTests()
		{
			_navigator = new Navigator();
		}

		[Fact]
		public void When_No_Calls_To_AddVector_Then_Properties_Should_Be_0()
		{
			// Assign

			// Act

			// Assert
			_navigator.HorizontalPosition.Should().Be(0);
			_navigator.Depth.Should().Be(0);
		}

		[Fact]
		public void When_Calling_GetTotalDistance_Without_Calling_AddVector_Then_TotalDistance_Should_Be_0()
		{
			// Assign

			// Act
			var totalDistance = _navigator.GetTotalDistance();

			// Assert
			totalDistance.Should().Be(0);
		}

		[Theory]
		[InlineData(0)]
		[InlineData(1)]
		[InlineData(5)]
		[InlineData(10)]
		[InlineData(42)]
		public void When_Calling_AddVector_With_ForwardDirection_Then_HorizontalPosition_Should_Be_As_Expected_And_Depth_Should_Stay_0(int expected)
		{
			// Assign

			// Act
			_navigator.AddVector(Direction.forward, expected);

			// Assert
			_navigator.HorizontalPosition.Should().Be(expected);
			_navigator.Depth.Should().Be(0);
		}

		[Theory]
		[InlineData(0, 0)]
		[InlineData(1, 1)]
		[InlineData(5, 5)]
		[InlineData(10, 10)]
		[InlineData(42, 42)]
		public void When_Calling_AddVector_With_DownDirection_Then_Depth_Should_Be_As_Expected_And_HorizontalPosition_Should_Stay_0(int input, int expected)
		{
			// Assign

			// Act
			_navigator.AddVector(Direction.down, input);

			// Assert
			_navigator.Depth.Should().Be(expected);
			_navigator.HorizontalPosition.Should().Be(0);
		}

		[Theory]
		[InlineData(0, 0)]
		[InlineData(1, -1)]
		[InlineData(5, -5)]
		[InlineData(10, -10)]
		[InlineData(42, -42)]
		public void When_Calling_AddVector_With_UpDirection_Then_Depth_Should_Be_As_Expected_And_HorizontalPosition_Should_Stay_0(int input, int expected)
		{
			// Assign

			// Act
			_navigator.AddVector(Direction.up, input);

			// Assert
			_navigator.Depth.Should().Be(expected);
			_navigator.HorizontalPosition.Should().Be(0);
		}

		[Theory]
		[InlineData(0, 0, 0, 0)]
		[InlineData(1, 0, 0, 0)]
		[InlineData(0, 1, 0, 0)]
		[InlineData(0, 0, 1, 0)]
		[InlineData(1, 0, 1, 1)]
		[InlineData(1, 1, 0, -1)]
		[InlineData(1, 1, 1, 0)]
		[InlineData(3, 0, 3, 9)]
		[InlineData(3, 3, 0, -9)]
		[InlineData(3, 3, 3, 0)]
		[InlineData(3, 1, 3, 6)]
		public void When_Calling_AddVector_With_Different_Combinations_Then_GetTotalDistance_Should_Return_Expected(int forward, int up, int down, int expected)
		{
			// Assign

			// Act
			_navigator.AddVector(Direction.forward, forward);
			_navigator.AddVector(Direction.up, up);
			_navigator.AddVector(Direction.down, down);


			var result = _navigator.GetTotalDistance();

			// Assert
			result.Should().Be(expected);
		}


		[Fact]
		public void When_Calling_AddVector_With_ExampleData_Then_GetTotalDistance_Should_Return_150()
		{
			// Assign
			var exampleData = new List<(Direction, int)>
			{
				(Direction.forward, 5),
				(Direction.down, 5),
				(Direction.forward, 8),
				(Direction.up, 3),
				(Direction.down, 8),
				(Direction.forward, 2)
			};

			// Act
			foreach(var (direction, distance) in exampleData)
			{
				_navigator.AddVector(direction, distance);
			}

			var result = _navigator.GetTotalDistance();

			// Assert
			result.Should().Be(150);
		}
	}
}