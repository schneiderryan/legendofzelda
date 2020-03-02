using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace LegendOfZelda
{
    static class ProjectileCollisionHandler
    {
        private static ICollection<IProjectile> projectiles;
        private static ICollection<IDespawnEffect> effects;

        public static void Register(ICollection<IProjectile> projectiles,
                ICollection<IDespawnEffect> effects)
        {
            ProjectileCollisionHandler.projectiles = projectiles;
            ProjectileCollisionHandler.effects = effects;
        }

        public static void Despawn(ICollection<IProjectile> despawn)
        {
            foreach (IProjectile deadProjectile in despawn)
            {
                Despawn(deadProjectile);
            }
        }

        private static void Despawn(IProjectile projectile)
        {
            projectiles.Remove(projectile);
            effects.Add(projectile.GetDespawnEffect());
        }

/*        private static void EnemyProjectileCollision(List<IEnemy> enemies, List<IProjectile> projectiles)
        {
            List<IProjectile> projectilesToRemove = new List<IProjectile>();
            foreach (IEnemy enemy in enemies)
            {
                foreach (IProjectile projectile in projectiles)
                {
                    Rectangle collision = Rectangle.Intersect(enemy.Hitbox, projectile.Hitbox);
                    if (!collision.Equals(Rectangle.Empty))
                    {
                        EnemyCollisionHandler.HandleEnemyProjectileCollision(enemy, collision);
                        projectilesToRemove.Add(projectile);
                    }
                }
            }
            foreach (IProjectile toRemove in projectilesToRemove)
            {
                projectiles.Remove(toRemove);
            }
        }*/

        public static void ProjectilePlayerCollision(IPlayer player)
        {
            player.TakeDamage();
        }

        public static void EnemyProjectileCollision(IEnemy enemy,
                IProjectile projectile, in Rectangle collision)
        {
            if (projectile.Owner == enemy.Team)
            {
                return;
            }

            Despawn(projectile);

            //Take damage
            if (collision.Width > collision.Height)
            {
                if (collision.Y != enemy.Hitbox.Y)
                {
                    enemy.Y -= collision.Height;
                }
                else
                {
                    enemy.Y += collision.Height;
                }
            }
            else
            {
                if (collision.X != enemy.Hitbox.X)
                {
                    enemy.X -= collision.Width;
                }
                else
                {
                    enemy.X += collision.Width;
                }
            }
        }
    }
}
