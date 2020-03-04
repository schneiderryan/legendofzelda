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
            Knockback(enemy, collision);
        }

        public static void PlayerProjectileCollision(IPlayer player,
                IProjectile projectile, in Rectangle collision)
        {
            if (projectile.OwningTeam.Equals(player.Team))
            {
                return;
            }

            player.TakeDamage();
            Knockback(player, collision);
        }

        private static void Knockback(ICharacter character, in Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y != character.Hitbox.Y)
                {
                    character.Y -= 5;
                }
                else
                {
                    character.Y += 5;
                }
            }
            else
            {
                if (collision.X != character.Hitbox.X)
                {
                    character.X -= 5;
                }
                else
                {
                    character.X += 5;
                }
            }
        }
    }
}
