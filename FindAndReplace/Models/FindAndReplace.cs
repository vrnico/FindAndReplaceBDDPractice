using Microsoft.AspNetCore.Mvc;
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
    //find _findString in _inputString and replace with _replaceString, return new string.
    string returnString = _inputString.Replace(_findString, _replaceString);

    return returnString;
  }
  }
}
