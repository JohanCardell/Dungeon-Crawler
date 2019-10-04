namespace Laboration_4
{
    enum Material { Bronze, Silver, Gold }
    class Key : Loot, Iinteractable
    {
        private int uses;
        private Material keyType;
        public int Uses
        {
            get => uses;
            set => uses = value;
        }
        public Material KeyType
        {
            get => keyType;
            set => keyType = value;
        }
        public Key(int positionX, int positionY, int uses, Material keyType)
            : base(positionX, positionY,true,true,'K')
        {
            this.uses = uses;
            this.keyType = keyType;
        }




    }
}
