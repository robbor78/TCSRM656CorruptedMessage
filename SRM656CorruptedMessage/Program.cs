using System;
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
        if (length - counts[c] == k)
        {
          maxCount = counts[c];
          maxC = c;
          break;
        }
      }

      if (length - maxCount != k)
      {
        maxC = 'a';
        while (counts.ContainsKey(maxC))
        {
          maxC = (char)((int)maxC + 1);
        }
      }
      return new string(maxC, length);

    }

    public String reconstructMessage2(String s, int k)
    {
      int length = s.Length;
      var max = s.GroupBy(x => x)
        .Select(grp => new { Char = grp.Key, Diff = length - grp.Count() })
        .OrderBy(o => o.Diff)
        .Where(w => w.Diff == k)
        .FirstOrDefault();

      char c = '.';
      if (max == null)
      {
        c = 'a';
        while (s.Contains(c))
        {
          c = (char)((int)c + 1);
        }
      }
      else
      {
        c = max.Char;
      }
      return new string(c, s.Length);

    }
  }
}
