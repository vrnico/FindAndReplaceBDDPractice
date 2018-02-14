using Microsoft.AspNetCore.Mvc;

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
  }
}
