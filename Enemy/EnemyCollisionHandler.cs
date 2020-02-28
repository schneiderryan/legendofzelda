using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    static class EnemyCollisionHandler
    {
        public static void HandleEnemyWallBlockCollision(IEnemy enemy, in Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y == enemy.Hitbox.Y)
                {
                    enemy.MoveLeft();
                }
                else
                {
                    enemy.MoveRight();
                }
            }
            else
            {
                if (collision.X == enemy.Hitbox.X)
                {
                    enemy.MoveDown();
                }
                else
                {
                    enemy.MoveUp();
                }
            }
        }

        public static void HandleEnemySmartCollision(IEnemy enemy, in Rectangle collision)
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
