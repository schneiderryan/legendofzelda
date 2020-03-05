using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class PlayerProjectileCollision : CharacterProjectileCollision
    {
        private CollisionHandler handler;
        public PlayerProjectileCollision(ISet<IProjectile> projectilesToDespawn, CollisionHandler handler)
            : base (projectilesToDespawn)
        {
            this.handler = handler;
        }

        public void Handle(IPlayer player, IProjectile projectile,
                in Rectangle collision)
        {
            HandleProjectileCollision(player, projectile);
            if (projectile.OwningTeam != player.Team)
            {
                player.TakeDamage();
                if (!handler.playerTouchingBlockorWall)
                {
                    Knockback(player, collision);
                }
            }
        }

    }
}
