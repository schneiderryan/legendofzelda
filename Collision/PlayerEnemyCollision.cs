using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class PlayerEnemyCollision : ICollision
    {
        private IPlayer player;
        private Rectangle collision;
        private IEnemy enemy;
        private LegendOfZelda game;
        private const double BUMP_DAMAGE = 0.5;

        public PlayerEnemyCollision(IPlayer player, in Rectangle collision, IEnemy enemy, LegendOfZelda game)
        {
            this.player = player;
            this.collision = collision;
            this.enemy = enemy;
            this.game = game;
        }

        public void Handle()
        {
            if (this.enemy is LFWallmaster)
            {
                enemy.State = new DraggingLFWallmasterState(enemy, player, game);
                player.BeStill();
            }
            else if (this.enemy is RFWallmaster)
            {
                enemy.State = new DraggingRFWallmasterState(enemy, player, game);
                player.BeStill();
            }
            else
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
}