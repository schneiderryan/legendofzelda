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
                if (collision.Y == player.Hitbox.Y)
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
                if (collision.X == player.Hitbox.X)
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
                    if (!player.direction.Equals("up") || !player.IsAttacking())
                    {
                        player.TakeDamage();
                    }
                }
                else
                {
                    if (!player.direction.Equals("down") || !player.IsAttacking())
                    {
                        player.TakeDamage();
                    }
                }
            }
            else
            {
                if (collision.X == player.Hitbox.X)
                {
                    if (!player.direction.Equals("left") || !player.IsAttacking())
                    {
                        player.TakeDamage();
                    }
                }
                else
                {
                    if (!player.direction.Equals("right") || !player.IsAttacking())
                    {
                        player.TakeDamage();
                    }
                }
            }
        }

        public static void MoveableAndNonMoveableCollision(ICollideable moveable,
                in Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y != moveable.Hitbox.Y)
                {
                    moveable.Y -= collision.Height;
                }
                else
                {
                    moveable.Y += collision.Height;
                }
            }
            else
            {
                if (collision.X > moveable.Hitbox.X)
                {
                    moveable.X -= collision.Width;
                }
                else
                {
                    moveable.X += collision.Width;
                }
            }
        }
    }
}
