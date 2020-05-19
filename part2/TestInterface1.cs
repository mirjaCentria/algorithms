using System;

namespace part2
{
    public class TestInterface1
    {
        public void Start()
        {
            Exercise1 et = new Exercise1();

            System.Console.WriteLine("| Input size | O(n^2)       | O(n)         |");
            System.Console.WriteLine("|:----------:|:------------:|:------------:|");
            // 10, 100, 1000 and 10000 (and 1000000, if you want)
            //System.Console.WriteLine("10 chars");
            System.Console.Write("| 10         | ");
            string v = et.CreateInput(10);            
            et.Etest(v);
            
            System.Console.Write("| 100        | ");
            //System.Console.WriteLine("100 chars");
            v = et.CreateInput(100);
            et.Etest(v);

            System.Console.Write("| 1000       | ");
            //System.Console.WriteLine("1000 chars");
            v = et.CreateInput(1000);
            et.Etest(v);

            System.Console.Write("| 10000      | ");
            //System.Console.WriteLine("10000 chars");
            v = et.CreateInput(10000);
            et.Etest(v);
         //   System.Console.WriteLine("1000000 chars");
          //  v = et.CreateInput(1000000); freezes???
           // et.Etest(v);

            System.Console.WriteLine("ti1 done");           
        }
    }
}