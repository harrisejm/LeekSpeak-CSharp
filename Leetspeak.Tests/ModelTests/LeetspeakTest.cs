using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;
namespace Leetspeak.Tests
{
  [TestClass]
  public class LetterTest
  {
    [TestMethod]
    public void IsLetterEOT()
    {
      Letters LetterTestEOT = new Letters();
      Assert.AreEqual("h3ll0 h3ll0", LetterTestEOT.letterToNumber("hello hello"));
    }
    [TestMethod]
    public void IsLetterOOT()
    {
      Letters LetterTestEOT = new Letters();
      Assert.AreEqual("h3ll07 3dd13", LetterTestEOT.letterToNumber("hellot eddIe"));
    }
    // [TestMethod]
    // public void IsLetterOOT()
    // {
    //   Letters LetterTestEOT = new Letters();
    //   Assert.AreEqual("h3ll0", LetterTestEOT.letterToNumber("h3llo"));
    // }
    // [TestMethod]
    // public void IsLetterIOT()
    // {
    //   Letters LetterTestEOT = new Letters();
    //   Assert.AreEqual("1", LetterTestEOT.letterToNumber("i"));
    // }
    // [TestMethod]
    // public void IsLetterTOT()
    // {
    //   Letters LetterTestEOT = new Letters();
    //   Assert.AreEqual("7", LetterTestEOT.letterToNumber("t"));
    // }
  }
}
