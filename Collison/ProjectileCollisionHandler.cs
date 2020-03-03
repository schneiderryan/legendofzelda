using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    static class ProjectileCollisionHandler
    {
        public static void EnemyProjectileCollision(IEnemy enemy,
                IProjectile projectile, in Rectangle collision)
        {
            if (projectile.OwningTeam.Equals(enemy.Team)
                || (projectile is BoomerangProjectile // goriya is immune to boomerangs
                    && enemy is Goriya))
            {
                return;
            }

            System.Diagnostics.Debug.WriteLine("call take damage");
            enemy.TakeDamage();

            if (collision.Width > collision.Height)
            {
                if (collision.Y != enemy.Hitbox.Y)
                {
                    enemy.Y -= collision.Height + 15;
                }
                else
                {
                    enemy.Y += collision.Height + 15;
                }
            }
            else
            {
                if (collision.X != enemy.Hitbox.X)
                {
                    enemy.X -= collision.Width + 15;
                }
                else
                {
                    enemy.X += collision.Width + 15;
                }
            }

        }
    }
}
