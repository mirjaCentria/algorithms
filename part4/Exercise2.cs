namespace part4
{
  using System;
  using System.Text;
 
 
public class CNode
{
  public int value;
  public CNode next;

  public CNode(int value, CNode next) 
  {
    this.value = value;
    this.next = next;
  }
}

  public class CircleGame
  {
    public CNode head;
    public CircleGame(){}

    public int Last(int n)
    {      
      for(int i = n; i > 0; i--)
      {
        AddFirst(i);
      }    
      CNode nn = head.next;
      while(nn.next != nn)
      {
        Remove(nn.next);
        nn = nn.next;        
      }
      return nn.value;
    }

    public void Remove(CNode rm)
    {
      CNode nn = head;
      while(nn.next != rm)
      {
        nn = nn.next; 
      }
      nn.next = rm.next;
    }

    public void AddToEmpty(int n)
    {
      if(head == null) 
      {
      head = new CNode(n, null);
      head.next = head;
      }
    }

    public void AddFirst(int n)
    {
      if(head == null)  AddToEmpty(n);
      else
      {
        CNode newn = new CNode(n, head.next);
        head.next = newn;
      }
    }
 
    public override string ToString()
    {   
      StringBuilder sb = new StringBuilder();
      CNode nn = head.next;
      int n = head.value;

      for(int i = 0; i < n + 3; i++)
      {
        sb.Append(nn.value);
        sb.Append(" ");
        nn = nn.next;      
      }
      return sb.ToString();
    } 
 
  }

} 