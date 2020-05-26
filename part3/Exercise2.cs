namespace part3
{
  using System;
 
  public class SmallestDifference
  {  
    public int Calculate(int[] t)
    { 
      int n = t.Length;
      int min = 0;

      foreach(int item in t)
      {
        System.Console.Write(item + " ");
        min += item;
      } 

      for(int i = 0; i < n -1; i++)
      {      
        for(int j = i + 1; j < n; j++)
        {
          int b = Math.Abs(t[i] - t[j]);
          if( b < min) min = b;         
        }
      }
      return min;
    }
  }
}
/*void Hello(n)
  if n == 0
    return
  else
    print("Hello!")
    Hello(n-1)*/