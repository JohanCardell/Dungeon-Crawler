using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public static class LevelEditor
    {
        //private const int MapColumns = 8;
        //private const int MapRows = 4;
        static public char[,] map = new char[,]
        {//Col 0   1   2   3   4   5   6   7   8   9  10
            { 'X','X','X','X','X','X','X','X','X','X','X'}, //0
            { 'X','#','#','#','#','#','#','#','#','#','X'}, //1
            { 'X','#',' ',' ',' ',' ',' ',' ',' ','#','X'}, //2
            { 'X','#',' ',' ','#',' ',' ',' ',' ','#','X'}, //3
            { 'X','#',' ',' ','#',' ',' ',' ',' ','#','X'}, //4
            { 'X','#',' ',' ','#',' ',' ',' ',' ','#','X'}, //5
            { 'X','#','#','#','#','#',' ','#','#','#','X'}, //6
            { 'X','#',' ',' ',' ','#',' ',' ',' ','#','X'}, //7
            { 'X','#',' ','#','#','#',' ',' ',' ','#','X'}, //8
            { 'X','#',' ',' ',' ','#',' ',' ',' ','#','X'}, //9
            { 'X','#',' ',' ',' ','#',' ',' ',' ','#','X'}, //10
            { 'X','#',' ',' ',' ',' ',' ',' ',' ','#','X'}, //11
            { 'X','#','#','#','#','#','#','#','#','#','X'}, //12
            { 'X','X','X','X','X','X','X','X','X','X','X'}, //13
        };
        static int maxMapRows = map.GetLength(0);
        static int maxMapColumns = map.GetLength(1);
        public static List<DungeonTile> dungeonTiles = new List<DungeonTile>();
        public static void GenerateStartLevel()
        {
            for (int row = 0; row < maxMapRows; row++)
            {
                for (int column = 0; column < maxMapColumns; column++)
                {
                    if (map[row, column] == '#')
                    {
                        dungeonTiles.Add(new Wall(column, row));
                        continue;
                    }
                    else if (map[row, column] == ' ')
                    {
                        dungeonTiles.Add(new Floor(column, row));
                    }
                    else if (map[row,column] == 'X')
                    {
                        dungeonTiles.Add(new Boundary(column, row));
                    }
                }
            }
        }
        public static void RenderLevel()
        {
            for (int row = 0; row < maxMapRows; row++)
            {
                for (int column = 0; column < maxMapColumns; column++)
                {
                    foreach (DungeonTile tile in dungeonTiles)
                    {
                        if(tile.PositionX.Equals(column) && tile.PositionY.Equals(row))
                        {
                            Console.Write(tile.MapRepresentation);
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}