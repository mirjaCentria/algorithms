namespace part4
{
  using System;
  using System.Collections.Generic;

  public class LinkedList
  {
      public Node head;
      public Node tail;

      public LinkedList()
      {
          this.head = null;
          this.tail = null;
      }

      public void AddFirst(int n)
      {
          Node addme = new Node(n, null, null);

          if (this.head == null) // no head without a tail and vice versa
          {
              this.head = addme;
              this.tail = this.head;
          }
          else
          {
              this.head.previous = addme;
              addme.next = this.head;
              this.head = addme;
          }
      }

      public void AddLast(int n)
      {
          Node addme = new Node(n, null, null);

          if (this.tail == null) // no head without a tail and vice versa
          {
              this.tail = addme;
              this.head = this.tail;
          }
          else
          {
              this.tail.next = addme;
              addme.previous = this.tail;
              this.tail = addme;
          }
      }

      public void RemoveFirst()
      {
          this.head = this.head.next;
          this.head.previous = null;
      }

      public void RemoveLast()
      {
          this.tail = this.tail.previous;
          this.tail.next = null;
      }

      public int GetNode(int x)
      {
          Node n = this.head;
          for (int i = 0; i < x; i++) 
          {
              n = n.next;
          }
          return n.value;
      }

      public override string ToString()
      {
          string total = "";
          Node n = this.head;
          while (n != null)
          {
              total += n.value + " ";
              n = n.next;
          }
          return total;
      }

  }


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
    
}
 