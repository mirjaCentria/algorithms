namespace part1
{
  using System;
  public class Substrings
  {
    public int Calculate(string a, string b)
    {
      int where = 0;
      int count = 0;
      while(a.Length >=  b.Length)
      {
        where = a.IndexOf(b);
        if(where < 0) break; 
        else
        {          
          a = a.Substring(where + 1);
          count++;
        }
      }
      return count;
    }
  }
}