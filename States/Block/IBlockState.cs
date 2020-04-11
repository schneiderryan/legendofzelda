

namespace LegendOfZelda
{
    interface IBlockState : IUpdateable
    {
        void MoveLeft();
        void MoveRight();
        void MoveUp();
        void MoveDown();
    }
}
