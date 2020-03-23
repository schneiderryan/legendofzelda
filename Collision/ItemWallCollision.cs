using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class ItemWallCollision
    {
        public ItemWallCollision()
        {
            // nothing needed
        }

        public void Handle(IMovingItem item, Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (item.Hitbox.Y == collision.Y)
                {
                    item.Y += collision.Height;
                }
                else
                {
                    item.Y -= collision.Height;
                }
                item.FlipVY();
            }
            else
            {
                if (item.Hitbox.X == collision.X)
                {
                    item.X += collision.Width;
                }
                else
                {
                    item.X -= collision.Width;
                }
                item.FlipVX();
            }
        }
    }
}
