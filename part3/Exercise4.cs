namespace part3
{
  using System;
 
  public class BinarySearch
  {          
    public int[] list;

     public BinarySearch(){}

    public BinarySearch(int n)
    {
      list = Randomizer(n);         
    }

    public bool Find(int[] t, int x)
    {
      int a = 0;
      int b = t.Length - 1;
      int k = 0;
      int k2 = b + 1;

      Sorting s = new Sorting(b);
      int[] tt = s.MergeSort2(t);
      s.Printall(t);
      s.Printall(tt);

      while(a <= b) //0 8 =>4 
      {
        k = (b - a)/2;
        if (k == k2) break;
        k2 = k;
        
        if(tt[k] == x) goto end;
        if(tt[k] < x) a = k + 1; 
        if(tt[k] > x) b = k + 1;    

      }
      return false;
      end:return true;
      
    }


    public void Printall(int a, int b)
    {  
      for(int i = a; i < b +1; i++) System.Console.Write( this.list[i] + " ");
      System.Console.WriteLine("");
    }

    public void Printall(int[] t)
    {  
      for(int i = 0; i < t.Length; i++) System.Console.Write( t[i] + " ");
      System.Console.WriteLine("");
    }
      public void Swap(int aa, int bb)
      { 
        int cc = list[aa] ;
        list[aa] = list[bb];
        list[bb] = cc; 
      }

    public static int[] Randomizer(int n)
    {
      Random random = new Random();
      int[] arr = new int[n];
      for (int i = 0; i < arr.Length; i++)
      {
        // integers between 1 and 1000 are enough for us
        arr[i] = random.Next(1, 1001);
      }
      return arr;
    }
  }
}
