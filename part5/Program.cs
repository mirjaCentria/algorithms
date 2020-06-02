using System;

namespace part5
{
    class Program
    {
        static void Main(string[] args)
        {  /*
          Node n1 = new Node(3, null, null);
          Node n2 = new Node(7, null, n1);
          Node n3 = new Node(2, null, n2);
          Node n4 = new Node(5, null, n3);

          n1.next = n2;
          n2.next = n3;
          n3.next = n4;

          Node n = n1;
          while (n != null)
          {
            Console.WriteLine(n.value);
            n = n.next;
          }*/

        LinkedList ll = new LinkedList();
        ll.AddFirst(1);
        System.Console.WriteLine(ll.ToString());
        ll.AddFirst(2);
        System.Console.WriteLine(ll.ToString());
           ll.AddFirst(3);
        System.Console.WriteLine(ll.ToString());

               
        ll.AddLast(4);
        System.Console.WriteLine(ll.ToString());
        ll.AddLast(5);
        System.Console.WriteLine(ll.ToString());
           ll.AddLast(6);
        System.Console.WriteLine(ll.ToString());
/*
/*
       System.Console.WriteLine(ll.first.value);
       System.Console.WriteLine(ll.first.next.value);
       System.Console.WriteLine(ll.first.next.next.value);
        System.Console.WriteLine(ll.last.previous.previous.value);
 System.Console.WriteLine(ll.last.previous.value);
 System.Console.WriteLine(ll.last.value);*/
 

   
        }

    }
}
