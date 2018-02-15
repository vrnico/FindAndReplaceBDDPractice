using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace FindAndReplace.Models
{
  public class FindAndReplaceGenerator
  {
    private string _inputString;
    private string _findString;
    private string _replaceString;

    public FindAndReplaceGenerator(string inputString, string findString, string replaceString)
    {
      _inputString = inputString;
      _findString = findString;
      _replaceString = replaceString;
    }

    public string GetInputString()
    {
      return _inputString;
    }
    public string GetFindString()
    {
      return _findString;
    }
    public string GetReplaceString()
    {
      return _replaceString;
    }
    public string ReturnString()
    {
      String[] inputArray = _inputString.Split(' ');
      List<string> outputList = new List<string>{};
      string lowerFind = _findString.ToLower();
      foreach (string word in inputArray)
      {
        string tempReplace = "";
        string lowerWord = word.ToLower();
        if (lowerWord == lowerFind)
        {
          if (Char.IsUpper(word, 0))
          {
            tempReplace = char.ToUpper(_replaceString[0]) + _replaceString.Substring(1);
            outputList.Add(tempReplace);
          }
          else
          {
            outputList.Add(_replaceString);
          }
        }
        else
        {
          outputList.Add(word);
        }
      }
      string outputString = String.Join(" ", outputList);
      return outputString;

      // string returnString = _inputString.Replace(_findString, _replaceString);
      // return returnString;
    }
  }
}
