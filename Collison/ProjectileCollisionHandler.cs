using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace LegendOfZelda
{
    static class ProjectileCollisionHandler
    {
        private static ICollection<IProjectile> projectiles;
        private static ICollection<IDespawnEffect> effects;

        public static void Register(ICollection<IProjectile> projectiles,
                ICollection<IDespawnEffect> effects)
        {
            ProjectileCollisionHandler.projectiles = projectiles;
            ProjectileCollisionHandler.effects = effects;
        }

        //public static void EnemyProjectileCollision(IEnemy enemy, in Rectangle collision)
        //{
            // do things
        //}

        public static void ProjectileCharacterCollision(ICharacter character)
        {
            //character.TakeDamage();
        }

        public static void EnemyProjectileCollision(IEnemy enemy,
                IProjectile projectile, in Rectangle collision)
        {
           //if (projectile.OwningTeam.Equals(enemy.Team))
           // {
              //  return;
            //}
            
            //enemy.TakeDamage();
            Despawn(projectile);

            if (collision.Width > collision.Height)
            {
                if (collision.Y != enemy.Hitbox.Y)
                {
                    
                        
                        enemy.TakeDamage();
                        enemy.Y -= collision.Height + 15;


                }
                else
                {
                    
                    enemy.TakeDamage();
                    enemy.Y += collision.Height + 15;

                }
            }
            else
            {
                if (collision.X != enemy.Hitbox.X)
                {
                        
                        enemy.TakeDamage();
                        enemy.X -= collision.Width + 15;

                }
                else
                {
                        
                        enemy.TakeDamage();
                        enemy.X += collision.Width + 15;

                }
            }
        }

        public static bool CharacterProjectile(ICharacter character,
                IProjectile projectile)
        {
            bool result = false;
            if (projectile is BoomerangProjectile)
            {
                BoomerangProjectile bp = projectile as BoomerangProjectile;
                bp.Returned = true;
                result = bp.IsOwner(character);
            }
            if (projectile.OwningTeam != character.Team)
            {
                result = true;
                ProjectileCharacterCollision(character);
            }
            return result;
        }

        public static void Despawn(ICollection<IProjectile> despawn)
        {
            foreach (IProjectile deadProjectile in despawn)
            {
                Despawn(deadProjectile);
            }
        }

        private static void Despawn(IProjectile projectile)
        {
            projectiles.Remove(projectile);
            effects.Add(projectile.GetDespawnEffect());
        }
    }
}
