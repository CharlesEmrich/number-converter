using Xunit;
using NumberToWord.Objects;

namespace NumberToWord
{
  public class NumberToWordTest
  {
    [Fact]
    public void Convert_NumberZero_Zero()
    {
      //arrange
      int testNumber = 0;
      NumberConverter test = new NumberConverter(testNumber);
      string expectedOutput = "zero";
      //act
      string output = test.Convert();
      //assert
      Assert.Equal(expectedOutput, output);
    }

    [Fact]
    public void Convert_Number1to9_Eight()
    {
      //arrange
      int testNumber = 8;
      NumberConverter test = new NumberConverter(testNumber);
      string expectedOutput = "eight";
      //act
      string output = test.Convert();
      //assert
      Assert.Equal(expectedOutput, output);
    }

    [Fact]
    public void Convert_Number10to19_Fourteen()
    {
      //arrange
      int testNumber = 14;
      NumberConverter test = new NumberConverter(testNumber);
      string expectedOutput = "fourteen";
      //act
      string output = test.Convert();
      //assert
      Assert.Equal(expectedOutput, output);
    }

    [Fact]
    public void Convert_Number20to99_SeventySix()
    {
      //arrange
      int testNumber = 76;
      NumberConverter test = new NumberConverter(testNumber);
      string expectedOutput = "seventy six";
      //act
      string output = test.Convert();
      //assert
      Assert.Equal(expectedOutput, output);
    }

    [Fact]
    public void Convert_Number100to999WithoutTensOrOnes_EightHundred()
    {
      //arrange
      int testNumber = 800;
      NumberConverter test = new NumberConverter(testNumber);
      string expectedOutput = "eight hundred";
      //act
      string output = test.Convert();
      //assert
      Assert.Equal(expectedOutput, output);
    }

    [Fact]
    public void Convert_Number100to999WithATeen_SevenHundredFifteen()
    {
      //arrange
      int testNumber = 715;
      NumberConverter test = new NumberConverter(testNumber);
      string expectedOutput = "seven hundred fifteen";
      //act
      string output = test.Convert();
      //assert
      Assert.Equal(expectedOutput, output);
    }

    [Fact]
    public void Convert_Number100to999_SevenHundredSixtyFive()
    {
      //arrange
      int testNumber = 765;
      NumberConverter test = new NumberConverter(testNumber);
      string expectedOutput = "seven hundred sixty five";
      //act
      string output = test.Convert();
      //assert
      Assert.Equal(expectedOutput, output);
    }

    [Fact]
    public void Convert_Number1000to9999WithoutHundredsOrTensOrOnes_EightTHousand()
    {
      //arrange
      int testNumber = 8000;
      NumberConverter test = new NumberConverter(testNumber);
      string expectedOutput = "eight thousand";
      //act
      string output = test.Convert();
      //assert
      Assert.Equal(expectedOutput, output);
    }

    [Fact]
    public void Convert_Number1000to9999WithATeen_SevenThousandFifteen()
    {
      //arrange
      int testNumber = 7015;
      NumberConverter test = new NumberConverter(testNumber);
      string expectedOutput = "seven thousand fifteen";
      //act
      string output = test.Convert();
      //assert
      Assert.Equal(expectedOutput, output);
    }

    [Fact]
    public void Convert_Number1000to9999_SevenThousandThreeHundredSixtyFive()
    {
      //arrange
      int testNumber = 7365;
      NumberConverter test = new NumberConverter(testNumber);
      string expectedOutput = "seven thousand three hundred sixty five";
      //act
      string output = test.Convert();
      //assert
      Assert.Equal(expectedOutput, output);
    }
  }
}
