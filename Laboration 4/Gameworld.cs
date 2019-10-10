using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class GameWorld
    {
        public static char[,] CurrentGameWorld { get; set; }
        public static char[,] GetGameWorld { get => getGameWorld; set => getGameWorld = value; }
        private static char[,] getGameWorld;

        public static readonly char[,] initialGameWorld = new char[,]
        {//Col 0   1   2   3   4   5   6   8   9  10  11
            { 'X','X','X','X','X','X','X','X','X','X','X'}, //0
            { 'X','#','#','#','#','#','#','#','#','#','X'}, //1
            { 'X','#',' ',' ','D',' ','B','S','C','#','X'}, //2
            { 'X','#',' ',' ','#',' ',' ','M',' ','#','X'}, //3
            { 'X','#',' ',' ','#',' ',' ',' ',' ','#','X'}, //4
            { 'X','#','P',' ','#',' ',' ',' ',' ','#','X'}, //5
            { 'X','#','#','#','#','#','D','#','#','#','X'}, //6
            { 'X','#',' ',' ','E','#',' ',' ',' ','#','X'}, //7
            { 'X','#',' ','#','#','#',' ',' ',' ','#','X'}, //8
            { 'X','#',' ',' ',' ','#',' ',' ',' ','#','X'}, //9
            { 'X','#',' ',' ',' ','#',' ',' ',' ','#','X'}, //10
            { 'X','#',' ',' ',' ','D',' ',' ',' ','#','X'}, //11
            { 'X','#','#','#','#','#','#','#','#','#','X'}, //12
            { 'X','X','X','X','X','X','X','X','X','X','X'}  //13
        }; 
    }
}
