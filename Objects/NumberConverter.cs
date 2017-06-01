using System.Collections.Generic;

namespace NumberToWord.Objects
{
  public class NumberConverter
  {
    private int _number;
    private Dictionary<int, string> _ones = new Dictionary<int, string>
      {

      };

    public NumberConverter(int number)
    {
      _number = number;
    }

    public string Convert()
    {
      return "ugh";
    }

    public int GetNumber()
    {
      return _number;
    }
    public void SetNumber(int number)
    {
      _number = number;
    }
  }
}
