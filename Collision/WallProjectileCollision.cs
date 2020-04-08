using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class WallProjectileCollision : ICollision
    {
        private IProjectileManager manager;
        private IProjectile projectile;
        private Rectangle collision;

        public WallProjectileCollision(IProjectileManager manager,
                IProjectile projectile, in Rectangle collision)
        {
            this.manager = manager;
            this.projectile = projectile;
            this.collision = collision;
        }

        public void Handle()
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
                    manager.Remove(projectile);
                }
            }
        }

    }
}