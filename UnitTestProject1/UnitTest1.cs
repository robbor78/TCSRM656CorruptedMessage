using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SRM656CorruptedMessage;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {

      string[] allMessages = new string[] { "hello", "abc" };
      int[] allK = new int[] { 3,3 };
      string[] allCorrected = new string[] { "lllll","ddd" };

      int length = allMessages.Length;
      for (int i = 0; i < length; i++)
      {
        Program p = new Program();

        string message = allMessages[i];
        int k = allK[i];
        string actual = p.reconstructMessage(message, k);
        string expected = allCorrected[i];
        Assert.AreEqual(expected, actual);
      }
    }
  }
}
