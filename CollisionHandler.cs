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
                if (!player.Hitbox.Equals(Rectangle.Empty))
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
                if (!player.Hitbox.Equals(Rectangle.Empty))
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
