using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    abstract class CharacterProjectileCollision : ICollision
    {
        protected IProjectileManager manager;
        protected IProjectile projectile;
        protected ICharacter character;
        protected Rectangle collision;

        public CharacterProjectileCollision(IProjectileManager manager,
                ICharacter character, IProjectile projectile, in Rectangle collision)
        {
            this.manager = manager;
            this.character = character;
            this.projectile = projectile;
            this.collision = collision;
        }

        protected virtual void HandleProjectileCollision()
        {
            if (projectile is BoomerangProjectile)
            {
                BoomerangProjectile bp = projectile as BoomerangProjectile;
                if (bp.Returned)
                {
                    manager.Remove(projectile);
                }
                else if (projectile.OwningTeam != character.Team)
                {
                    bp.BeginReturning();
                }
            }
            else if (projectile.OwningTeam != character.Team)
            {
                manager.Remove(projectile);
            }
        }

        public abstract void Handle();
    }
}
