namespace part1
{
  using System;
  public class LuckyNumbers
  {
    public int calcX(int x)
    {
      int sum = 0;      
      double ten = 0;

      if(x < 3) return 0;
      int ll = x.ToString().Length;
            
      while(ll > 0)
      {
        for(int i = 0; i < ll; i++ )
        {
          ten += 7*Math.Pow(10, i);
        }
        double bb = 0;
        for(int i = 0; i < ll; i++ )
        {
          bb += 4*Math.Pow(10, i);
       
          if(x >= ten - bb + 4)
          {
            sum += (int)Math.Pow(2,ll);
            break; //goto end;
          } 
          if(x >= ten - bb)
          {
            sum += (int)Math.Pow(2,ll);
            break; //goto end;
          } 
        }
        ten = 0;
        ll--;                                                                                                                                                                                                                                            
      }     
      return sum;
    }

    public int Calculate(int a, int b)
    {
      int ta = calcX(a);
      int tb = calcX(b);
       return tb - ta;
    }
  }
}