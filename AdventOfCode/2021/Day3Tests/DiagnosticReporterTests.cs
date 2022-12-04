using Day3;
using FluentAssertions;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace Day3Tests
{
	public class DiagnosticReporterTests
	{
		private readonly IDiagnosticReporter _diagnosticReporter;

		public DiagnosticReporterTests()
		{
			_diagnosticReporter = new DiagnosticReporter();
		}

		[Theory]
		[InlineData(0)]
		[InlineData(1)]
		[InlineData(2)]
		[InlineData(5)]
		[InlineData(10)]
		[InlineData(999)]
		public void Calling_InsertBinaryLine_Should_Increase_LineCount(int calls)
		{
			// Assign
			var originalCount = _diagnosticReporter.LineCount;

			// Act
			for (var i = 0; i < calls; i++)
			{
				_diagnosticReporter.InsertBinaryLine(0b0000);
			}

			// Assert
			originalCount.Should().Be(0);
			_diagnosticReporter.LineCount.Should().Be(calls);

		}

		[Theory]
		[InlineData(0)]
		[InlineData(1)]
		[InlineData(2)]
		[InlineData(5)]
		[InlineData(10)]
		[InlineData(999)]
		public void Calling_InsertBinaryLines_Should_Increase_LineCount(int calls)
		{
			// Assign
			var originalCount = _diagnosticReporter.LineCount;
			var lines = new List<uint>();

			// Act
			for (var i = 0; i < calls; i++)
			{
				lines.Add(0b0000);
			}

			_diagnosticReporter.InsertBinaryLines(lines.ToArray());

			// Assert
			originalCount.Should().Be(0);
			_diagnosticReporter.LineCount.Should().Be(calls);

		}

		[Theory]
		[InlineData(0, true)]
		[InlineData(1, false)]
		[InlineData(2, true)]
		[InlineData(3, false)]
		[InlineData(4, true)]
		[InlineData(5, false)]
		public void Calling_GetMostCommonBitOnIndex_Should_Return_Expected_BitValue(int index, bool bitValue)
		{
			// Assign
			_diagnosticReporter.InsertBinaryLines(
				0b1010_1000_0000_0000_0000_0000_0000_0000,
				0b1001_1000_0000_0000_0000_0000_0000_0000,
				0b1010_1000_0000_0000_0000_0000_0000_0000,
				0b1001_1000_0000_0000_0000_0000_0000_0000,
				0b1010_0100_0000_0000_0000_0000_0000_0000,
				0b1001_0100_0000_0000_0000_0000_0000_0000,
				0b1010_0100_0000_0000_0000_0000_0000_0000);

			// Act
			var result = _diagnosticReporter.GetMostCommonBitOnIndex(index);

			// Assert
			result.Should().Be(bitValue);
		}

		[Theory]
		[InlineData(0, false)]
		[InlineData(1, true)]
		[InlineData(2, false)]
		[InlineData(3, true)]
		[InlineData(4, false)]
		[InlineData(5, true)]
		public void Calling_GetLeastCommonBitOnIndex_Should_Return_Expected_BitValue(int index, bool bitValue)
		{
			// Assign
			_diagnosticReporter.InsertBinaryLines(
				0b1010_1000_0000_0000_0000_0000_0000_0000,
				0b1001_1000_0000_0000_0000_0000_0000_0000,
				0b1010_1000_0000_0000_0000_0000_0000_0000,
				0b1001_1000_0000_0000_0000_0000_0000_0000,
				0b1010_0100_0000_0000_0000_0000_0000_0000,
				0b1001_0100_0000_0000_0000_0000_0000_0000,
				0b1010_0100_0000_0000_0000_0000_0000_0000);

			// Act
			var result = _diagnosticReporter.GetLeastCommonBitOnIndex(index);

			// Assert
			result.Should().Be(bitValue);
		}

		[Fact]
		public void Calling_GetGammaRate_After_Calling_InsertBinaryLines_Results_In_Expected_Value()
		{
			// Assign
			var diagnosticReporter = new DiagnosticReporter(0b0000_0000_0000_0000_0000_0000_0001_1111);
			diagnosticReporter.InsertBinaryLines(
				0b11111,
				0b11111,
				0b00000);

			// Act
			var result = diagnosticReporter.GetGammaRate();

			// Assert
			result.Should().Be(0b11111);
		}

		[Fact]
		public void Calling_GetEpsilonRate_After_Calling_InsertBinaryLines_Results_In_Expected_Value()
		{
			// Assign
			var diagnosticReporter = new DiagnosticReporter(0b0000_0000_0000_0000_0000_0000_0001_1111);
			diagnosticReporter.InsertBinaryLines(
				0b11111,
				0b11111,
				0b00000);

			// Act
			var result = diagnosticReporter.GetEpsilonRate();

			// Assert
			result.Should().Be(0b00000);
		}

		[Fact]
		public void Calling_GetGammaRate_With_ExampleData_Results_In_22()
		{
			// Assign
			var diagnosticReporter = new DiagnosticReporter(0b0000_0000_0000_0000_0000_0000_0001_1111);
			diagnosticReporter.InsertBinaryLines(
				0b00100,
				0b11110,
				0b10110,
				0b10111,
				0b10101,
				0b01111,
				0b00111,
				0b11100,
				0b10000,
				0b11001,
				0b00010,
				0b01010);

			// Act
			var result = diagnosticReporter.GetGammaRate();

			// Assert
			result.Should().Be(22);
		}

		[Fact]
		public void Calling_GetEpsilonRate_With_ExampleData_Results_In_9()
		{
			// Assign
			var diagnosticReporter = new DiagnosticReporter(0b0000_0000_0000_0000_0000_0000_0001_1111);
			diagnosticReporter.InsertBinaryLines(
				0b00100,
				0b11110,
				0b10110,
				0b10111,
				0b10101,
				0b01111,
				0b00111,
				0b11100,
				0b10000,
				0b11001,
				0b00010,
				0b01010);

			// Act
			var result = diagnosticReporter.GetEpsilonRate();

			// Assert
			result.Should().Be(9);
		}

		[Fact]
		public void Calling_GetOxygenGeneratorRating_With_ExampleData_Results_In_23()
		{
			// Assign
			var diagnosticReporter = new DiagnosticReporter(0b0000_0000_0000_0000_0000_0000_0001_1111);
			diagnosticReporter.InsertBinaryLines(
				0b00100,
				0b11110,
				0b10110,
				0b10111,
				0b10101,
				0b01111,
				0b00111,
				0b11100,
				0b10000,
				0b11001,
				0b00010,
				0b01010);

			// Act
			var result = diagnosticReporter.GetOxygenGeneratorRating();

			// Assert
			result.Should().Be(23);
		}

		[Fact]
		public void Calling_GetCO2ScrubberRating_With_ExampleData_Results_In_23()
		{
			// Assign
			var diagnosticReporter = new DiagnosticReporter(0b0000_0000_0000_0000_0000_0000_0001_1111);
			diagnosticReporter.InsertBinaryLines(
				0b00100,
				0b11110,
				0b10110,
				0b10111,
				0b10101,
				0b01111,
				0b00111,
				0b11100,
				0b10000,
				0b11001,
				0b00010,
				0b01010);

			// Act
			var result = diagnosticReporter.GetCO2ScrubberRating();

			// Assert
			result.Should().Be(10);
		}
	}
}