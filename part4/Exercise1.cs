namespace part4
{
  using System;
 
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
  public int value;
  public Node first;
  public Node last;

  public LinkedList()
  {
    //first = new Node(0,last,null);
   // last = new Node(0,null,first);
    Console.WriteLine("ll created");
  }

  public void AddFirst(int n)
  { 
    if((first == null) && (last == null))
    {
      Console.WriteLine("all null");
      first = new Node(n, last, null);
      last = new Node(n, null, first);
      Console.WriteLine("all null");
    }
      /*
      first = new Node(n, null, null);      
      Console.WriteLine("first n " + first.value);
      if(first.next != null) Console.WriteLine("first next " + first.next.value);
      if(first.previous != null) Console.WriteLine("first prev " + first.previous.value);
    }*/
    else
    {
      Node newn = new Node(n, null, null); 
      //if(last.previous == first) last.previous = newn;
      newn.next = first;
       if(last.previous.previous == null)
        {
          Console.WriteLine("last 5 prev == first " + last.previous.value + first.value);
         last.previous = newn;
         Console.WriteLine("last 5 prev == first " + newn.value);
         }
      first.previous = newn;
      first = newn;
     // newn.previous = first;
     // newn.value = first.value;
      //newn = first;
     // first.value = n;
     // first.next = newn;   
      //first.previous = null;
    //  if(last.previous == first) last.previous = newn;
      Console.WriteLine("newn " + newn.value);
      if(newn.next != null) Console.WriteLine("newn next " + newn.next.value);
      if(newn.previous != null) Console.WriteLine("newn prev " + newn.previous.value);
      Console.WriteLine("first " + first.value);
      if(first.next != null) Console.WriteLine("first next " + first.next.value);
      if(first.previous != null) Console.WriteLine("first prev " + first.previous.value);
      if(last != null)
      {
        if(last.next != null) Console.WriteLine("last next " + last.next.value);
        if(last.previous != null) Console.WriteLine("last prev " + last.previous.value);
      }
/*
      if(last == null) 
      {
        //last = newn;
        last =  new Node(newn.value, null, newn.previous);
        last.value = newn.value;
        first.next = last;
       // last.previous = newn.previous;
       // last.next = null;
       // first.next = last;
        Console.WriteLine("last = newn" + last.value);
        if(last.next != null) Console.WriteLine("last next " + last.next.value);
      if(last.previous != null) Console.WriteLine("last prev " + last.previous.value);
      }   */
    }
    
  }
      
      /*
      if(first == null)
      {
        Console.WriteLine("af fnull n" + n);
        first = new Node(n, null, null);  
        first.next = first;
        first.previous = first;      
        if(last != null) 
        {
          Console.WriteLine("af l/null last,value" + last.value);
          first.next = last;
          last.previous = first;
        }
      } 
      else
      {
        Console.WriteLine("af newn" + first.value);
        Node newn = new Node(first.value, first.next, null);
        first.value = n;
        first.next = newn;
        first.previous = null;
        newn.previous = first;
      }*/
     // Console.WriteLine("af " + first.value);   
   // } //Adds a Node to the beginning of the linked list, with value n.
  public void AddLast(int n)
  {
    if((first == null) && (last == null))
    {
      first = new Node(n, last, null);
      last = new Node(n, null, first);
    }
   /* if(last == null)
    {
      last = new Node(n, null, null);
      Console.WriteLine("last n" + last.value);
            if(last.next != null) Console.WriteLine("last next " + last.next.value);
      if(last.previous != null) Console.WriteLine("last prev " + last.previous.value);
    }*/
    else
    {
      Node newn = new Node(n, null, null); 
      //newn.value = last.value;
      //newn.next = last.next;
      newn.previous = last;
       if(first.next == last) first.next = newn;
     //    last.value = n;
      last.next = newn;  
      if(last.next != null) Console.WriteLine("wtf 5 last next " + last.next.value);
      if(last.previous != null) Console.WriteLine("wtf 5 last prev " + last.previous.value);
      last = newn; 
     // if(first.next == last) first.next = newn;
         Console.WriteLine("newn  " + newn.value);
        if(newn.next != null) Console.WriteLine("newn next " + newn.next.value);
      if(newn.previous != null) Console.WriteLine("newn prev " + newn.previous.value);
         Console.WriteLine("last  " + last.value);
            if(last.next != null) Console.WriteLine("last next " + last.next.value);
      if(last.previous != null) Console.WriteLine("last prev " + last.previous.value);
      if(first == null) 
      {
        first = new Node(newn.value, newn.next, null);
        //first.value = newn.value; // 
        //first.next = newn.next;
        //first.previous = null; 
        last.previous = first;
         Console.WriteLine("first 0 " + first.value);
        if(first.next != null) Console.WriteLine("first next " + first.next.value);
      if(first.previous != null) Console.WriteLine("first prev " + first.previous.value);
       // first = newn;
       // first.next = last;
      }   
    }
/*
        Console.WriteLine("al lnull n" + n);
      //  last = new Node(n, null, null);
      //  last.next = last;
        last.previous = last;
        if(first != null) 
        {
          Console.WriteLine("al f/null f" + first.value);
          first.next = last;
          last.previous = first;
        }
      } 
      else
      {
      Node newn = new Node(last.value, null, last.previous);
      Console.WriteLine("al newn " + newn.value);
      last.value = n;
      last.next = null;
      last.previous = newn;
      Console.WriteLine("al last" + last.value);
      newn.next = last;
      }
          Console.WriteLine("al last" + last.value);*/
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
    string result = "";
    int i = 0;
    Node n = new Node(0, null, null);
    n = first;
  Console.WriteLine("f " + first.value);
    while(n != null)
    {
      Console.WriteLine("n " + n.value + " " + result);
      result = String.Concat(result, n.value);
      result = String.Concat(result, " ");
      
      i++;
      n = n.next;
    //  Console.WriteLine("n " + n.value + " " + result);
    }
    return result;  
  } //returns the all the values of the list, from the beginning to the end.
  
}

/*
  public class Inversions
  {          
    public Inversions(){}

    public int[] Create(int n, int k)
    {
      int[] ia = new int[n];

      for(int i = 0; i < n; i++) ia[i] = i + 1;

      int b = 0;
      int c = 0;

      while(b < n && c < k +1) 
      {
        Swap(ia, b, b+1);
        b += 2; 
        c++;
      }     
      return ia; 
    }
    public int[] Swap(int[] nmbs, int aa, int bb)
    { 
      int cc = nmbs[aa] ;
      nmbs[aa] = nmbs[bb];
      nmbs[bb] = cc; 
      return nmbs;
    }
    public void Printtall(int[] t)
    {  
      for(int i = 0; i < t.Length; i++) System.Console.Write( t[i] + " ");
      System.Console.WriteLine("");
    }

  }*/

}
 