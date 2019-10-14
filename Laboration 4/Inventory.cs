using System.Collections.Generic;

namespace Laboration_4
{

    public class Inventory
    {
        private int numberOfBronzeKeys;
        private int numberOfSilverKeys;
        private int numberOfGoldKeys;
        private int numberOfHealthPotions;
        private Color sword;
        public List<Loot> keys = new List<Loot>();
        public List<HealthPotion> potions = new List<HealthPotion>();
        public List<Sword> swords = new List<Sword>();
        #region Getters and setters
        public int NumberOfBronzeKeys
        {
            get => numberOfBronzeKeys;
            set => numberOfBronzeKeys = value;
        }
        public int NumberOfSilverKeys
        {
            get => numberOfSilverKeys;
            set => numberOfSilverKeys = value;
        }
        public int NumberOfGoldKeys
        {
            get => numberOfGoldKeys;
            set => numberOfGoldKeys = value;
        }
        public Color Sword
        {
            get => sword;
            set => sword = value;
        }
        public int NumberOfHealthPotions
        {
            get => numberOfHealthPotions;
            set => numberOfHealthPotions = value;
        }
        #endregion
    }
}
