using System;
using System.Collections.Generic;
using System.Linq;

namespace part5
{
      /* Exercise 5 Your task is to find the shortest path from x to y in a labyrinth. 
     * The labyrinth is a matrix of n * m size, and is constructed as follows: 
     * # means a wall, and . means a floor. You can assume that all the tiles on the 
     * outside are walls, and there is exactly one x and one y in the grid.
     * On a single turn, you can move one step left, right, up or down. You have to give 
     * the route of the shortest path as a string, which is made from characters 
     * L, R, U and D respectively. If there are multiple routes, you can return any of them.
     * Create a class Labyrinth with the following method:
     * string Search(char[,] laby), returns the description of the shortest path 
     * (if there is none, returns null or empty string).*/
    public class Labyrinth
    {
        private int count;
        private string path = "";
        private char[,] c;
        public int[] position = new int[2];
        public Queue<int[]> qvisited = new Queue<int[]>();
        public Queue<int[]> qwall = new Queue<int[]>();
        public Queue<int[]> qroute = new Queue<int[]>();
        private bool[,] visited;

        public int n; // = laby.GetLength(0);
        public int m; // = laby.GetLength(1);
        public bool result;

        public Labyrinth() 
        {
            result = false;
        }
          
        public string Search(char[,] laby)
        {
            
            result = false;
            int n = laby.GetLength(0);
            int m = laby.GetLength(1);
            c = laby;
            visited = new bool[n, m];
            FindFirst('x');
            result = Search(position);
            return path;
        }

        public bool Search(int[] position)
        {
            if (result == true) goto End;
            int y = position[0];
            int x = position[1];

            if (c[y, x] == 'y') 
            {        
                return true; 
            }
            
            if (visited[y, x] == true)
            {
                return false;
            }
            if (c[y,x] == '#')
            {
                visited[y, x] = true;
                return false;
            }
            qroute.Enqueue(new int[] { y, x });
            visited[y, x] = true;
            position[0] -= 1;
            result = Search(position);
            if (result == true) 
            {
                count++;
                path = "U" + path;
                goto End; 
            }
            position[0] += 2;
            result = Search(position);
            if (result == true)
            {
                count++;
                path = "D" + path;
                goto End;
            }
            position[0] -= 1;
            position[1] -= 1;
            result = Search(position);
            if (result == true)
            {
                count++;
                path = "L" + path;
                goto End;
            }
            position[1] += 2;
            result = Search(position);
            if (result == true)
            {
                count++;
                path = "R" + path;
                goto End;
            }
            position = qroute.Dequeue();
            result = Search(position); 
         
            End: return result;
        }
        
        private void FindFirst(char cc) 
        {
            int ii;
            int jj;            

            int h = c.GetLength(0);
            int v = c.GetLength(1);
            for (ii = 0; ii < h; ii++) 
            {
                for (jj = 0; jj < v; jj++) 
                {
                    if (c[ii, jj] == '#') 
                    {
                        qwall.Enqueue(new int[] { ii, jj });
                    }

                    if (c[ii, jj] == cc) 
                    {
                        position[0] = ii;
                        position[1] = jj;
                        goto End;
                    } 
                }
            }
        End:;
        }

  
    }

}

/*char[,] c = 
 *  0123456
 * 0#######
 * 1#x#.y.#
 * 2#.#.#.#
 * 3#.....#
 * 4####### };
 */
