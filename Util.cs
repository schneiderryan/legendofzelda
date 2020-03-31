using Microsoft.Xna.Framework;


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
    }
}
