/*
Exercise 3
You are given a map of rooms in a house, and your task is to calculate, how many rooms a house has. ´
A map is a grid where each square is either floor (marked with 0) or wall (marked with 1). 
Two floor squares are in the same room, if they are adjacent horizontally or vertically. 
You can assume each square on the outer perimeter is wall.
•	Create a class Rooms and a function 
int Calculate(int[,] input), returns the amount of rooms in the house.
For example:
Rooms r = new Rooms();
int[,] house = {
    {1,1,1,1,1,1,1,1},
    {1,0,1,0,1,0,0,1},
    {1,1,1,0,1,0,1,1},
    {1,0,1,0,1,0,0,1},
    {1,1,1,1,1,1,1,1},
h};
Console.WriteLine(r.Calculate(house)); // 4


*/
namespace exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Rooms
    {
        private int count;
        public int[,] c;

        public bool result;
        public bool room;

        public Stack<int[]> route = new Stack<int[]>();
        public int[] position = new int[2];

        public int Calculate(int[,] input)
        {
            count = 0;
            result = false;
            c = input;
            int n = c.GetLength(0); //y dim
            int m = c.GetLength(1); // x dim

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result = Search(i, j);
                    if (result == true) count++;
                }
            }
            return count;
        }

        public bool Search(int x, int y )
        {
            int n = c.GetLength(0); //y dim
            int m = c.GetLength(1); // x dim
   

            if (this.c[x,y] == 1) return false;
            if (this.c[x,y] == 0) 
            {                
                room = true;
                this.c[x,y] = 1;
                result = true;
                
                while ((result == true) &&(x < n-1))
                {
                   route.Push(new int[] { y, x }); 
                   if(x < n-1) result = Search(++x, y);
                    position = route.Pop();
                    y = position[0];
                    x = position[1];
                }

                result = true;
                while ((result == true)&&(y < m -1))
                {
                    route.Push(new int[] { y, x });
                    if (y < m-1) result = Search(x, ++y);
                    position = route.Pop();
                    y = position[0];
                    x = position[1];
                }
                result = true;
                while ((result == true)&&(x >1))
                {
                    route.Push(new int[] { y, x });
                    if (x > 1 ) result = Search(--x, y );
                    position = route.Pop();
                    y = position[0];
                    x = position[1];
                }
                result = true;
                while ((result == true)&&(y > 1))
                {
                    route.Push(new int[] { y, x });
                    if (y > 1) result = Search(x, --y);
                    position = route.Pop();
                    y = position[0];
                    x = position[1];
                }
            }
            if(room == true) return true;
            room = false;
            return result;
        }

  }
}