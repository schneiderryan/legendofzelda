using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    static class PlayerCollisionHandler
    {
        public static void PlayerBlockCollision(IPlayer player,
                List<IBlock> still)
        {
            foreach (ICollideable s in still)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, s.Hitbox);
                CollisionHandler.HandleBasicCollision(player, collision);
            }
        }

        public static void PlayerDoorCollision(IPlayer player,
                Dictionary<String, IDoor> doors)
        {
            foreach(KeyValuePair<String, IDoor> door in doors)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, door.Value.Hitbox);
                CollisionHandler.HandleBasicCollision(player, collision);
            }
        }

        public static void PlayerWallCollision(IPlayer player, Room room)
        {
            foreach(Rectangle hitbox in room.hitboxes)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, hitbox);
                CollisionHandler.HandleBasicCollision(player, collision);
            }
        }

        public static void PlayerMoveableBlockCollision(IPlayer player,
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
