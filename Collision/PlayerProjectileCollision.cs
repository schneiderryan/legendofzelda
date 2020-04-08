using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class PlayerProjectileCollision : CharacterProjectileCollision
    {
        public PlayerProjectileCollision(ProjectileManager manager, IPlayer player,
                IProjectile projectile, in Rectangle collision)
            : base(manager, player, projectile, collision)
        {
            // nothing needed
        }

        public override void Handle()
        {
            IPlayer player = character as IPlayer;
            HandleProjectileCollision();
            if (projectile.OwningTeam != player.Team)
            {
                player.TakeDamage(projectile.Damage);
            }
        }

    }
}