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
    public void Convert_Number1to10_Eight()
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
  }
}
