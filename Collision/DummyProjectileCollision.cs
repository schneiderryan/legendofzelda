using System.Collections.Generic;


namespace LegendOfZelda
{
    class DummyProjectileCollision : ICollision
    {
        private ICollection<IProjectile> projectiles;
        private IProjectile projectile;

        public DummyProjectileCollision(ICollection<IProjectile> projectiles,
            IProjectile projectile)
        {
            this.projectiles = projectiles;
            this.projectile = projectile;
        }

        public void Handle()
        {
            projectiles.Remove(projectile);
        }
    }

}

