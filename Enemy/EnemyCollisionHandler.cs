using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    static class EnemyCollisionHandler
    {
        public static void HandleEnemyWallCollision(ICollideable moveable, in Rectangle collision)
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

        public static void HandleEnemyBlockCollision(ICollideable moveable, in Rectangle collision)
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

        public static void HandleEnemyPlayerCollision(ICollideable moveable, in Rectangle collision)
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

        public static void HandleEnemyEnemyCollision(IEnemy enemy1, IEnemy enemy2, in Rectangle collision)
        {
            IEnemy[] enemies = { enemy1, enemy2 };
            for (int i = 0; i < 2; i++)
            {
                if (enemies[i].xVel > 0)
                {
                    enemies[i].MoveLeft();
                }
                else if(enemies[i].xVel < 0)
                {
                    enemies[i].MoveRight();
                }

                if (enemies[i].yVel > 0)
                {
                    enemies[i].MoveUp();
                }
                else if (enemies[i].yVel < 0)
                {
                    enemies[i].MoveDown();
                }
            }
        }
    }
}
