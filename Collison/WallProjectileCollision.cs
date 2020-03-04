using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class WallProjectileCollision
    {
        private ISet<IProjectile> toDespawn;
        public WallProjectileCollision(ISet<IProjectile> toDespawn)
        {
            this.toDespawn = toDespawn;
        }

        public void Handle(IProjectile projectile, in Rectangle collision)
        {
            // wait for the projcetile to inside a wall before despawning
            if (collision.Contains(projectile.Hitbox.Center))
            {
                if (projectile is BoomerangProjectile)
                {
                    (projectile as BoomerangProjectile).BeginReturning();
                }
                else
                {
                    toDespawn.Add(projectile);
                }
            }
        }

    }
}
