using System.Collections.Generic;

namespace NumberToWord.Objects
{
  public class NumberConverter
  {
    private int _number;
    private Dictionary<int, string> _ones = new Dictionary<int, string>
      {
        {0,"zero"}, {1,"one"}, {2,"two"}, {3,"three"}, {4,"four"}, {5,"five"}, {6, "six"}, {7,"seven"}, {8,"eight"}, {9, "nine"}
      };

    public NumberConverter(int number)
    {
      _number = number;
    }

    public string Convert()
    {
      return _ones[_number];
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
