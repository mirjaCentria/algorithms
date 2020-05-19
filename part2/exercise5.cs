namespace part2
{
  using System;
  using System.Text;
 
  public class Split 
  {

    public Split(){}

    public int Calculate(int[] t)
    {
      int n = t.Length;
      int count = 0;
      int sum = 0;
      int total = 0;

      foreach (int nmbr in t)
      {
          total += nmbr;
      }

      if(!(total % 2 == 0)) return 0;

      for (int i = 0; i < n; i++)
      {
        if(!(sum > total/2)) sum+= t[i];
        if(sum == total/2) count++;
        if(count>=n) return count-1;
      }
      return count;
    }
  }
}
