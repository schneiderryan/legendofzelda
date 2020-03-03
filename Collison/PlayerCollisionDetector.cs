using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    static class PlayerCollisionDetector
    {
        public static void HandlePlayerCollisions(IRoom room, IPlayer player)
        {
            // order matters, for the blocks and moveable blocks at least
            PlayerMoveableBlockCollision(player, room.MoveableBlocks);
            PlayerBlockCollision(player, room.Blocks);
            PlayerWallCollision(player, room.Hitboxes);
            PlayerDoorCollision(player, room.Doors);
            PlayerEnemyCollision(player, room.Enemies);
        }

        private static void PlayerBlockCollision(IPlayer player,
                IList<IBlock> still)
        {
            foreach (ICollideable s in still)
            {
                Rectangle collision = Rectangle.Intersect(player.Footbox, s.Hitbox);
                PlayerCollisionHandler.PlayerWallCollision(player, collision);
            }
        }

        private static void PlayerDoorCollision(IPlayer player,
                IDictionary<string, IDoor> doors)
        {
            foreach (KeyValuePair<string, IDoor> door in doors)
            {
                Rectangle collision = Rectangle.Intersect(player.Footbox, door.Value.Hitbox);
                if (!door.Key.Equals("Open") && !collision.IsEmpty)
                {
                    PlayerCollisionHandler.PlayerWallCollision(player, collision);
                }
            }
        }

        private static void PlayerWallCollision(IPlayer player, IList<Rectangle> walls)
        {
            foreach (Rectangle wall in walls)
            {
                Rectangle collision = Rectangle.Intersect(player.Footbox, wall);
                if (!collision.IsEmpty)
                {
                    PlayerCollisionHandler.PlayerWallCollision(player, collision);
                }
            }
        }

        private static void PlayerMoveableBlockCollision(IPlayer player,
                IList<IMoveableBlock> moveable)
        {
            foreach (IMoveableBlock m in moveable)
            {
                Rectangle collision = Rectangle.Intersect(player.Footbox, m.Hitbox);
                if (!collision.IsEmpty)
                {
                    PlayerCollisionHandler.PlayerMoveableBlockCollision(player, m, collision);
                }
            }
        }

        private static void PlayerEnemyCollision(IPlayer player, IList<IEnemy> enemies)
        {
            foreach(IEnemy enemy in enemies)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, enemy.Hitbox);
                if (!collision.Equals(Rectangle.Empty))
                {
                    PlayerCollisionHandler.HandlePlayerEnemyCollision(player, collision);
                }
            }
        }
    }
}
