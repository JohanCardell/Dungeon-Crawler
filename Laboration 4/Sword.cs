namespace Laboration_4
{
    public class Sword : Loot, IInteractable
    {
        public Sword(Color color)
    : this(0, 0, color) { }
        public Sword(int positionX, int positionY, Color color)
    : base(positionX, positionY, false, false, 'w', color)
        { }
        public string Interact(Player player)
        {
            string messsage = "";
            switch (this.AssetColor)
            {
                case Color.BRONZE:
                    break;
                case Color.SILVER:
                    break;
                case Color.GOLD:
                    break;
            }
            foreach (var sword in player.inventory.swords)
            {
                if (sword.AssetColor is Color.BRONZE)
                {
                    player.inventory.swords.Clear();
                    player.inventory.swords.Add(this);
                    messsage = $"You now have a {this.AssetColor} sword.";
                }
                else if (sword.AssetColor is Color.SILVER && this.AssetColor is Color.GOLD)
                {
                    player.inventory.swords.Clear();
                    player.inventory.swords.Add(this);
                    messsage = $"You now have a {this.AssetColor} sword.";
                }
                break;
            }
            return messsage;
        }

    }
}
