using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    static class AsciArt
    {
        public static string Artify(Simulation simulation)
        {
            //Prepare simulation to be viewed by user
            StringBuilder stringBuilder = new StringBuilder();
            int rows;
            int columns;
            var grid = simulation.Peek(out rows, out columns);

            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    var cell = grid[row, column];
                    stringBuilder.Append(cell == Simulation.Status.Alive ? "•" : " ");
                }
                stringBuilder.Append("\n");
            }

            return stringBuilder.ToString();
        }
    }
}
