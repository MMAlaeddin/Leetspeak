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
    [TestMethod]
    public void IsLeet_ChangeOToOne_True()
    {
      string output = "1gl00";
      LeetspeakTranslate testLeetSpeak = new LeetspeakTranslate();
      Assert.AreEqual(output, testLeetSpeak.IsLeet("igloo"));
    }
    [TestMethod]
    public void IsLeet_ChangeOToSeven_True()
    {
      string output = "70w3r";
      LeetspeakTranslate testLeetSpeak = new LeetspeakTranslate();
      Assert.AreEqual(output, testLeetSpeak.IsLeet("tower"));
    }
    [TestMethod]
    public void IsLeet_ChangeToZ_True()
    {
      string output = "s70r3z";
      LeetspeakTranslate testLeetSpeak = new LeetspeakTranslate();
      Assert.AreEqual(output, testLeetSpeak.IsLeet("stores"));
    }
  }
}