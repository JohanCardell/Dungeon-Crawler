﻿namespace Laboration_4
{
    public class Sword : Loot, IInteractable
    {
        public Sword(Color color)
    : this(0, 0, color) { }
        public Sword(uint positionX, uint positionY, Color color)
    : base(positionX, positionY, false, false, 'w', color)
        { }
        public void Interact(Player player)
        {
            foreach (var sword in player.inventory.swords)
            {
                if (sword.AssetColor < this.AssetColor)
                {
                    player.inventory.swords.Clear();
                    player.inventory.swords.Add(this);
                }
            }
        }

    }
}