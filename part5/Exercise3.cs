namespace part5
{
using System;
using System.Collections.Generic;

    /* Exercise 3 A network comprises of n computers, which are 
     * labeled 1, 2, …, n.In the network there is a set of connections, 
     * through which information can be sent both ways.
     * Two computers belong in the same component, if they can communicate 
     * with each other.Your task is to calculate the amount of components.
     * 
     * Create the class Components, with the following methods:
     * Components(int n), the amount of computers is given to the 
     * constructor.
     * void AddConnection(int a, int b), adds a connection between a and b.
     * int Calculate(), returns the amount of components.*/
    public class Components
    { 
        private List<int>[] graph;
        private int count;

        private List<int> searched = new List<int>();

        public Components() { }

        public Components(int n)
        {
            count = 0;

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
        public int Calculate()
        {
            for (int i = 1; i < graph.GetLength(0); i++)
            {
                if(!Already(i)) 
                {
                    Search(i);
                    count++;
                }                
            }
            return count;
        }

        private void Search(int x) 
        {            
            int next;
            searched.Add(x);
            List<int> test = graph[x];
            if (test == null) goto End;
            if (test.Count == 0) goto End;

            for (int i = 0; i < test.Count; i++) 
            {                
                next = test[i];
                if (next == 0) goto End;

                if(!Already(next)) 
                {
                  // count++;
                   Search(next);
                }              
            }
        End:;
        }

        private bool Already(int x) 
        { 
            foreach(int i in searched) if(i == x) return true;
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