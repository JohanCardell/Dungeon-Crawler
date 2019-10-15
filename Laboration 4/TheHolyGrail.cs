using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class TheHolyGrail:GameAsset, IInteractable
    {
        public TheHolyGrail(int positionX, int positionY)
            : base(positionX, positionY, false, false, 'H',Color.CYAN) { }

        public string Interact(Player player)
        {
            string message;
            player.hasTheHolyGrail = true;
            this.IsPassable = true;
            message = "You now have the Holy Grail, and may leave the dungeon.";
            return message;
        }
    }
}
