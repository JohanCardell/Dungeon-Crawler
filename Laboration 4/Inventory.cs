using System.Collections.Generic;

namespace Laboration_4
{

    public class Inventory
    {
        //private int numberOfSilverKeys;
        //private int numberOfGoldKeys;
        //private int numberOfHealthPotions;
        private Color sword;
        public List<Loot> keys = new List<Loot>();
        public List<HealthPotion> potions = new List<HealthPotion>();
        public List<Sword> swords = new List<Sword>();
        public Color Sword
        {
            get => sword;
            set => sword = value;
        }
    }
}
