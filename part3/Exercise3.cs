namespace part3
{
  using System;
 
  public class Sorting
  {          
    public int[] list;

    public Sorting(int n)
    {
      list = Randomizer(n);         
    }

    public void MergeSort(int[] t)
    {                
      DateTime start = DateTime.Now;
      int [] r = MergeSort2(t);
      DateTime end = DateTime.Now;
      Console.WriteLine("Time this took: " + end.Subtract(start));
      Printall(t);
      Printall(r);
    }

    public int[] MergeSort2(int[] t)
    { 
      DateTime start = DateTime.Now;
      int n = t.Length;
      if(n < 2) return t;
      int k = n/2;
      int[] ta = new int[k]; 
      int[] tb = new int[n - k]; 
      int[] tm = new int[n];
      
      Array.Copy(t, 0, ta, 0, k);
      Array.Copy(t, k, tb, 0, n-k);
      ta = MergeSort2(ta);
      tb = MergeSort2(tb);
      tm = Merge(ta, tb);
     // Printall(tm);
      return tm;
    }     
      
    public int[] Merge(int[] ta, int[] tb)
    { 
      int n = ta.Length + tb.Length;
      int[] tt =  new int[n];
      int i = 0;
      int j = 0;
      int k = 0;

      while(i < ta.Length && j < tb.Length && k < tt.Length)
      {
        if(ta[i] <= tb[j])
        {
          tt[k++] = ta[i++];
        }
        else if(ta[i] >= tb[j])
        {
          tt[k++] = tb[j++];
        }
      }

      if(i < ta.Length)      
      {
        while(i < ta.Length &&  k < tt.Length)
        {
          tt[k++] = ta[i++];
        }
      }      
      else if(j < tb.Length)      
      {
        while(j < tb.Length &&  k < n)
        {
          tt[k++] = tb[j++];
        }
      }       
      return tt;
    }


    public void QuickSort(int[] t)
    {
      this.list = t;
      Printall(list);
      DateTime start = DateTime.Now;
      this.list = t;
      QuickSort2(0, t.Length - 1);
      DateTime end = DateTime.Now;
      Console.WriteLine("Time this took: " + end.Subtract(start));
      Printall(list);
      
    }
    public void QuickSort2(int a, int b)
    {  
      int cc = 0;
      int k = 0;
     // this.Printall(a,b);
      for(int i = a +1; i < b + 1; i++)
      {
        if(this.list[a + k] >  this.list[i] ) //s.Pivot(0,5);
        {
          if(i - k - a == 1)
          {
          // this.Swap(this.list[a + k], this.list[i]);
            cc = list[a+ k] ;
            list[a + k] = list[i];
            list[i] = cc; 
            k++;        
          }
          else if(i - k - a > 1) 
          {
            cc = list[a+ k +1] ;
            list[a + k + 1] = list[i];            
            list[i] = cc; 

            cc = list[a+ k] ;
            list[a + k] = list[a + k + 1];
            list[a + k + 1] = cc; 
            k++;
          } 
        } 
      }         
      int c = a + k;
      if(c-a > 0) this.QuickSort2(a, c);
      if(b-c > 0)  this.QuickSort2(c+1, b);      
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