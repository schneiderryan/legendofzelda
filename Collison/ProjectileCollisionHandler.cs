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
                    character.Y -= character.Hitbox.Height / 2;
                }
                else
                {
                    character.Y += character.Hitbox.Height / 2;
                }
            }
            else
            {
                if (collision.X != character.Hitbox.X)
                {
                    character.X -= character.Hitbox.Width / 2;
                }
                else
                {
                    character.X += character.Hitbox.Width / 2;
                }
            }
        }
    }
}
