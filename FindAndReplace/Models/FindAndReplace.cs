using System;
using System.Collections.Generic;

namespace FindReplace
{
  public class StringReplace
  {
    public string OriginalString { get; set; }
    public string WordToReplace { get; set; }
    public string WordReplacingWord { get; set; }
    public string NewString { get; set; }

    public StringReplace(string originalString, string wordToReplace, string wordReplacingWord)
    {
      OriginalString = originalString;
      WordToReplace = wordToReplace;
      WordReplacingWord = wordReplacingWord;
    }

    public string FindAndReplaceMethod()
    {
      string[] array = OriginalString.Split(' ');
      for (int i = 0; i <= array.Length - 1; i++)
      {
        if (WordToReplace == array[i])
        {
          array[i] = WordReplacingWord;
        }
      }
      string newString = string.Join(' ', array);
      return newString;
    }
  }
}