﻿namespace Laboration_4
{
    class Door : GameObject, IInteractable
    {
           
        public Door(uint positionX, uint positionY, Color color)
            : this(positionX, positionY, false, false, 'D', color) { }
        
        public Door(uint positionX, uint positionY, bool isPassable, bool isVisible, Color color)
            : this(positionX, positionY, isPassable, isVisible, 'D', color) { }

        public Door(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color ) { }

        public void Interact(Player player, Door door, GameSession gameSession)
        {
            //TODO check if player has the right key
            //if (key.Material == door.Material)
            // if (door.doorType == Ke
        }
    }
}