namespace part2
{
  using System;
  using System.Text;
 
  public class LongestRepetition
  {

    public LongestRepetition(){}

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
      int longest = 0;
      int counter = 0;
      int n = t.Length;
                    
      for(int i = 0; i < n-1; i++ )
      {
        if(t[i] == t[i + 1] ) 
        {
            counter++; 
        }
        else 
        {
          if(++counter > longest) longest = counter;
          counter = 0;
        }
      }
      if(longest == 0) longest = ++counter;
      return longest;
    }
  }
}
      /*
longest = 0
for i = 0 to length
compare s[i] == s[i + 1] 
	yes count++ 
	no if count > longest longest = count break
for j = i+1 to length 
compare s[j] == s[j + 1] 
	yes count++ 
	no if count > longest longest = count break.

 zeros;*/