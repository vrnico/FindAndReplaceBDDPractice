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
      FindAndReplaceGenerator newFindAndReplaceGenerator = new FindAndReplaceGenerator("I am a cat", "cat");
      string testString = "I am a cat";
      //act
      string testInput = newFindAndReplaceGenerator.GetInputString();
      //assert
      Assert.AreEqual(testString, testInput);
    }
    [TestMethod]
    public void GetFindString_GetsString_ReturnsString()
    {
      //arrange
      FindAndReplaceGenerator newFindAndReplaceGenerator =
      new FindAndReplaceGenerator("i am a cat", "cat");
      string testString = "cat";
      //act
      string testInput = newFindAndReplaceGenerator.GetFindString();

      //assert
      Assert.AreEqual(testString, testInput);
    }
  }
}
