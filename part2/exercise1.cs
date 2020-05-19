namespace part2
{
  using System;
  using System.Text;
 
  public class Exercise1
  {

    public Exercise1(){}

    public string CreateInput(int n)
    {
    StringBuilder sb = new StringBuilder();
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        sb.Append(random.Next(0, 2).ToString());        
    }
    string v = sb.ToString();
    return v;
    }

    public void Etest(string chars)
    { 
        int n = chars.Length;
        
        //Time efficiency O(n^2)
        DateTime start = DateTime.Now;

        int counter = 0;
        for(int i = 0; i < n; i++ )
        {  // i to n-1
            for(int j = 0; j < n; j++) 
            { // j to n-1
               if(chars[i] == '0' && chars[j] == '1') 
                {
                    counter++; // += 1
                }
            }
        }            
      //  System.Console.WriteLine(counter);
        DateTime end = DateTime.Now;
        string result = end.Subtract(start).ToString();
        Console.Write(result.Substring(6) + " s | ");
       // Console.WriteLine("Time this took: " + end.Subtract(start));

        //Time efficiency O(n)
        start = DateTime.Now;

        counter = 0;
        int zeros = 0;

        for(int i = 0; i < n; i++ )
        {  // i to n-1
        if(chars[i] == '0')
            zeros++;
        else
            counter += zeros;

        }    
      //  System.Console.WriteLine(counter);

        end = DateTime.Now;
        result = end.Subtract(start).ToString();
        Console.WriteLine(result.Substring(6) + " s | ");
    }

  }
}
