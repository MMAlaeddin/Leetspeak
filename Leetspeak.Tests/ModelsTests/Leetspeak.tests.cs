using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;
using Leetspeak.Models;

namespace LeetspeakTranslateTests 
{
  [TestClass]
  public class LeetspeakTests
  {
    [TestMethod]
    public void IsLeet_ChangeEToThree_True()
    {
      string output = "b33p";
      LeetspeakTranslate testLeetSpeak = new LeetspeakTranslate();
      Assert.AreEqual(output, testLeetSpeak.IsLeet("beep"));
    }
    [TestMethod]
    public void IsLeet_ChangeOToZero_True()
    {
      string output = "b00p";
      LeetspeakTranslate testLeetSpeak = new LeetspeakTranslate();
      Assert.AreEqual(output, testLeetSpeak.IsLeet("bOOp"));
    }
  }
}