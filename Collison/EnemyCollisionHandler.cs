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
                if (collision.Y != enemy.Hitbox.Y)
                {
                    enemy.Y -= collision.Height;
                    enemy.MoveUp();
                }
                else
                {
                    enemy.Y += collision.Height;
                    enemy.MoveLeft();
                }
            }
            else
            {
                if (collision.X != enemy.Hitbox.X)
                {
                    enemy.X -= collision.Width;
                    enemy.MoveDown();
                }
                else
                {
                    enemy.X += collision.Width;
                    enemy.MoveRight();
                }
            }
        }

        public static void HandleEnemyPlayerCollision(IPlayer player, IEnemy enemy, String side)
        {
            if (player.Direction.Equals(side) && player.IsAttacking() && !enemy.Name.Equals("Trap"))
            {
                enemy.TakeDamage();
                switch (side)
                {
                    case "left":
                        enemy.X -= 5;
                        break;
                    case "right":
                        enemy.X += 5;
                        break;
                    case "up":
                        enemy.Y -= 5;
                        break;
                    case "down":
                        enemy.Y += 5;
                        break;
                }
            }
        }

    }
}
