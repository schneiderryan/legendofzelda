

namespace LegendOfZelda
{
    abstract class ImmoveableBlockState : IBlockState
    {
        public virtual void MoveDown()
        {
            // do nothing
        }

        public virtual void MoveLeft()
        {
            // do nothing
        }

        public virtual void MoveRight()
        {
            // do nothing
        }

        public virtual void MoveUp()
        {
            // do nothing
        }

        public virtual void Update()
        {
            // do nothing
        }
    }
}
