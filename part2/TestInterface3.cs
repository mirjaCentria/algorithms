using System;

namespace part2
{
    public class TestInterface3
    {
        public void Start()
        {   /*
            Changes ch = new Changes();
            int[] nmbrs = ch.CreateInput(20);
            ch.PrintArray(nmbrs);
            int result = ch.Calculate(nmbrs);
            System.Console.WriteLine("Max length {0} ", result);   
            */
            Changes p = new Changes();
            Console.WriteLine(p.Calculate(new int[] {1,1,2,2,2})); // 2
            Console.WriteLine(p.Calculate(new int[] {1,2,3,4,5})); // 0
            Console.WriteLine(p.Calculate(new int[] {1,1,1,1,1})); // 2       
           
           Console.WriteLine("ti3 done");
        }
    }
}