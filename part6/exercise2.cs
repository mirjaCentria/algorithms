namespace part6
{    
    using System;
    using System.Collections.Generic;


    class Dijkstra
    {
        private int n;
        private int infinitely;
        int[] distance;
        bool[] shortestpathfound;
        int[,] graph;

        public Dijkstra(int n) 
        {
            this.n = n;
            this.infinitely = n * n * n; // int.MaxValue;
            this.distance = new int[n +1];
            this.shortestpathfound = new bool[n+1];
            this.graph = new int[n+1,n+1];

            // for each node in graph dist[node] = infinity previous[node] = undefined          
            for (int i = 0; i < n +1; i++)
            {
                distance[i] = infinitely;
                shortestpathfound[i] = false;
            }
        }

        public void AddRoad(int start, int end, int dist)
        {
            this.graph[start, end] = dist;
            this.graph[end, start] = dist;
        }

         public int minDistance()
        {
            // Initialize min value 
            int min = infinitely; // int.MaxValue, 
            int min_index = -1;

            for (int i = 0; i < n ; i++)
                if (shortestpathfound[i] == false && distance[i] <= min)
                {
                    min = distance[i];
                    min_index = i;
                }
            return min_index;
        }

        public int Calculate(int src, int end)
        {
            // dist[source] = 0
            distance[src] = 0;
         
            // Find shortest path for all vertices 
            for (int count = 0; count < n - 1; count++)
            {
                //n = node in Q with smallest dist[]
                int mindist = minDistance();

                if(mindist == end) goto Found;
                // remove n from Q  
                shortestpathfound[mindist] = true;

                // for each neighbor of n
                for (int j = 1; j < n+1; j++) 
                {
                    if (!shortestpathfound[j] && graph[mindist, j] != 0 && distance[mindist] != infinitely && distance[mindist] + graph[mindist, j] < distance[j])
                    distance[j] = distance[mindist] + graph[mindist, j];
                }
            }
            Found: if (distance[end] == infinitely) return -1;
            else return distance[end];
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 1; i < n + 1; i++)
            {
                for(int j = 1; j < n + 1; j++)
                {
                  result += graph[i,j];
                  result += " ";
                }
                result += "\n";
            }
            return result;
        }

        public string PrintA()
        {
            string result = "";
            foreach (int item in distance)
            {
                result += item;
                result += " ";
            }
            result += "\n";

            foreach (bool item in shortestpathfound)
            {
                result += item;
                result += " ";
            }
            result += "\n";
            return result;
        }


    }





}
