using System;

namespace part2
{
    public class TestInterface2
    {
        public void Start()
        {   /*
            LongestRepetition lr = new LongestRepetition();
            int[] nmbrs = lr.CreateInput(20);
            lr.PrintArray(nmbrs);
            int result = lr.Calculate(nmbrs);
            System.Console.WriteLine("Max length {0} ", result);   
            */
            LongestRepetition p = new LongestRepetition();
            Console.WriteLine(p.Calculate(new int[] {1,2,1,1,2})); // 2
            Console.WriteLine(p.Calculate(new int[] {1,2,3,4,5})); // 1
            Console.WriteLine(p.Calculate(new int[] {1,1,1,1,1})); // 5       
           
           Console.WriteLine("ti2 done");
        }
    }
}