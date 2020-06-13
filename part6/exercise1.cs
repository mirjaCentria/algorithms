namespace part6
{    
    using System;
    using System.Collections.Generic;

    public class Edge
    {
        public int source, end, weight;
        public Edge(int source, int end, int weight)
        {
            this.source = source;
            this.end = end;
            this.weight = weight;
        }

        public override string ToString() 
        {
            return this.source + " " + this.end + " " + this.weight;
        }
    }

     public class BellmanFord
    {
        private int infinitely; // = int.MaxValue;
        private int n;
        List<Edge> edges = new List<Edge>();

        public BellmanFord(int n)
        {
            this.n = n;
            this.infinitely = n * n * n;
        }

        public void AddRoad(int a, int b, int d) 
        {
            this.edges.Add(new Edge(a, b, d));
            this.edges.Add(new Edge(b, a, d));
        }

        public int Calculate(int x, int y)
        {
            int[] distance = new int[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                distance[i] = infinitely;
            }
            distance[x] = 0;

            while (true)
            {
                bool change = false;

                foreach (Edge item in edges)
                {
                    int current = distance[item.end];
                    int newCurrent = distance[item.source] + item.weight;
                    if (newCurrent < current)
                    {
                        distance[item.end] = newCurrent;
                        change = true;
                    }
                }
                if (change == false) break;
            }
            if (distance[y] == infinitely) return -1;
            else return distance[y];
        }

        public override string ToString()
        {
            string result = "";
            foreach (Edge item in edges) 
            { 
                result += item.ToString();
                result += "\n";        
            }
            return result;
        }
    }
}
