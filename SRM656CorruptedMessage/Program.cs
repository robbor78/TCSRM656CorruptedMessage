﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRM656CorruptedMessage
{
  public class Program
  {
    static void Main(string[] args)
    {
    }

    public String reconstructMessage(String s, int k)
    {
      if (k == 0) { return s; }

      int maxCount = 0;
      char maxC = '.';
      Dictionary<char, int> counts = new Dictionary<char, int>();
      int length = s.Length;
      for (int i = 0; i < length; i++)
      {
        char c = s[i];
        if (!counts.ContainsKey(c))
        {
          counts.Add(c, 0);
        }
        counts[c]++;
        if (counts[c] > maxCount)
        {
          maxCount = counts[c];
          maxC = c;
        }
      }

      return new string(maxC, length);

    }
  }
}
