using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Wall:DungeonTile,IPassable
    {
        const char WallMapSymbol = '#';
        public Wall(int X, int Y)
            : this(X, Y, '#') { }
                  
        public Wall(int X, int Y, char symbol) : base(X, Y, symbol) { }
        
    }
}
