using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    static class CollisionHandler
    {
        public static void HandlePlayerBlockCollision(List<IPlayer> moving,
                List<IBlock> still)
        {
            foreach (ICollideable s in still)
            {
                foreach (ICollideable m in moving)
                {
                    if (m.Hitbox.Intersects(m.Hitbox))
                    {
                        Rectangle collision = Rectangle.Intersect(m.Hitbox, s.Hitbox);
                        HandleCollision(m, collision);
                    }
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
