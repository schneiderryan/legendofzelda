using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class PlayerBlockCollision : ICollision
    {
        private LegendOfZelda game;
        private IDictionary<string, IDoor> doors;
        private IPlayer player;
        private IBlock block;

        public PlayerBlockCollision(IDictionary<string, IDoor> doors, IPlayer player,
                IBlock block, LegendOfZelda game)
        {
            this.game = game;
            this.doors = doors;
            this.player = player;
            this.block = block;
        }

        public void Handle()
        {
            if (block is Stairs)
            {
                if (block.Hitbox.Contains(player.Center))
                {
                    Stairs.StairDirection direction = (block as Stairs).Direction;
                    if (direction == Stairs.StairDirection.Down)
                    {
                        game.state = new ChangeRoomState("stairdown", player, game);
                    }
                    else
                    {
                        game.state = new ChangeRoomState("stairup", player, game);
                    }
                }
                return;
            }

            // computing this here so that link doesn't get double corrected if he runs
            // into two blocks at the same time
            Rectangle collision = Rectangle.Intersect(player.Footbox, block.Hitbox);

            IMoveableBlock moveableBlock;
            if (block is IMoveableBlock)
            {
                moveableBlock = block as IMoveableBlock;
            }

            else
            {
                moveableBlock = new MoveableBlock(doors);
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
