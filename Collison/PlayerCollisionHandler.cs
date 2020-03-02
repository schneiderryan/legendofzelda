using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{
    static class PlayerCollisionHandler
    {
        public static void PlayerMoveableBlockCollision(IPlayer player,
                IMoveableBlock block, in Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y == player.Footbox.Y)
                {
                    block.MoveOnceUp();
                }
                else
                {
                    block.MoveOnceDown();
                }
            }
            else
            {
                if (collision.X == player.Footbox.X)
                {
                    block.MoveOnceLeft();
                }
                else
                {
                    block.MoveOnceRight();
                }
            }
        }

        public static void HandlePlayerEnemyCollision(IPlayer player, in Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y == player.Hitbox.Y)
                {
                    if (!player.Direction.Equals("up") || !player.IsAttacking())
                    {
                        player.TakeDamage();
                    }
                }
                else
                {
                    if (!player.Direction.Equals("down") || !player.IsAttacking())
                    {
                        player.TakeDamage();
                    }
                }
            }
            else
            {
                if (collision.X == player.Hitbox.X)
                {
                    if (!player.Direction.Equals("left") || !player.IsAttacking())
                    {
                        player.TakeDamage();
                    }
                }
                else
                {
                    if (!player.Direction.Equals("right") || !player.IsAttacking())
                    {
                        player.TakeDamage();
                    }
                }
            }
        }

        public static void PlayerWallCollision(IPlayer player,
                in Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y != player.Footbox.Y)
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
                if (collision.X > player.Footbox.X)
                {
                    player.X -= collision.Width;
                }
                else
                {
                    player.X += collision.Width;
                }
            }
        }
    }
}
