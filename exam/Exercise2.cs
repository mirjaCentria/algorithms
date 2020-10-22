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
            List<int> li = new List<int> (input);
            int prev = 0;
            int prevCount = length;

            while(li.Count > 1)
            {
                prev = li[0];

                for(int i = 1; i < li.Count; i++)
                {
                    if(li[i] == prev)
                    {
                        li.RemoveAt(i);
                        li.RemoveAt(i-1);
                        
                        if((i > 2) && (li.Count > i)) prev = li[i-2];                            
                    }
                    if(li.Count <= i) break;
                    prev = prev = li[i];
                }         
                if(li.Count == prevCount) break;
                prevCount = li.Count;
            }

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