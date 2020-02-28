using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    static class PlayerCollisionDetector
    {
        public static void HandlePlayerCollisions(IPlayer player, Room room)
        {
            PlayerMoveableBlockCollision(player, room.moveableBlocks);
            PlayerBlockCollision(player, room.blocks);
            PlayerDoorCollision(player, room.doors);
            PlayerWallCollision(player, room);
        }

        private static void PlayerBlockCollision(IPlayer player,
                List<IBlock> still)
        {
            foreach (ICollideable s in still)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, s.Hitbox);
                PlayerCollisionHandler.HandlePlayerWallBlockCollision(player, collision);
            }
        }

        private static void PlayerDoorCollision(IPlayer player,
                Dictionary<String, IDoor> doors)
        {
            foreach(KeyValuePair<String, IDoor> door in doors)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, door.Value.Hitbox);
                CollisionHandler.HandleBasicCollision(player, collision);
            }
        }

        private static void PlayerWallCollision(IPlayer player, Room room)
        {
            foreach(Rectangle hitbox in room.hitboxes)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, hitbox);
                PlayerCollisionHandler.HandlePlayerWallBlockCollision(player, collision);
            }
        }

        private static void PlayerMoveableBlockCollision(IPlayer player,
                List<IMoveableBlock> moveable)
        {
            foreach (IMoveableBlock m in moveable)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, m.Hitbox);
                if (!collision.Equals(Rectangle.Empty))
                {
                    PlayerCollisionHandler.HandlePlayerMoveableBlockCollision(player, m, collision);
                }
            }
        }
    }
}
