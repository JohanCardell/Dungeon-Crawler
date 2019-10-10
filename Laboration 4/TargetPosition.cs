using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class TargetPosition
    {
        private uint positionX;
        private uint positionY;
        public uint PositionX
        {
            get => positionX;
            set => positionX = value;
        }public uint PositionY
        {
            get => positionY;
            set => positionY = value;
        }
        public TargetPosition(uint positionX, uint positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }
    }
}
