using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    static class CollisionHandler
    {
        public static void PlayerBlockCollision(IPlayer player,
                List<IBlock> still)
        {
            foreach (ICollideable s in still)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, s.Hitbox);
                if (!collision.Equals(Rectangle.Empty))
                {
                    HandleCollision(player, collision);
                }
            }
        }

        public static void PlayerDoorCollision(IPlayer player,
                Dictionary<String, IDoor> doors)
        {
            foreach(KeyValuePair<String, IDoor> door in doors)
            {
                    if(!(door.Value is BottomOpen || door.Value is TopOpen ||door.Value is RightOpen || door.Value is BottomOpen))
                {
                    Rectangle collision = Rectangle.Intersect(player.Hitbox, door.Value.Hitbox);
                    if (!collision.Equals(Rectangle.Empty))
                    {
                        HandleCollision(player, collision);
                    }
                }
                    
                   
                
            }
            
        }

        public static void PlayerWallCollision(IPlayer player,
                Room room)
        {
            
                foreach(Rectangle hitbox in room.hitboxes)
                {
                    
                    Rectangle collision = Rectangle.Intersect(player.Hitbox, hitbox);
                    if (!collision.Equals(Rectangle.Empty))
                    {
                        HandleCollision(player, collision);
                    }
                }
                
            
        }

        public static void PlayerMoveableBlockCollision(IPlayer player,
                List<IMoveableBlock> moveable)
        {
            foreach (ICollideable m in moveable)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, m.Hitbox);
                if (!collision.Equals(Rectangle.Empty))
                {
                    HandleCollision(m, collision);
                }
            }
        }

        private static void HandleCollision(ICollideable moveable,
                in Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y != moveable.Hitbox.Y)
                {
                    moveable.Y -= collision.Height;
                }
                else
                {
                    moveable.Y += collision.Height;
                }
            }
            else
            {
                if (collision.X > moveable.Hitbox.X)
                {
                    moveable.X -= collision.Width;
                }
                else
                {
                    moveable.X += collision.Width;
                }
            }


        }
    }
}
