using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    static class ProjectileCollisionDetector
    {
        public static void HandleCollisions(ICollection<IProjectile> projectiles,
                IRoom room, IPlayer player)
        {
            EnemyProjectileCollision(projectiles, room.Enemies);
            PlayerProjectileCollision(projectiles, player);
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

        private static void PlayerProjectileCollision(IEnumerable<IProjectile> projectiles,
            IPlayer player)
        {
            foreach (IProjectile projectile in projectiles)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, projectile.Hitbox);
                if (!collision.IsEmpty)
                {
                    ProjectileCollisionHandler.PlayerProjectileCollision(player, projectile, collision);
                }
            }
        }
    }
}
