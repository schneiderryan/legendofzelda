using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class PlayerEnemyCollision
    {
        private CollisionHandler handler;
        private const double BUMP_DAMAGE = 0.5;

        public PlayerEnemyCollision(CollisionHandler handler)
        {
            this.handler = handler;
        }

        public void Handle(IPlayer player, in Rectangle collision)
        {
            int playerXKnockback = 0;
            int playerYKnockback = 0;
            if (collision.Width > collision.Height)
            {
                if (collision.Y == player.Hitbox.Y)
                {
                    if (!player.Direction.Equals("up") || !player.IsAttacking())
                    {
                        player.TakeDamage(BUMP_DAMAGE);
                    }
                    playerYKnockback = 5;
                }
                else
                {
                    if (!player.Direction.Equals("down") || !player.IsAttacking())
                    {
                        player.TakeDamage(BUMP_DAMAGE);
                    }
                    playerYKnockback = -5;
                }
            }
            else
            {
                if (collision.X == player.Hitbox.X)
                {
                    if (!player.Direction.Equals("left") || !player.IsAttacking())
                    {
                        player.TakeDamage(BUMP_DAMAGE);
                    }
                    playerXKnockback = 5;
                }
                else
                {
                    if (!player.Direction.Equals("right") || !player.IsAttacking())
                    {
                        player.TakeDamage(BUMP_DAMAGE);
                    }
                    playerXKnockback = -5;
                }
            }
            if (!this.handler.playerTouchingBlockorWall)
            {
                player.X += playerXKnockback;
                player.Y += playerYKnockback;
            }
        }

    }
}
