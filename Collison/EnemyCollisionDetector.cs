using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    static class EnemyCollisionDetector
    {
        public static void HandleEnemyCollisions(List<IEnemy> enemies, Room room)
        {
            EnemyWallCollision(enemies, room);
            EnemyBlockCollision(enemies, room.blocks);
        }

        private static void EnemyWallCollision(List<IEnemy> enemies, Room room)
        {
            foreach (IEnemy enemy in enemies) {
                foreach (Rectangle hitbox in room.hitboxes)
                {
                    Rectangle collision = Rectangle.Intersect(enemy.Hitbox, hitbox);
                    if (!collision.Equals(Rectangle.Empty))
                    {
                        EnemyCollisionHandler.HandleEnemyWallCollision(enemy, collision);
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
                        EnemyCollisionHandler.HandleEnemyBlockCollision(enemy, collision);
                    }
                }
            }
        }
    }
}
