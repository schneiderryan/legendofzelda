using System.Collections.Generic;


namespace LegendOfZelda
{
    class MoveableBlockState : IBlockState
    {
        private const int PUSH_AMOUNT = 2;
        private const int VELOCITY = 1;
        private const int DELAY = 20;

        private int vx;
        private int vy;
        private int pushDelay;
        private MoveableBlock block;
        private IDictionary<string, IDoor> doors;

        public MoveableBlockState(MoveableBlock block, IDictionary<string, IDoor> doors)
        {
            vy = 0;
            vx = 0;
            pushDelay = 0;
            this.block = block;
            this.doors = doors;
        }

        public void MoveDown()
        {
            vx = 0;
            vy = VELOCITY;
            pushDelay += PUSH_AMOUNT;
        }

        public void MoveLeft()
        {
            vx = -VELOCITY;
            vy = 0;
            pushDelay += PUSH_AMOUNT;
        }

        public void MoveRight()
        {
            vx = VELOCITY;
            vy = 0;
            pushDelay += PUSH_AMOUNT;
        }

        public void MoveUp()
        {
            vx = 0;
            vy = -VELOCITY;
            pushDelay += PUSH_AMOUNT;
        }

        public void Update()
        {
            if (pushDelay > DELAY)
            {
                block.State = new MovingBlockState(block, doors, vx, vy);
            }
            else if (pushDelay > 0)
            {
                pushDelay -= 1;
            }
        }
    }
}
