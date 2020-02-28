using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    static class PlayerCollisionHandler
    {
        public static void HandlePlayerWallBlockCollision(IPlayer player, in Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y != player.Hitbox.Y)
                {
                    player.Y -= collision.Height;
                }
                else
                {
                    player.Y += collision.Height;
                }
            }
            else
            {
                if (collision.X != player.Hitbox.X)
                {
                    player.X -= collision.Width;
                }
                else
                {
                    player.X += collision.Width;
                }
            }
        }

        public static void HandlePlayerMoveableBlockCollision(IPlayer player, IMoveableBlock m,
                                                                            in Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y == player.Hitbox.Y)
                {
                    m.MoveOnceUp();
                }
                else
                {
                    m.MoveOnceDown();
                }
            }
            else
            {
                if (collision.X == player.Hitbox.X)
                {
                    m.MoveOnceLeft();
                }
                else
                {
                    m.MoveOnceRight();
                }
            }
        }
    }
}
