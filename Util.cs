using Microsoft.Xna.Framework;
using System;


namespace LegendOfZelda
{
    static class Util
    {
        public static void CenterRelativeToEdge(Rectangle origin,
                string edge, ICollideable toBeCentered)
        {
            if (edge == "up")
            {
                toBeCentered.X = origin.Center.X - toBeCentered.Hitbox.Width / 2;
                toBeCentered.Y = origin.Top - toBeCentered.Hitbox.Height;
            }
            else if (edge == "down")
            {
                toBeCentered.X = origin.Center.X - toBeCentered.Hitbox.Width / 2;
                toBeCentered.Y = origin.Bottom;
            }
            else if (edge == "right")
            {
                toBeCentered.X = origin.Right;
                toBeCentered.Y = origin.Center.Y - toBeCentered.Hitbox.Height / 2;
            }
            else if (edge == "left")
            {
                toBeCentered.X = origin.Left - toBeCentered.Hitbox.Width;
                toBeCentered.Y = origin.Center.Y - toBeCentered.Hitbox.Height / 2;
            }
        }

        public static int SignOrZero(int a)
        {
            return (a + 1) % 2 + (a % 2);
        }

        public static Vector2 VelocityVectorToTarget(Point source, Point target, float velocity)
        {
            //int dx = target.X - source.X;
            int dx = source.X - target.X;
            //int dy = target.Y - source.Y;
            int dy = source.Y - target.Y;
            float lower = (float)Math.Sqrt(dx * dx + dy * dy);
            return new Vector2(velocity * dx / lower, velocity * dy / lower);
        }
    }
}
