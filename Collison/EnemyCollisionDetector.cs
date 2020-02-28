using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    static class EnemyCollisionDetector
    {
        public static void HandleEnemyCollisions(List<IEnemy> enemies, Room room, IPlayer player)
        {
            EnemyWallCollision(enemies, room.hitboxes);
            EnemyBlockCollision(enemies, room.blocks);
            EnemyPlayerCollision(enemies, player);
            EnemyDoorCollision(enemies, room.doors);
        }

        private static void EnemyWallCollision(List<IEnemy> enemies, List<Rectangle> hitboxes)
        {
            foreach (IEnemy enemy in enemies) {
                foreach (Rectangle hitbox in hitboxes)
                {
                    Rectangle collision = Rectangle.Intersect(enemy.Hitbox, hitbox);
                    if (!collision.Equals(Rectangle.Empty))
                    {
                        CollisionHandler.HandleBasicCollision(enemy, collision);
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
                        CollisionHandler.HandleBasicCollision(enemy, collision);
                    }
                }
            }
        }

        private static void EnemyPlayerCollision(List<IEnemy> enemies, IPlayer player)
        {
            foreach (IEnemy enemy in enemies)
            {
                Rectangle collision = Rectangle.Intersect(enemy.Hitbox, player.Hitbox);
                if (!collision.Equals(Rectangle.Empty))
                {
                    CollisionHandler.HandleBasicCollision(enemy, collision);
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
                        CollisionHandler.HandleBasicCollision(enemy, collision);
                    }
                }
            }
        }
    }
}
