using System;
using System.Collections.Generic;

namespace NumberToWord.Objects
{
  public class NumberConverter
  {
    private int _number;
    private Dictionary<char, string> _ones = new Dictionary<char, string>
      {
        {'0',""}, {'1',"one "}, {'2',"two "}, {'3',"three "}, {'4',"four "}, {'5',"five "}, {'6', "six "}, {'7',"seven "}, {'8',"eight "}, {'9', "nine "}
      };
    private Dictionary<char, string> _teens = new Dictionary<char, string>
      {
        {'0',"ten"}, {'1',"eleven"}, {'2',"twelve"}, {'3',"thirteen"}, {'4',"fourteen"}, {'5',"fifteen"}, {'6', "sixteen"}, {'7',"seventeen"}, {'8',"eighteen"}, {'9', "nineteen"}
      };
    private Dictionary<char, string> _tens = new Dictionary<char, string>
      {
        {'2',"twenty "}, {'3',"thirty "}, {'4',"forty "}, {'5',"fifty "}, {'6', "sixty "}, {'7',"seventy "}, {'8',"eighty "}, {'9', "ninety "}
      };
    private Dictionary<int, string> _baseTens = new Dictionary<int, string>
      {
        {0, "hundred "}, {1,"thousand "}, {2,"million "}, {3,"billion "}, {4,"trillion "}
      };
    public NumberConverter(int number)
    {
      _number = number;
    }

    public string Convert()
    {
      string numberString = "";
      char[] numberArray = _number.ToString().ToCharArray();
      bool isTeen = false;

      if (_number == 0)
      {
        return "zero";
      }
      else
      {
        for (int i = 0; i < numberArray.Length; i++) {
          if (numberArray.Length == 3) {
            if (i == 0)
            {
              numberString += _ones[numberArray[i]] + _baseTens[0];
            }
            else if (i == 1 && numberArray[i] == '1')
            {
              isTeen = true;
            }
            else if (i == 1 && numberArray[i] > '1')
            {
              numberString += _tens[numberArray[i]];
            }
            else if (i == 2)
            {
              if (isTeen)
              {
                numberString += _teens[numberArray[i]];
              } else {
                numberString += _ones[numberArray[i]];
              }
              isTeen = false;
            }
          }
          else if (numberArray.Length == 2)
          {
            if (i == 0 && numberArray[i] == '1')
            {
              isTeen = true;
            }
            else if (i == 0 && numberArray[i] > '1')
            {
              numberString += _tens[numberArray[i]];
            }
            else if (i == 1)
            {
              if (isTeen)
              {
                numberString += _teens[numberArray[i]];
              } else {
                numberString += _ones[numberArray[i]];
              }
              isTeen = false;
            }
          }
          else if (numberArray.Length == 1)
          {
            numberString += _ones[numberArray[i]];
          }
        }
      }
      return numberString.Trim();
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
