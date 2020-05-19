using System;

namespace part2
{
    public class TestInterface5
    {
        public void Start()
        {           
            Split s = new Split();
            Console.WriteLine(s.Calculate(new int[] {1,2,-1,4,0})); // 1
            Console.WriteLine(s.Calculate(new int[] {1,2,3,4,5})); // 0
            Console.WriteLine(s.Calculate(new int[] {0,0,0,0,0})); // 4

            System.Console.WriteLine("ti5 done");           
        }
    }
}