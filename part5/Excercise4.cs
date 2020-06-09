using System;
using System.Collections.Generic;
namespace part5
{ 
    /* Exercise 4 A network comprises of n computers, which are labeled 1, 2, …, n. 
     * In the network there is a set of connections, through which information can 
     * be sent both ways. You are given pairs of computers and your task is to find out, 
     * if they can communicate with one another.
     * 
     * Create a class Communication, with the following methods:
     * Communication(int n), the amount of computers is given to the constructor as a parameter.
     * void AddConnection(int a, int b), adds a connection between a and b.
     * bool Examine(int x, int y), returns true if there is a connection between x and y, otherwise returns false.
     * 
*/
    public class Communication
    {
        private List<int>[] graph;
       
        private List<int> searched = new List<int>();

        public Communication() { }

        public Communication(int n)
        {
            graph = new List<int>[n + 1];
            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<int>();
            }
        }

        public void AddConnection(int a, int b)
        {
            if (graph[a] == null) graph[a] = new List<int>();
            graph[a].Add(b);
        }
        public bool Examine(int a, int b)
        {
            bool result = Search(a,b);
            return result;
        }

        private bool Search(int a, int b)
        {
            bool result = false;
            int next;
            searched.Add(a);
            List<int> test = graph[a];
            if (test == null) return false;
            if (test.Count == 0) return false;

            for (int i = 0; i < test.Count; i++)
            {
                next = test[i];
                if (next == 0) return false;
                if (next == b) return true;


                if (!Already(next))
                {
                    result = Search(next, b);
                    if (result == true) return true;
                }
            }
            return result;
        }

        private bool Already(int x)
        {
            foreach (int i in searched) if (i == x) return true;
            return false;
        }

        public override string ToString()
        {
            string result = "";
            List<int> line;

            for (int i = 1; i < graph.GetLength(0) + 1; i++)
            {
                line = graph[i];
                result += IList(line);
                result += "\n";
            }

            return result;
        }

        public string IList(List<int> li)
        {
            string result = "";
            for (int i = 0; i < li.Count; i++)
            {
                result += li[i].ToString();
                result += " ";
            }
            return result;
        }
    }
}
