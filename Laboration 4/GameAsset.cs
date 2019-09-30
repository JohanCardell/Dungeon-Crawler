using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    abstract class GameAsset
    {
        private int positionX;
        private int positionY;
        private char mapSymbol;

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public char MapSymbol { get; set; }

        protected GameAsset(int positionX, int positionY, char mapSymbol)
        {
            PositionX = positionX;
            PositionY = positionY;
            MapSymbol = mapSymbol;
        }
    }
}
