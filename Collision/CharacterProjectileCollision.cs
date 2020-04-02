using Microsoft.Xna.Framework;
using System.Collections.Generic;


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

        protected static void Knockback(ICharacter character, in Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y == character.Hitbox.Y)
                {
                    character.Y += 5;
                }
                else
                {
                    character.Y -= 5;
                }
            }
            else
            {
                if (collision.X == character.Hitbox.X)
                {
                    character.X += 5;
                }
                else
                {
                    character.X -= 5;
                }
            }

            // TO DO: handle bound checking thingies
        }

        public abstract void Handle();
    }
}
