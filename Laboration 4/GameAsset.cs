namespace Laboration_4
{
    public abstract class GameAsset
    {
        private Color assetColor;
        private int positionX;
        private int positionY;
        private char mapRepresentation;
        private bool isPassable;
        private bool isVisible;

        public Color AssetColor
        {
            get => assetColor;
            set => assetColor = value;
        }
        public int PositionX
        {
            get => positionX;
            set => positionX = value;
        }
        public int PositionY
        {
            get => positionY;
            set => positionY = value;
        }
        public char MapRepresentation
        {
            get => mapRepresentation;
            set => mapRepresentation = value;
        }
        public bool IsPassable
        {
            get => isPassable;
            set => isPassable = value;
        }
        public bool IsVisible
        {
            get => isVisible;
            set => isVisible = value;
        }
        protected GameAsset(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
        {
            AssetColor = color;
            PositionX = positionX;
            PositionY = positionY;
            IsPassable = isPassable;
            IsVisible = isVisible;
            MapRepresentation = mapRepresentation;
        }
    }
}
