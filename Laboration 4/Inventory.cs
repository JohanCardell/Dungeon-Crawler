namespace Laboration_4
{
    
    //public enum Sword {Bronze, Silver, Gold }
    public class Inventory
    {
        private uint numberOfBronzeKeys;
        private uint numberOfSilverKeys;
        private uint numberOfGoldKeys;
        private uint numberOfHealthPotions;
        private Sword sword;
        #region Getters and setters
        public uint NumberOfBronzeKeys
        {
            get => numberOfBronzeKeys;
            set => numberOfBronzeKeys = value;
        }
        public uint NumberOfSilverKeys
        {
            get => numberOfSilverKeys;
            set => numberOfSilverKeys = value;
        }
        public uint NumberOfGoldKeys
        {
            get => numberOfGoldKeys;
            set => numberOfGoldKeys = value;
        }
        public Sword Sword
        {
            get => sword;
            set => sword = value;
        }
        public uint NumberOfHealthPotions
        {
            get => numberOfHealthPotions;
            set => numberOfHealthPotions = value;
        }
        #endregion
        
    }
}
