namespace Laboration_4
{
    class Door : GameObject, IInteractable
    {
        public Door(uint positionX, uint positionY, Color color)
            : this(positionX, positionY, false, false, 'D', color) { }
        public Door(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }
        public string Interact(Player player)
        {
            string message = "You don't have a matching key in your inventory";
            for (int color = 0; color < 4; color++)
            {
                if ((Color)color == this.AssetColor)
                {
                    if (this.AssetColor == Color.NONE)
                    {
                        this.IsPassable = true;
                        message = "The door is open now.";
                    }
                    else
                    {
                        foreach (Loot key in player.inventory.keys)
                        {
                            if (key.AssetColor == this.AssetColor)
                            {
                                this.IsPassable = true;
                                player.inventory.keys.Remove(key);
                                message = $"The {this.AssetColor} door has been opened and a {key.AssetColor} has been removed from your inventory.";
                            }
                            break;
                        }
                    }


                }
            }
            return message;
        }
    }
}