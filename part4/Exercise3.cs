namespace part4
{
  using System;
  using System.Text;
  using System.Collections.Generic;
  
  public class SmallestDistance
  {
      private List<int> numbers;
      public SmallestDistance() 
      {
          numbers = new List<int>();
      }

      public void Add(int x) 
      {
          this.numbers.Add(x);
      }

      public int Calculate() 
      {
          this.numbers.Sort();
          int diff = this.numbers[1] - this.numbers[0];
          for (int i = 1; i < this.numbers.Count; i++) 
          {
              int currdiff = this.numbers[i] - this.numbers[i - 1];
              if (currdiff < diff) diff = currdiff;
          }
          return diff;
      }
  }

} 