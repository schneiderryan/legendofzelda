using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegendOfZelda
{
    static class EnemyCollisionDetector
    {
        public static void HandleEnemyCollisions(Room room, IPlayer player)
        {
            EnemyWallCollision(room.enemies, room);
            EnemyBlockCollision(room.enemies, room.blocks);
            EnemyPlayerCollision(room.enemies, player);
            EnemyDoorCollision(room.enemies, room.doors);
            EnemyProjectileCollision(room.enemies, room.projectiles);
        }

        private static void EnemyWallCollision(List<IEnemy> enemies, Room room)
        {
            foreach (IEnemy enemy in enemies) {
                foreach (Rectangle hitbox in room.hitboxes)
                {
                    Rectangle collision = Rectangle.Intersect(enemy.Hitbox, hitbox);
                    if (!collision.Equals(Rectangle.Empty))
                    {
                        EnemyCollisionHandler.HandleEnemyWallBlockCollision(enemy, collision);
                    }
                }
            }
        }

        private static void EnemyBlockCollision(List<IEnemy> enemies, List<IBlock> blocks)
        {
            foreach (IEnemy enemy in enemies)
            {
                foreach (ICollideable block in blocks)
                {
                    Rectangle collision = Rectangle.Intersect(enemy.Hitbox, block.Hitbox);
                    if (!collision.Equals(Rectangle.Empty))
                    {
                        EnemyCollisionHandler.HandleEnemyWallBlockCollision(enemy, collision);
                    }
                }
            }
        }

        private static void EnemyPlayerCollision(List<IEnemy> enemies, IPlayer player)
        {
            foreach (IEnemy enemy in enemies.ToList())
            {
                Rectangle collision = Rectangle.Intersect(enemy.Hitbox, player.Hitbox);
                if (!collision.Equals(Rectangle.Empty))
                {
                    EnemyCollisionHandler.HandleEnemyPlayerCollision(player, enemy, collision);
                }
            }
        }

        private static void EnemyDoorCollision(List<IEnemy> enemies, Dictionary<String, IDoor> doors)
        {
            foreach (IEnemy enemy in enemies)
            {
                foreach (KeyValuePair<String, IDoor> door in doors)
                {
                    Rectangle collision = Rectangle.Intersect(enemy.Hitbox, door.Value.Hitbox);
                    if (!collision.Equals(Rectangle.Empty))
                    {
                        EnemyCollisionHandler.HandleEnemyWallBlockCollision(enemy, collision);
                    }
                }
            }
        }

        private static void EnemyProjectileCollision(List<IEnemy> enemies, List<IProjectile> projectiles)
        {
            List<IProjectile> projectilesToRemove = new List<IProjectile>();
            foreach(IEnemy enemy in enemies)
            {
                foreach(IProjectile projectile in projectiles)
                {
                    Rectangle collision = Rectangle.Intersect(enemy.Hitbox, projectile.Hitbox);
                    if (!collision.Equals(Rectangle.Empty))
                    {
                        EnemyCollisionHandler.HandleEnemyProjectileCollision(enemy, collision);
                        projectilesToRemove.Add(projectile);
                    }
                }
            }
            foreach(IProjectile toRemove in projectilesToRemove)
            {
                projectiles.Remove(toRemove);
            }
        }
    }
}
