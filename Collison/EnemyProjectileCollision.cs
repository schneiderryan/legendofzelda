using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class EnemyProjectileCollision : CharacterProjectileCollision
    {
        private ISet<IEnemy> enemiesToDepsawn;

        public EnemyProjectileCollision(ISet<IProjectile> projectilesToDespawn,
                ISet<IEnemy> enemiesToDepsawn)
            : base(projectilesToDespawn)
        {
            this.enemiesToDepsawn = enemiesToDepsawn;
        }

        public void Handle(IEnemy enemy, IProjectile projectile, in Rectangle collision)
        {
            HandleProjectileCollision(enemy, projectile);
            if ((projectile.OwningTeam == enemy.Team)
                || (projectile is BoomerangProjectile
                    && enemy is Goriya)) // goriya is immune to boomerangs
            {
                return;
            }

            System.Diagnostics.Debug.WriteLine("call take damage");
            enemy.TakeDamage();
            Knockback(enemy, collision);

            if (enemy.isDead)
            {
                enemiesToDepsawn.Add(enemy);
            }

        }
    }
}
