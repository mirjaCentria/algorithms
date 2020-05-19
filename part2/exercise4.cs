namespace part2
{
  using System;
  using System.Text;
 
  public class Revolutions 
  {

    public Revolutions(){}
    public int Calculate(int[] t)
    { 
      int n = t.Length;
      int x = 1;
      int count = 0;

      while(x < n + 1)
      {              
        for(int i = 0; i < n; i++)
        {    
          if(t[i] == x ) 
          {            
            x++;
          }
        }         
        count++;       
      }       
      return count;
    } 
  }
}
