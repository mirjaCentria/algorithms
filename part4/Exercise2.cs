namespace part4
{
  using System;
  using System.Text;


public class CircleGame
{   
    public int Last(int n)
    {
        if(n == 1) return 1;
        if (n % 2 == 0) return 2 * Last(n / 2) - 1;
        else return 2 * Last((n - 1) / 2) + 1;
     }

}

public class CircleGame2
{
    public int Last2(int n)
    {
        return Josephus(n,2);
    }

    private int Josephus(int n, int k) 
    {
        if (n == 1) return 1;
        else return (Josephus(n - 1, k) + k - 1)% n + 1;
    }
}

} 