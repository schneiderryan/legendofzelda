using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class PlayerWallCollision : ICollision
    {
        private IPlayer player;
        private Rectangle collision;

        public PlayerWallCollision(IPlayer player, in Rectangle collision)
        {
            this.player = player;
            this.collision = collision;
        }

        public void Handle()
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
