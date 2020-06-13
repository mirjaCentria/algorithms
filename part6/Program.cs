using System;

namespace part6
{
    public class Program 
    {
        static void Main(string[] args)
        {
            BellmanFord bf1 = new BellmanFord(5);
            bf1.AddRoad(1, 2, 7);
            bf1.AddRoad(2, 4, 2);
            bf1.AddRoad(1, 3, 6);
            bf1.AddRoad(3, 4, 5);
            bf1.AddRoad(4, 5, 3);
            Console.WriteLine(bf1.Calculate(1, 5));
         //   Console.WriteLine(bf1.ToString()); //1 2 5  1 3 1  2 4 3  3 2 2  4 3 4 
            
            
            FloydWarshall fw = new FloydWarshall(5);
            fw.AddRoad(1, 2, 7);
            fw.AddRoad(2, 4, 2); 
            fw.AddRoad(1, 3, 6);
            fw.AddRoad(3, 4, 5);
            fw.AddRoad(4, 5, 3);
         //   Console.WriteLine(fw.ToString()); //1 2 5  1 3 1  2 4 3  3 2 2  4 3 4  
            Console.WriteLine(fw.Calculate(1, 5)); // 12
        }
    }

}
