

namespace LegendOfZelda
{
    class Stairs : InvisibleBlock
    {
        public enum StairDirection { Up, Down }
        public StairDirection Direction { get; private set; }

        public Stairs(StairDirection direction)
        {
            Direction = direction;
        }
    }
}
