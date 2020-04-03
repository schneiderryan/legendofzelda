using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class PlayerEnemyCollision : ICollision
    {
        private IPlayer player;
        private Rectangle collision;
        private const double BUMP_DAMAGE = 0.5;

        public PlayerEnemyCollision(IPlayer player, in Rectangle collision)
        {
            this.player = player;
            this.collision = collision;
        }

        public void Handle()
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y == player.Hitbox.Y)
                {
                    if (!player.Direction.Equals("up") || !player.IsAttacking())
                    {
                        player.TakeDamage(BUMP_DAMAGE);
                        player.Knockback(0, CollideableObject.KNOCKBACK);
                    }
                }
                else
                {
                    if (!player.Direction.Equals("down") || !player.IsAttacking())
                    {
                        player.TakeDamage(BUMP_DAMAGE);
                        player.Knockback(0, -CollideableObject.KNOCKBACK);
                    }
                }
            }
            else
            {
                if (collision.X == player.Hitbox.X)
                {
                    if (!player.Direction.Equals("left") || !player.IsAttacking())
                    {
                        player.TakeDamage(BUMP_DAMAGE);
                        player.Knockback(CollideableObject.KNOCKBACK, 0);
                    }
                }
                else
                {
                    if (!player.Direction.Equals("right") || !player.IsAttacking())
                    {
                        player.TakeDamage(BUMP_DAMAGE);
                        player.Knockback(-CollideableObject.KNOCKBACK, 0);
                    }
                }
            }
        }

    }
}
