using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    static class EnemyCollisionHandler
    {
        public static void HandleEnemyCollisions(IList<IEnemy> enemies, IRoom room, IPlayer player)
        {
            EnemyWallCollision(enemies, room.Hitboxes);
            EnemyBlockCollision(enemies, room.Blocks);
            EnemyPlayerCollision(enemies, player);
            EnemyDoorCollision(enemies, room.Doors);
        }

        private static void EnemyWallCollision(IList<IEnemy> enemies, IList<Rectangle> hitboxes)
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

        private static void EnemyBlockCollision(IList<IEnemy> enemies, IList<IBlock> blocks)
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

        private static void EnemyPlayerCollision(IList<IEnemy> enemies, IPlayer player)
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

        private static void EnemyDoorCollision(IList<IEnemy> enemies, IDictionary<String, IDoor> doors)
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
