using Day2;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace Day2Tests
{
	public class Navigator2Tests
	{
		private INavigator2 _navigator;

		public Navigator2Tests()
		{
			_navigator = new Navigator2();
		}

		[Fact]
		public void When_No_Calls_To_AddCommand_Then_Properties_Should_Be_0()
		{
			// Assign

			// Act

			// Assert
			_navigator.HorizontalPosition.Should().Be(0);
			_navigator.Depth.Should().Be(0);
			_navigator.Aim.Should().Be(0);
		}

		[Fact]
		public void When_Calling_GetTotalDistance_Without_Calling_AddCommand_Then_TotalDistance_Should_Be_0()
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
		public void When_Calling_AddCommand_With_ForwardDirection_Then_HorizontalPosition_Should_Be_As_Expected_Depth_And_Aim_Should_Stay_0(int expected)
		{
			// Assign

			// Act
			_navigator.AddCommand(NavigationCommand.forward, expected);

			// Assert
			_navigator.HorizontalPosition.Should().Be(expected);
			_navigator.Depth.Should().Be(0);
			_navigator.Aim.Should().Be(0);
		}

		[Theory]
		[InlineData(0, 0)]
		[InlineData(1, 1)]
		[InlineData(5, 5)]
		[InlineData(10, 10)]
		[InlineData(42, 42)]
		public void When_Calling_AddCommand_With_DownDirection_Then_Aim_Should_Be_As_Expected_And_HorizontalPosition_And_Depth_Should_Stay_0(int input, int expected)
		{
			// Assign

			// Act
			_navigator.AddCommand(NavigationCommand.down, input);

			// Assert
			_navigator.Aim.Should().Be(expected);
			_navigator.HorizontalPosition.Should().Be(0);
			_navigator.Depth.Should().Be(0);
		}

		[Theory]
		[InlineData(0, 0)]
		[InlineData(1, -1)]
		[InlineData(5, -5)]
		[InlineData(10, -10)]
		[InlineData(42, -42)]
		public void When_Calling_AddCommand_With_UpDirection_Then_Aim_Should_Be_As_Expected_And_HorizontalPosition_And_Depth_Should_Stay_0(int input, int expected)
		{
			// Assign

			// Act
			_navigator.AddCommand(NavigationCommand.up, input);

			// Assert
			_navigator.Aim.Should().Be(expected);
			_navigator.HorizontalPosition.Should().Be(0);
			_navigator.Depth.Should().Be(0);
		}

		[Fact]
		public void When_Calling_AddCommand_With_ExampleData_Then_GetTotalDistance_Should_Return_900()
		{
			// Assign
			var exampleData = new List<(NavigationCommand, int)>
			{
				(NavigationCommand.forward, 5),
				(NavigationCommand.down, 5),
				(NavigationCommand.forward, 8),
				(NavigationCommand.up, 3),
				(NavigationCommand.down, 8),
				(NavigationCommand.forward, 2)
			};

			// Act
			foreach(var (direction, distance) in exampleData)
			{
				_navigator.AddCommand(direction, distance);
			}

			var result = _navigator.GetTotalDistance();

			// Assert
			result.Should().Be(900);
		}
	}
}