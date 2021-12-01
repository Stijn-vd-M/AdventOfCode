using Day1;
using FluentAssertions;
using Xunit;

namespace Day1Tests
{
	public class SonarTests
	{
		private readonly ISonar _sonar;

		public SonarTests()
		{
			_sonar = new Sonar();
		}

		[Theory]
		[InlineData(0)]
		[InlineData(1)]
		[InlineData(2)]
		[InlineData(3)]
		[InlineData(4)]
		[InlineData(5)]
		[InlineData(10)]
		[InlineData(346)]
		[InlineData(999)]
		public void When_AddDepthMeasurement_Is_Called_Multiple_Times_Then_DepthMeasurementCount_Should_Be_That_Many_Times(int times)
		{
			// Assign

			// Act
			for (var i = 0; i < times; i ++)
			{
				_sonar.AddDepthMeasurement(1);
			}

			// Assert
			_sonar.DepthMeasurementCount.Should().Be(times);
		}

		[Fact]
		public void When_GetTotalDepthIncreases_Is_Called_Without_Precious_AddDepthMeasurement_Call_Then_Should_Return_0()
		{
			// Act
			var result = _sonar.GetTotalDepthIncreases();

			// Assert
			result.Should().Be(0);
		}

		[Fact]
		public void When_AddDepthMeasurement_Is_Called_After_3_Calls_To_AddDepthMeasurement_Then_GetTotalDepthIncreases_Should_Return_0()
		{
			// Assign

			// Act
			_sonar.AddDepthMeasurement(1);
			_sonar.AddDepthMeasurement(2);
			_sonar.AddDepthMeasurement(3);

			var result = _sonar.GetTotalDepthIncreases();

			// Assert
			result.Should().Be(0);
		}

		[Theory]
		[InlineData(1, 2, 3, 4)]
		[InlineData(0, 0, 0, 1)]
		[InlineData(1, 8, 6, 3)]
		public void When_AddDepthMeasurement_Is_Called_After_4_Calls_To_AddDepthMeasurement_With_Different_Depths_Then_GetTotalDepthIncreases_Should_Return_1(int a, int b, int c, int d)
		{
			// Assign

			// Act
			_sonar.AddDepthMeasurement(a);
			_sonar.AddDepthMeasurement(b);
			_sonar.AddDepthMeasurement(c);
			_sonar.AddDepthMeasurement(d);

			var result = _sonar.GetTotalDepthIncreases();

			// Assert
			result.Should().Be(1);
		}

		[Fact]
		public void When_AddDepthMeasurement_Is_Called_With_AdventExampleSet_Then_GetTotalDepthIncreases_Should_Result_5()
		{
			// Assign

			// Act
			_sonar.AddDepthMeasurement(199);
			_sonar.AddDepthMeasurement(200);
			_sonar.AddDepthMeasurement(208);
			_sonar.AddDepthMeasurement(210);
			_sonar.AddDepthMeasurement(200);
			_sonar.AddDepthMeasurement(207);
			_sonar.AddDepthMeasurement(240);
			_sonar.AddDepthMeasurement(269);
			_sonar.AddDepthMeasurement(260);
			_sonar.AddDepthMeasurement(263);

			var result = _sonar.GetTotalDepthIncreases();

			// Assert
			result.Should().Be(5);
		}
	}
}