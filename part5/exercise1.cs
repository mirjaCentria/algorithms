namespace part5
{
  using System;
  using System.Text;
public class Node
{
  public int value;
  public Node next;
  public Node previous;

  public Node(int value, Node next, Node previous)
  {
    this.value = value;
    this.next = next;
    this.previous = previous;
  }
}

public class LinkedList
{
  bool magic = true;
  public int value;
  public Node first;
  public Node last;

  public LinkedList()
  {
    first = new Node(0,null, null);
    last = new Node(0, null, null);
    first.next = last;
    last.previous = first;
  }

  public void AddFirst(int n)
  { 
    if(magic)
    {
      first.value = n;
     // last.value = n;
      magic = false;
    } else {
        Node newn = new Node(0, null, null);
        newn.previous = first;
        newn.value = first.value;
        newn.next = first.next;
        
        last.previous = newn;
        first.next = newn;
        first.value = n;
        Console.WriteLine("f f.next lt.prev l"+ first + first.next + last.previous + last);
    }
  }
      
  public void AddLast(int n)
  {   
    if(magic)
    {
     // first.value = n;
      last.value = n;
      magic = false;
    } else 
    {
        Node newn = new Node(0, null, null);
        newn.next = last;
        newn.value = last.value;
        newn.previous = last.previous;

        first.next = newn;
        last.previous = newn;
        last.value = n;
        Console.WriteLine("first first.next last.prev last"+ first + first.next + last.previous + last);

    }
  } //Adds a Node to the end of the linked list, with value n.

  public void RemoveFirst()
  {
      Node newn = first.next;      
      newn.previous = null;
      first = newn;
      Console.WriteLine("nf " + first.value);
  } //Removes the first node from the linked list.

  public void RemoveLast()
  {
      Node newn = last.previous;      
      newn.next = null;
      last = newn;
      Console.WriteLine("nl " + last.value);
  } //Removes the last node from the linked list.
  public int GetNode(int x)
  {
    int i = 0;
    Node n = first;
    while(n != last)
    {
      if(i == x) return n.value;
      i++;
      n = n.next;
    }
    return -1; 
  } //Get the value of the node in position x.

  public override string ToString()
  {   
    StringBuilder sb = new StringBuilder();
    Node nn = first;

    while(nn != null ) 
    {
      sb.Append(nn.value);
      sb.Append(" ");
      nn = nn.next;
    }
    return sb.ToString();
  } //returns the all the values of the list, from the beginning to the end.



  
}



}
 