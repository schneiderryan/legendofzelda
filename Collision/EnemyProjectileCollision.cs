using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class EnemyProjectileCollision : CharacterProjectileCollision
    {
        private ISet<IEnemy> enemiesToDepsawn;
        private CollisionHandler handler;

        public EnemyProjectileCollision(ISet<IProjectile> projectilesToDespawn,
                ISet<IEnemy> enemiesToDepsawn, CollisionHandler handler)
            : base(projectilesToDespawn)
        {
            this.enemiesToDepsawn = enemiesToDepsawn;
            this.handler = handler;
        }

        public void Handle(IEnemy enemy, IProjectile projectile, in Rectangle collision)
        {
            if(!(enemy is Trap) && !(enemy is Fire))
            {
                HandleProjectileCollision(enemy, projectile);
                if ((projectile.OwningTeam == enemy.Team)
                    || (projectile is BoomerangProjectile
                        && enemy is Goriya)) // goriya is immune to boomerangs
                {
                    return;
                }

                System.Diagnostics.Debug.WriteLine("call take damage");
                enemy.TakeDamage(projectile.Damage);
                if (!handler.playerTouchingBlockorWall)
                {
                    Knockback(enemy, collision);
                }

                if (enemy.isDead)
                {
                    enemiesToDepsawn.Add(enemy);
                }
            }
        }
    }
}
