using Microsoft.AspNetCore.Mvc;

namespace FindAndReplace.Models
{
  public class FindAndReplaceGenerator
  {
  private string _inputString;

  public FindAndReplaceGenerator(string inputString)
  {
    _inputString = inputString;
  }

  public string GetInputString()
  {
    return "woohoo";
  }
  }
}
