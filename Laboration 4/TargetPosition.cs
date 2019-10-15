namespace Laboration_4
{
    class TargetPosition
    {
        private int positionX;
        private int positionY;
        #region getters and setters
        public int PositionX
        {
            get => positionX;
            set => positionX = value;
        }public int PositionY
        {
            get => positionY;
            set => positionY = value;
        }
        #endregion
        public TargetPosition(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }
    }
}
