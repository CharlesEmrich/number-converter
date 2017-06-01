using Xunit;
using NumberToWord.Objects;

namespace NumberToWord
{
  public class NumberToWordTest
  {
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
