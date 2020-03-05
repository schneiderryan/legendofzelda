using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class PlayerBlockCollision
    {
        public void Handle(IPlayer player, IBlock block, in Rectangle collision)
        {
            IMoveableBlock moveableBlock;
            if (block is IMoveableBlock)
            {
                moveableBlock = block as IMoveableBlock;
            }
            else
            {
                moveableBlock = new MoveableBlock();
            }

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
