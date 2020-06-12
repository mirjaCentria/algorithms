using System;

namespace part6
{
    public class Program 
    {
        static void Main(string[] args)
    {
        ShortestPath s = new ShortestPath(5);
        Console.WriteLine(s.ToString());
        s.AddRoad(1, 2, 7);
        s.AddRoad(2, 4, 2); 
        s.AddRoad(1, 3, 6);
        s.AddRoad(3, 4, 5);
        s.AddRoad(4, 5, 3);
        Console.WriteLine(s.ToString()); //1 2 5  1 3 1  2 4 3  3 2 2  4 3 4  
        Console.WriteLine(s.Calculate(1, 5)); // 12
    }
    }

}
