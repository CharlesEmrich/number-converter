using System;
using System.Collections.Generic;

namespace NumberToWord.Objects
{
  public class NumberConverter
  {
    private int _number;
    private Dictionary<char, string> _ones = new Dictionary<char, string>
      {
        {'0',"zero"}, {'1',"one"}, {'2',"two"}, {'3',"three"}, {'4',"four"}, {'5',"five"}, {'6', "six"}, {'7',"seven"}, {'8',"eight"}, {'9', "nine"}
      };
    private Dictionary<char, string> _teens = new Dictionary<char, string>
      {
        {'0',"ten"}, {'1',"eleven"}, {'2',"twelve"}, {'3',"thirteen"}, {'4',"fourteen"}, {'5',"fifteen"}, {'6', "sixteen"}, {'7',"seventeen"}, {'8',"eighteen"}, {'9', "nineteen"}
      };
    private Dictionary<char, string> _tens = new Dictionary<char, string>
      {
        {'2',"twenty "}, {'3',"thirty "}, {'4',"forty "}, {'5',"fifty "}, {'6', "sixty "}, {'7',"seventy "}, {'8',"eighty "}, {'9', "ninety "}
      };
    public NumberConverter(int number)
    {
      _number = number;
    }

    public string Convert()
    {
      string numberString = "";
      char[] numberArray = _number.ToString().ToCharArray();

      for (int i = numberArray.Length - 1; i >= 0; i--) {
        // Console.WriteLine("Number:" + this.GetNumber() + "For loop on i = " + i);
        if (i == 0 && numberArray[i] > '1' && numberArray.Length == 2) {
          // numberString += _tens[numberArray[i]];
          numberString = numberString.Insert(0, _tens[numberArray[i]]);
        } else if (i == 0 && numberArray[i] == '1') {
          numberString = _teens[numberArray[i + 1]];
        } else {
          numberString += _ones[numberArray[i]];
        }
      }
      // int reverseI = 0;
      // for (int i = numberArray.Length - 1; i >= 0; i--) {
      //   if ((numberArray.Length - (reverseI + 1)) % 3 == 0 && numberArray[i - 1] == 1)
      //   {
      //     numberString = _teens[numberArray[i]];
      //     // i--;
      //   }
      //   else
      //   {
      //     numberString = _ones[numberArray[i]];
      //   }
      //   reverseI ++;
      // }
      return numberString;
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
