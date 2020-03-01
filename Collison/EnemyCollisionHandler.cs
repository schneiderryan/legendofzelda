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

        public static void HandleEnemyPlayerCollision(IEnemy enemy, in Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y != enemy.Hitbox.Y)
                {
                    enemy.Y -= collision.Height + 15;
                    enemy.TakeDamage();
                }
                else
                {
                    enemy.Y += collision.Height + 15;
                    enemy.TakeDamage();
                }
            }
            else
            {
                if (collision.X != enemy.Hitbox.X)
                {
                    enemy.X -= collision.Width + 15;
                    enemy.TakeDamage();
                }
                else
                {
                    enemy.X += collision.Width + 15;
                    enemy.TakeDamage(); 
                }
            }
        }

        public static void HandleEnemyProjectileCollision(IEnemy enemy, in Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y != enemy.Hitbox.Y)
                {
                    enemy.Y -= collision.Height;
                    //Take damage
                }
                else
                {
                    enemy.Y += collision.Height;
                    //Take damage
                }
            }
            else
            {
                if (collision.X != enemy.Hitbox.X)
                {
                    enemy.X -= collision.Width;
                    //Take damage
                }
                else
                {
                    enemy.X += collision.Width;
                    //Take damage
                }
            }
        }
    }
}
