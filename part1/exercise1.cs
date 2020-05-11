namespace part1
{
  using System;
 
  public class Numbers
  {
    public int Sum(int x)
    { 
      int digits = x.ToString().Length;
      int rem = 0;
      int tens = 0;
      int total = 0;

      for(int i = digits; i > 0; i--)
      {
        tens = (int) Math.Pow(10, i-1);
        rem =x%tens;
        total += (x - rem)/tens;
        x = rem;
      }   
      return total;
    }
  }
}