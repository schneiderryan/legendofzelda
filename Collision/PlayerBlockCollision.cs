using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class PlayerBlockCollision : ICollision
    {
        private IRoom room;
        private IPlayer player;
        private IBlock block;

        public PlayerBlockCollision(IRoom room, IPlayer player, IBlock block)
        {
            this.room = room;
            this.player = player;
            this.block = block;
        }

        public void Handle()
        {
            IMoveableBlock moveableBlock;
            if (block is IMoveableBlock)
            {
                moveableBlock = block as IMoveableBlock;
            }
            else
            {
                moveableBlock = new MoveableBlock(room);
            }

            // computing this here so that link doesn't get double corrected if he runs
            // into two blocks at the same time
            Rectangle collision = Rectangle.Intersect(player.Footbox, block.Hitbox);

            if (collision.Width > collision.Height)
            {
                if (collision.Y == player.Footbox.Y)
                {
                    player.Y += collision.Height;
                    moveableBlock.MoveOnceUp();
                }
                else
                {
                    player.Y -= collision.Height;
                    moveableBlock.MoveOnceDown();
                }
            }
            else
            {
                if (collision.X == player.Footbox.X)
                {
                    player.X += collision.Width;
                    moveableBlock.MoveOnceLeft();
                }
                else
                {
                    player.X -= collision.Width;
                    moveableBlock.MoveOnceRight();
                }
            }
        }
    }
}