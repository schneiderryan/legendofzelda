using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class PlayerWallCollision
    {
        public static void Handle(IPlayer player, in Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y != player.Footbox.Y)
                {
                    player.Y -= collision.Height;
                }
                else
                {
                    player.Y += collision.Height;
                }
            }
            else
            {
                if (collision.X > player.Footbox.X)
                {
                    player.X -= collision.Width;
                }
                else
                {
                    player.X += collision.Width;
                }
            }
        }
    }
}
