namespace part6
{
  using System;
  using System.Collections.Generic;
  /*
 *  In a Bitworld there are n cities, numbered 1,2,…,n. There are two-way streets between those cities,
 *  with certain lengths. Your task is to find out the shortest distance between cities x and y, 
 *  using Floyd-Warshall. Create a class 
 *  ShortestPath (or FloydWarshall, if you want exercises 1-3 to be in same namespace) with following methods:
 *  ShortestPath(int n), the amount of cities given in the constructor
 *  void AddRoad(int a, int b, int d): Adds a road between cities a and b, with the distance d 
 *  int Calculate(int x, int y) returns the shortest distance from city x to city y (or -1, 
 *  if there is no connection).
 *  
 *  for k = 1 to n
 *    for i = 1 to n
 *       for j = 1 to n
 *             distance[i,j] = min(distance[i,j], distance[i,k]+distance[k,j])
 *  
 */

    public class ShortestPath
    {    
      public int[,] distance;
      private int infinitely; // = int.MaxValue;

      public ShortestPath(int n)
    {
        infinitely = n * n; //int.MaxValue;
        distance = new int[n +1, n+1];
        for (int i = 0; i < n+1; i++) 
        {
            for (int j = 0; j < n+1; j++)
            {
                distance[i, j] = infinitely;
            }
        }

        for (int i = 0; i < n +1; i++)
        {
            distance[i, i] = 0;
        }


    }

      public void AddRoad(int a, int b, int d) //Adds a road between cities a and b, with the distance d
    {
        distance[a, b] = d;
    }

      public void FindAll()
    {
        int n = distance.GetLength(0);
        for (int k = 1; k < n; k++)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    distance[i, j] = Math.Min(distance[i, j], distance[i, k] + distance[k, j]);
                }
            }
        } 
    }

      public int Calculate(int x, int y)
    {
    FindAll();
    int result = distance[x, y];
    if ((result == 0) || (result == infinitely)) return -1;
    else return result;
    }
           
      public override string ToString() 
    {
        string result = "";
        for (int i = 0; i < distance.GetLength(0); i++) 
        {
            for (int j = 0; j < distance.GetLength(1); j++) 
            {
                result += distance[i, j];
                result += " ";
            }
            result += "\n";
        }
        return result;
    }
    }
  }


