namespace part1
{
  public class Tables
  {
    public void PrintTable(int[] t)
    {
      int count = t.Length;
      System.Console.WriteLine("Print table");
      for(int i = 0; i < count; i++)
      {
        System.Console.WriteLine("i " + i + " x " + t[i] + " ");
      }      
    }

    public int Calculate(int[] t)
    {
      //   PrintTable(t);
      if(t.Length <= 1) return t[0];
      else
      {
        int count = t.Length - 1;
        int[] tt = new int[count];
        int result = 0;

        //PrintTable(t);
        for(int i = 0; i < count; i++)
        {
          tt[i] = t[i] + t[i + 1];        
        }
        result = Calculate(tt);
        return result;        
      }
    }
  }
}