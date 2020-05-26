namespace part3
{
  using System;
 
  public class Inversions
  {          
    public Inversions(){}

    public int[] Create(int n, int k)
    {
      int[] ia = new int[n];

      for(int i = 0; i < n; i++) ia[i] = i + 1;

      int b = 0;
      int c = 0;

      while(b < n && c < k +1) 
      {
        Swap(ia, b, b+1);
        b += 2; 
        c++;
      }     
      return ia; 
    }

    public int[] Swap(int[] nmbs, int aa, int bb)
    { 
      int cc = nmbs[aa] ;
      nmbs[aa] = nmbs[bb];
      nmbs[bb] = cc; 
      return nmbs;
    }

    public void Printtall(int[] t)
    {  
      for(int i = 0; i < t.Length; i++) System.Console.Write( t[i] + " ");
      System.Console.WriteLine("");
    }

  }
}
 