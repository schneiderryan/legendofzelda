using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    static class EnemyCollisionDetector
    {
        public static void HandleEnemyCollisions(IRoom room)
        {
            EnemyWallCollision(room.Enemies, room.Hitboxes);
            EnemyBlockCollision(room.Enemies, room.Blocks);
            EnemyDoorCollision(room.Enemies, room.Doors);
        }

        private static void EnemyWallCollision(IList<IEnemy> enemies, IList<Rectangle> hitboxes)
        {
            foreach (IEnemy enemy in enemies)
            {
                foreach (Rectangle hitbox in hitboxes)
                {
                    Rectangle collision = Rectangle.Intersect(enemy.Hitbox, hitbox);
                    if (!collision.Equals(Rectangle.Empty))
                    {
                        EnemyCollisionHandler.HandleEnemyWallBlockCollision(enemy, collision);
                    }
                }
            }
        }

        private static void EnemyBlockCollision(IList<IEnemy> enemies, IList<IBlock> blocks)
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

        private static void EnemyDoorCollision(IList<IEnemy> enemies, IDictionary<String, IDoor> doors)
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
    }
}