using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class TargetPosition
    {
        private int positionX;
        private int positionY;
        public int PositionX
        {
            get => positionX;
            set => positionX = value;
        }public int PositionY
        {
            get => positionY;
            set => positionY = value;
        }
        public TargetPosition(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }
    }
}
