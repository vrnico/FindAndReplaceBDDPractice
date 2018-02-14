using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
      FindAndReplaceGenerator newFindAndReplaceGenerator = new FindAndReplaceGenerator("I am a cat", "cat", "butt");
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
      new FindAndReplaceGenerator("i am a cat", "cat", "butt");
      string testString = "cat";
      //act
      string testInput = newFindAndReplaceGenerator.GetFindString();

      //assert
      Assert.AreEqual(testString, testInput);
    }

    [TestMethod]
    public void GetReplaceString_GetsReplacementString_ReturnsString()
    {
      //arrange
      FindAndReplaceGenerator newFindAndReplaceGenerator = new FindAndReplaceGenerator("i am a cat", "cat", "butt");
      string testString = "butt";
      //act
      string testInput = newFindAndReplaceGenerator.GetReplaceString();
      //assert
      Assert.AreEqual(testString, testInput);
    }
    [TestMethod]
    public void ReturnString_GetsReturnString_ReturnsString()
    {
      //arrange
      FindAndReplaceGenerator newFindAndReplaceGenerator = new FindAndReplaceGenerator("i am a cat", "cat", "butt");
      string testString = "i am a butt";
      //act
      string testInput = newFindAndReplaceGenerator.ReturnString();
      //assert
      Assert.AreEqual(testString, testInput);
    }
  }
}
