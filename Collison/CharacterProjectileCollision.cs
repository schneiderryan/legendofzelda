using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    abstract class CharacterProjectileCollision
    {
        protected ISet<IProjectile> projectilesToDespawn;

        public CharacterProjectileCollision(ISet<IProjectile> projectilesToDespawn)
        {
            this.projectilesToDespawn = projectilesToDespawn;
        }

        protected virtual void HandleProjectileCollision(ICharacter character,
                IProjectile projectile)
        {
            if (projectile is BoomerangProjectile)
            {
                BoomerangProjectile bp = projectile as BoomerangProjectile;
                if (bp.Returned)
                {
                    projectilesToDespawn.Add(projectile);
                }
                else
                {
                    bp.BeginReturning();
                }
            }
            else if (projectile.OwningTeam != character.Team)
            {
                projectilesToDespawn.Add(projectile);
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
        }

    }
}
