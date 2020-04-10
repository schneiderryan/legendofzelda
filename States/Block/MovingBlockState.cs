using System.Collections.Generic;


namespace LegendOfZelda
{
    class MovingBlockState : ImmoveableBlockState
    {
        private int vy;
        private int vx;
        private int pxMoved;
        private MoveableBlock block;
        private IDictionary<string, IDoor> doors;

        public MovingBlockState(MoveableBlock block, IDictionary<string, IDoor> doors,
                int vx, int vy)
        {
            this.vx = vx;
            this.vy = vy;
            pxMoved = 0;
            this.block = block;
            this.doors = doors;
        }

        public override void Update()
        {
            block.X += vx;
            block.Y += vy;
            pxMoved += vx + vy;

            if (pxMoved != 0 && pxMoved % RoomParser.TILE_SIZE == 0)
            {
                block.State = new MovedBlockState(doors);
            }
        }
    }
}
