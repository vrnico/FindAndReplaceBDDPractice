using Microsoft.AspNetCore.Mvc;

namespace FindAndReplace.Models
{
  public class FindAndReplaceGenerator
  {
  private string _inputString;
  private string _findString;

  public FindAndReplaceGenerator(string inputString, string findString)
  {
    _inputString = inputString;
    _findString = findString;
  }

  public string GetInputString()
  {
    return _inputString;
  }
  public string GetFindString()
  {
    return "wwjhlj";
  }
  }
}
