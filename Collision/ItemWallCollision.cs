using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class ItemWallCollision : ICollision
    {
        private IMovingItem item;
        private Rectangle collision;

        public ItemWallCollision(IMovingItem item, in Rectangle collision)
        {
            this.item = item;
            this.collision = collision;
        }

        public void Handle()
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
