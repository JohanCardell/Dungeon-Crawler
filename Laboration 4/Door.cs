namespace Laboration_4
{
    class Door : GameObject, IInteractable
    {
        public Door(uint positionX, uint positionY, Color color)
            : this(positionX, positionY, false, false, 'D', color) { }
        public Door(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }
        public void Interact(Player player)
        {
            for (int color = 0; color < 4; color++)
            {
                if ((Color)color == this.AssetColor)
                {
                    if (this.AssetColor == Color.NONE)
                    {
                        this.IsPassable = true;
                    }
                    else
                    {
                        foreach (Loot key in player.inventory.keys)
                        {
                            if (key.AssetColor == this.AssetColor)
                            {
                                this.IsPassable = true;
                                player.inventory.keys.Remove(key);
                            }
                        }
                    }


                }
            }
        }
    }
}