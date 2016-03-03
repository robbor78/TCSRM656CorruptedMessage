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
      string[] allMessages = new string[] { "hello", "abc", "wwwwwwwwwwwwwwwwww", "ababba", "zoztxtoxytyt", "jlmnmiunaxzywed" };
      int[] allK = new int[] { 3, 3, 0, 3, 10, 13 };
      string[] allCorrected = new string[] { "lllll", "ddd", "wwwwwwwwwwwwwwwwww", "bbbbbb", "zzzzzzzzzzzz", "mmmmmmmmmmmmmmm" };

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

    [TestMethod]
    public void TestMethod2()
    {
      string[] allMessages = new string[] { "hello", "abc", "wwwwwwwwwwwwwwwwww", "ababba", "zoztxtoxytyt", "jlmnmiunaxzywed" };
      int[] allK = new int[] { 3, 3, 0, 3, 10, 13 };
      string[] allCorrected = new string[] { "lllll", "ddd", "wwwwwwwwwwwwwwwwww", "aaaaaa", "zzzzzzzzzzzz", "mmmmmmmmmmmmmmm" };

      int length = allMessages.Length;
      for (int i = 0; i < length; i++)
      {
        Program p = new Program();

        string message = allMessages[i];
        int k = allK[i];
        string actual = p.reconstructMessage2(message, k);
        string expected = allCorrected[i];
        Assert.AreEqual(expected, actual);
      }
    }
  }
}
