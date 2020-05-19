using System;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {            
            TestInterface1 ti1 = new TestInterface1();
            ti1.Start();
            
            TestInterface2 ti2 = new TestInterface2();
            ti2.Start();
            
            TestInterface3 ti3 = new TestInterface3();
            ti3.Start();
            System.Console.WriteLine("Done");
            
            TestInterface4 ti4 = new TestInterface4();
            ti4.Start();

            TestInterface5 ti5 = new TestInterface5();
            ti5.Start();
            System.Console.WriteLine("Done");
            ;
        }
    }
}