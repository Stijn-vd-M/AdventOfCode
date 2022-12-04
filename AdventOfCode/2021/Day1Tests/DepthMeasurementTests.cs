using Day1;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Day1Tests
{
	public class DepthMeasurementTests
	{
		[Fact]
		public void When_Creating_DepthMeasurement_Then_IsValid_Should_Be_False()
		{
			// Assign

			// Act
			var record = new DepthMeasurement(1);

			// Assert
			record.IsValid.Should().BeFalse();
		}

		[Fact]
		public void When_Calling_Only_AddSecondMeasurement_Then_IsValid_Should_Be_False()
		{
			// Assign
			var record = new DepthMeasurement(1);

			// Act
			record.AddSecondMeasurement(2);

			// Assert
			record.IsValid.Should().BeFalse();
		}

		[Fact]
		public void When_Calling_Only_AddThirdMeasurement_Then_IsValid_Should_Be_False()
		{
			// Assign
			var record = new DepthMeasurement(1);

			// Act
			record.AddThirdMeasurement(3);

			// Assert
			record.IsValid.Should().BeFalse();
		}

		[Fact]
		public void When_Calling_AddSecondMeasurement_And_AddThirdMeasurement_Then_IsValid_Should_Be_True()
		{
			// Assign
			var recordA = new DepthMeasurement(1);
			var recordB = new DepthMeasurement(1);

			// Act
			recordA.AddSecondMeasurement(2);
			recordA.AddThirdMeasurement(3);

			recordB.AddThirdMeasurement(3);
			recordB.AddSecondMeasurement(2);

			// Assert
			recordA.IsValid.Should().BeTrue();
			recordB.IsValid.Should().BeTrue();
		}

		[Fact]
		public void When_Comparing_Invalid_DepthMeasurements_With_SmallerThen_Then_Result_Should_Be_False()
		{
			// Assign
			var recordA = new DepthMeasurement(1);
			var recordB = new DepthMeasurement(1);
			recordB.AddSecondMeasurement(2);
			var recordC = new DepthMeasurement(1);
			recordC.AddThirdMeasurement(3);
			var recordD = new DepthMeasurement(1);
			recordD.AddSecondMeasurement(2);
			recordD.AddThirdMeasurement(3);

			// Act
			var resultA1 = recordA < recordB;
			var resultA2 = recordA < recordC;
			var resultA3 = recordA < recordD;

			var resultB1 = recordB < recordA;
			var resultB2 = recordB < recordC;
			var resultB3 = recordB < recordD;

			var resultC1 = recordC < recordA;
			var resultC2 = recordC < recordB;
			var resultC3 = recordC < recordD;

			var resultD1 = recordD < recordA;
			var resultD2 = recordD < recordB;
			var resultD3 = recordD < recordC;

			// Assert
			resultA1.Should().BeFalse();
			resultA2.Should().BeFalse();
			resultA3.Should().BeFalse();

			resultB1.Should().BeFalse();
			resultB2.Should().BeFalse();
			resultB3.Should().BeFalse();

			resultC1.Should().BeFalse();
			resultC2.Should().BeFalse();
			resultC3.Should().BeFalse();

			resultD1.Should().BeFalse();
			resultD2.Should().BeFalse();
			resultD3.Should().BeFalse();
		}

		[Fact]
		public void When_Comparing_Invalid_DepthMeasurements_With_LargerThen_Then_Result_Should_Be_False()
		{
			// Assign
			var recordA = new DepthMeasurement(1);
			var recordB = new DepthMeasurement(1);
			recordB.AddSecondMeasurement(2);
			var recordC = new DepthMeasurement(1);
			recordC.AddThirdMeasurement(3);
			var recordD = new DepthMeasurement(1);
			recordD.AddSecondMeasurement(2);
			recordD.AddThirdMeasurement(3);

			// Act
			var resultA1 = recordA > recordB;
			var resultA2 = recordA > recordC;
			var resultA3 = recordA > recordD;

			var resultB1 = recordB > recordA;
			var resultB2 = recordB > recordC;
			var resultB3 = recordB > recordD;

			var resultC1 = recordC > recordA;
			var resultC2 = recordC > recordB;
			var resultC3 = recordC > recordD;

			var resultD1 = recordD > recordA;
			var resultD2 = recordD > recordB;
			var resultD3 = recordD > recordC;

			// Assert
			resultA1.Should().BeFalse();
			resultA2.Should().BeFalse();
			resultA3.Should().BeFalse();

			resultB1.Should().BeFalse();
			resultB2.Should().BeFalse();
			resultB3.Should().BeFalse();

			resultC1.Should().BeFalse();
			resultC2.Should().BeFalse();
			resultC3.Should().BeFalse();

			resultD1.Should().BeFalse();
			resultD2.Should().BeFalse();
			resultD3.Should().BeFalse();
		}

		[Theory]
		[InlineData(1, 2, true)]
		[InlineData(2, 1, false)]
		[InlineData(1, 1, false)]
		public void When_Comparing_Valid_DepthMeasurements_With_SmallerThen_Then_Result_Should_Be_As_Expected(int leftValue, int rightValue, bool expected)
		{
			// Assign
			var left = new DepthMeasurement(0);
			left.AddSecondMeasurement(0);
			left.AddThirdMeasurement(leftValue);
			var right = new DepthMeasurement(0);
			right.AddSecondMeasurement(0);
			right.AddThirdMeasurement(rightValue);

			// Act
			var result = left < right;


			// Assert
			result.Should().Be(expected);
		}

		[Theory]
		[InlineData(1, 2, false)]
		[InlineData(2, 1, true)]
		[InlineData(1, 1, false)]
		public void When_Comparing_Valid_DepthMeasurements_With_LargerThen_Then_Result_Should_Be_As_Expected(int leftValue, int rightValue, bool expected)
		{
			// Assign
			var left = new DepthMeasurement(0);
			left.AddSecondMeasurement(0);
			left.AddThirdMeasurement(leftValue);
			var right = new DepthMeasurement(0);
			right.AddSecondMeasurement(0);
			right.AddThirdMeasurement(rightValue);

			// Act
			var result = left > right;

			// Assert
			result.Should().Be(expected);
		}
	}
}