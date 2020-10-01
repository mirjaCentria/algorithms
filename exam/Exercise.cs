namespace exam
{
  using System;
 
  public class Numbers
  {
    public int Steps(int x)
    {       
      int i = 1;
      int steps = 0;
      int total = 0;

      while(total < x)
      {
          total += i++;
          steps++;
      }   
      return steps;
    }
  }
}