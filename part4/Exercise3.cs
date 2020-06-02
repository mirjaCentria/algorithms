namespace part4
{
  using System;
  using System.Text;
  
  public class SmallestDistance
  {
    CNode head;
    int sum = 0;
    public void Add(int x)
    {
      if(head == null)    
      {
      sum += x;
      head = new CNode(x, null);
     // head.next = head;
      }
      else
      {
        CNode newn = new CNode(x, head.next);
        head.next = newn;
      }
    
    }
    public int Calculate()  //: returns the smallest distance between two integers.
    {
      int dist = sum;
      int diff = 0;
      CNode nn = head;
      CNode mm = head.next;
      while(nn != null)
      {
        while(mm != null)
        {         
         diff = Math.Abs(mm.value - nn.value);
         if(diff < dist) dist = diff;
         mm = mm.next;
        }
        nn = nn.next;
      }
      return dist; 
    }



    public override string ToString()
    {   
      StringBuilder sb = new StringBuilder();
      CNode nn = head;      

      while(nn != null)
      {
        sb.Append(nn.value);
        sb.Append(" ");
        nn = nn.next;      
      }
      return sb.ToString();
    } 
 
  }

} 