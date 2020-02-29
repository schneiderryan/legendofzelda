using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{
    static class PlayerCollisionHandler
    {

        public static void HandlePlayerCollisions(IPlayer player, IRoom room)
        {
            // order matters, for the blocks and moveable blocks at least
            PlayerMoveableBlockCollision(player, room.MoveableBlocks);
            PlayerBlockCollision(player, room.Blocks);
            PlayerWallCollision(player, room.Hitboxes);
            PlayerDoorCollision(player, room.Doors);
        }

        private static void PlayerBlockCollision(IPlayer player,
                List<IBlock> still)
        {
            foreach (ICollideable s in still)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, s.Hitbox);
                CollisionHandler.HandleBasicCollision(player, collision);
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

        private static void PlayerWallCollision(IPlayer player, List<Rectangle> walls)
        {
            foreach(Rectangle wall in walls)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, wall);
                CollisionHandler.HandleBasicCollision(player, collision);
            }
        }

        private static void PlayerMoveableBlockCollision(IPlayer player,
                List<IMoveableBlock> moveable)
        {
            foreach (IMoveableBlock m in moveable)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, m.Hitbox);
                if (!collision.IsEmpty)
                {
                    if (collision.Width > collision.Height)
                    {
                        if (collision.Y == player.Hitbox.Y)
                        {
                            m.MoveOnceUp();
                        }
                        else
                        {
                            m.MoveOnceDown();
                        }
                    }
                    else
                    {
                        if (collision.X == player.Hitbox.X)
                        {
                            m.MoveOnceLeft();
                        }
                        else
                        {
                            m.MoveOnceRight();
                        }
                    }
                }
            }
        }
    }
}
