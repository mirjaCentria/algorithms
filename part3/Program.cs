using System;

namespace part3
{
    class Program
    {
        static void Main(string[] args)
        {  

            /*
            // e1 HelloBot
            HelloBot hb = new HelloBot();
            hb.Hello(5);    

            // e2 SmallestDifference
            SmallestDifference s = new SmallestDifference();
            Console.WriteLine(s.Calculate(new int[] {4,1,8,5})); // 1
            Console.WriteLine(s.Calculate(new int[] {1,10,100})); // 9
            Console.WriteLine(s.Calculate(new int[] {1,1,1,1,1})); // 0
            Console.WriteLine(s.Calculate(Randomizer(10))); // depends on random
            

            // e3 Sorting
            Sorting so = new Sorting(6);
            int[] t = Sorting.Randomizer(6); 
            Console.WriteLine("MergeSort: ") ;     
            so.MergeSort(t);

            t = Sorting.Randomizer(6); 
            Console.WriteLine("QuickSort: ") ;     
            so.QuickSort(t); 
            */     
        /*
            BinarySearch b = new BinarySearch();
            Console.WriteLine(b.Find(new int[] {4,1,8,5}, 2)); // false
            Console.WriteLine(b.Find(new int[] {0,0}, 0)); // true
            Console.WriteLine(b.Find(new int[] {4,1,8,5,8,7,4,2,3}, 2)); // true
            Console.WriteLine(b.Find(new int[] {0}, 0)); // true
            Console.WriteLine(b.Find(Sorting.Randomizer(100000), 3)); // depends on Random          
        */

            Inversions inv = new Inversions();
            int[] t = inv.Create(10, 5);
            foreach (int i in t)
            {
            Console.Write(i + " ");  // 2 1 3 5 4
            }

        }

    }
}
