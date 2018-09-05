using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pingpong;

namespace Pingpong.Tests
{
  [TestClass]
  public class PingpongTest
  {
    [TestMethod]
    public void ShowOutput_GetUserInput_True()
    {
      PingpongGenerator generator = new PingpongGenerator();
      Assert.AreEqual(false, generator.ShowOutput(""));
      Assert.AreEqual(true, generator.ShowOutput("32"));
    }
  }
}
