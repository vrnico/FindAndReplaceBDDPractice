using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace.Models;

namespace FindAndReplace.Tests
{
  [TestClass]
  public class FindAndReplaceTest
  {
    [TestMethod]
    public void GetInputString_GetsString_ReturnsString()
    {
      //arrange
      FindAndReplaceGenerator newFindAndReplaceGenerator = new FindAndReplaceGenerator("");
      string testString = "";
      //act
      string testInput = newFindAndReplaceGenerator.GetInputString();
      //assert
      Assert.AreEqual(testString, testInput);
    }
  }
}
