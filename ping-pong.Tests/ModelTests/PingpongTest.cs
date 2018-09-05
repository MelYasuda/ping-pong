using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pingpong;
using System.Collections.Generic;

namespace Pingpong.Tests
{
  [TestClass]
  public class PingpongTest
  {
    List <int> emptyList = new List<int>();
    [TestMethod]
    public void ShowOutput_GetUserInput()
    {
      PingpongGenerator generator = new PingpongGenerator();
      CollectionAssert.AreEqual(emptyList, generator.ShowOutput(""));
    }
    [TestMethod]
    public void ShowOutput_ValidateUserInput()
    {
      PingpongGenerator generator = new PingpongGenerator();
      CollectionAssert.AreEqual(emptyList, generator.ShowOutput("a"));
      CollectionAssert.AreEqual(emptyList, generator.ShowOutput("-32"));
      CollectionAssert.AreEqual(emptyList, generator.ShowOutput("0"));
    }
    [TestMethod]
    public void ShowOutput_OneToInputNumber()
    {
      PingpongGenerator generator = new PingpongGenerator();
      CollectionAssert.AreEqual(new List<int>{1,2}, generator.ShowOutput("2"));
    }
    [TestMethod]
    public void ShowOutput_ReplaceMultiplesOf3WithPing()
    {
      PingpongGenerator generator = new PingpongGenerator();
      CollectionAssert.AreEqual(new List<int>{1,2,-1,4,5,-1}, generator.ShowOutput("6"));
    }
  }
}
