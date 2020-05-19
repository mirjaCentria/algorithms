namespace part2
{
  using System;
  using System.Text;
 
  public class Changes
  {

    public Changes(){}

    public int[] CreateInput(int n)
    {
      Random random = new Random();
      int[] result = new int[n];
      for (int i = 0; i < n; i++)
      {
          result[i] = random.Next(1, 9);        
      }      
      return result;
    }

    public void PrintArray(int[] a)
    {
      foreach(int item in a) System.Console.Write("{0} ", item);
      System.Console.WriteLine("");
    }

    public int Calculate(int[] t)
    { 
      int counter = 0;
      int n = t.Length;
                    
      for(int i = 0; i < n-1; i++ )
      {
        if(t[i] == t[i + 1] ) 
        {
            counter++; 
            i++;
        }
      }      
      return counter;
    }
  }
}
      