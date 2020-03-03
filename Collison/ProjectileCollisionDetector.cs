using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    static class ProjectileCollisionDetector
    {
        public static void HandleCollisions(ICollection<IProjectile> projectiles,
            ICollection<IDespawnEffect> effects, IRoom room, IPlayer player)
        {
            EnemyProjectileCollision(projectiles, room.Enemies);
            ProjectileDespawner.DespawnProjectiles(room, player, projectiles, effects);
        }

        private static void EnemyProjectileCollision(IEnumerable<IProjectile> projectiles,
                IEnumerable<IEnemy> enemies)
        {
            foreach (IProjectile projectile in projectiles)
            {
                foreach (IEnemy enemy in enemies)
                {
                    Rectangle collision = Rectangle.Intersect(enemy.Hitbox, projectile.Hitbox);
                    if (!collision.IsEmpty)
                    {
                        ProjectileCollisionHandler.EnemyProjectileCollision(enemy, projectile, collision);
                    }
                }
            }
        }
    }
}
