using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class PlayerProjectileCollision : CharacterProjectileCollision
    {

        public PlayerProjectileCollision(ISet<IProjectile> projectilesToDespawn)
            : base (projectilesToDespawn)
        {
            // nothing needed here
        }

        public void Handle(IPlayer player, IProjectile projectile,
                in Rectangle collision)
        {
            HandleProjectileCollision(player, projectile);
            if (projectile.OwningTeam != player.Team)
            {
                player.TakeDamage();
                Knockback(player, collision);
            }
        }

    }
}
