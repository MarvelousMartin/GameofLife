using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    class Simulation
    {
        public enum Status
        {
            Dead,
            Alive,
        }

        Status[,] Grid { get; set; }
        int Rows { get; set; }
        int Columns { get; set; }

        int GenCounter { get; set; }

        public Simulation(bool inCorner)
        {
            Rows = 78;
            Columns = 160;
            GenCounter = 0;
            Grid = Initialize(inCorner);
        }

        public Simulation(bool inCorner, int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            GenCounter = 0;
            Grid = Initialize(inCorner);
        }

        private Status[,] Initialize(bool inCorner)
        {
            // randomly initialize our grid
            Status[,] grid = new Status[Rows, Columns];
            Random r = new Random();
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j< Columns; j++)
                {
                   
                    if (inCorner) //option to start from corner
                    {
                        if (i < 50 && j < 50)
                        {
                            grid[i, j] = (Status)r.Next(0, 2);
                        }
                    }
                    else //option to start from everywhere
                    {
                        if (i<Rows && j<Columns)
                        {
                            grid[i, j] = (Status)r.Next(0, 2);
                        }
                    }
                }
            }
            return grid;
        }

        private Status[,] NextGeneration (Status[,] currentGrid)
        {
            Status[,] nextGeneration = new Status[Rows, Columns];
            // Loop through every cell 
            for (int i = 1; i < Rows-1; i++)
            {
                for( int j = 1; j < Columns-1; j++)
                {
                    // find your alive neighbors
                    int aliveNeighbors = 0;
                    for (int k = -1; k <=1; k++)
                    {
                        for (int l = -1; l <=1; l++)
                        {
                            aliveNeighbors += currentGrid[k + i, l + j] == Status.Alive ? 1 : 0;
                        }
                    }

                    var currentCell = currentGrid[i, j];

                    // The cell needs to be subtracted 
                    // from its neighbors as it was  
                    // counted before 

                    aliveNeighbors -= currentCell == Status.Alive ? 1 : 0;

                    // Implementing the Rules of Life 

                    // Cell is lonely and dies 
                    if (currentCell == Status.Alive && aliveNeighbors < 2)
                    {
                        nextGeneration[i, j] = Status.Dead;
                    }

                    // Cell dies due to over population 
                    else if (currentCell == Status.Alive && aliveNeighbors > 3)
                    {
                        nextGeneration[i, j] = Status.Dead;
                    }

                    // A new cell is born 
                    else if (currentCell == Status.Dead && aliveNeighbors == 3)
                    {
                        nextGeneration[i, j] = Status.Alive;
                    }
                    // stays the same
                    else
                    {
                        nextGeneration[i, j] = currentCell;
                    }
                }               
            }
            GenCounter++;
            return nextGeneration;
        }

        public void Tick()
        {
            Grid = NextGeneration(Grid);
        }

        public Status[,] Peek(out int rows, out int columns)
        {
            rows = Rows;
            columns = Columns;
            return Grid;
        }

        public int GetGeneration()
        {
            return GenCounter;
        }

    }
}
