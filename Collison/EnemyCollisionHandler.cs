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

        public static void HandleEnemyPlayerCollision(IPlayer player, IEnemy enemy, in Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y != enemy.Hitbox.Y)
                {
                    if (player.IsAttacking())
                    {
                        System.Diagnostics.Debug.WriteLine("call take damage");
                        enemy.TakeDamage();
                    }
                    enemy.Y -= collision.Height + 15;
                    

                }
                else
                {
                    if (player.IsAttacking())
                    {
                        System.Diagnostics.Debug.WriteLine("call take damage");
                        enemy.TakeDamage();
                    }
                    enemy.Y += collision.Height + 15;
                    
                }
            }
            else
            {
                if (collision.X != enemy.Hitbox.X)
                {
                    if (player.IsAttacking())
                    {
                        System.Diagnostics.Debug.WriteLine("call take damage");
                        enemy.TakeDamage();
                    }
                    enemy.X -= collision.Width + 15;
                    
                }
                else
                {
                    if (player.IsAttacking())
                    {
                        System.Diagnostics.Debug.WriteLine("call take damage");
                        enemy.TakeDamage();
                    }
                    enemy.X += collision.Width + 15;
                    
                }
            }
        }

        
    }
}