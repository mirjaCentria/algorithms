using System;

namespace part2
{
    public class TestInterface4
    {
        public void Start()
        {
         
            Revolutions m = new Revolutions();
            Console.WriteLine(m.Calculate(new int[] {4,1,3,2,5})); // 3
            Console.WriteLine(m.Calculate(new int[] {1,2,3,4,5})); // 1
            Console.WriteLine(m.Calculate(new int[] {5,4,3,2,1})); // 5

            System.Console.WriteLine("ti4 done");           
        }
    }
}