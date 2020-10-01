namespace exam
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
 
    public class ShortenArray
    {
        public int Calculate(int[] input)
        { 
        int length = input.Length;
        //List<int> li = input.ToList();
        List<int> li = new List<int> (input);
        int prev = 0;
       // Console.WriteLine("start Count "+ li.Count);
       // Console.WriteLine("li "+ li.ToString());
       Print(li);

        // var list = (new object[] { 1, 2, 3, "A", "B", "C" }).ToList();
        // object item = list[idx];    list.RemoveAt(idx);
        // list .ToArray()

         //   while(li.Count > 1)
          //  {
                Console.WriteLine("in While li count "+ li[0] + " "+  li.Count);
                  Print(li);
                prev = li[0];

                for(int i = 1; i < li.Count; i++)
                {
                    Console.WriteLine("in For i li count "+ i+ " "+  li[i] + " "+  li.Count);
                     Print(li);
                    if(li[i] == prev)
                    {
                        Console.WriteLine("in If li prev count"+li[i]+" "+ prev + " "+  li.Count);
                          Print(li);
                        li.RemoveAt(i);
                        li.RemoveAt(i-1);
                        
                        if((i > 2) && (li.Count > i)) prev = li[i-2];
                           Print(li);
                           Console.WriteLine("in If  prev count "+ prev + " "+  li.Count);
                           
                    }
                    if(li.Count <= i) break;
                    
                    Console.WriteLine("After If li prev count "+li[i]+" "+ prev + " "+  li.Count);
                    Print(li);
                }         
                 Console.WriteLine("After for count "+ " "+  li.Count);
           // }
             Console.WriteLine("After While ");
            return li.Count;
        }

        public void Print(List<int> pi)
        {
            foreach (int i in pi) 
            { 
            Console.Write(i + " "); 
            } 
            Console.WriteLine("");
        }

    }
}