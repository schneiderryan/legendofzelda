using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class EnemyProjectileCollision : CharacterProjectileCollision
    {
        private ICollection<IEnemy> enemies;


        public EnemyProjectileCollision(IProjectileManager manager,

                ICollection<IEnemy> enemies, IEnemy enemy, IProjectile projectile,
                in Rectangle collision)
            : base(manager, enemy, projectile, collision)
        {
            this.enemies = enemies;
        }

        public override void Handle()
        {
            IEnemy enemy = character as IEnemy;

            if(!(enemy is Trap))
            {
                HandleProjectileCollision();
                if ((projectile.OwningTeam == enemy.Team)
                    // goriya is immune to boomerangs
                    || (projectile is BoomerangProjectile && enemy is Goriya))
                {
                    return;
                }

                System.Diagnostics.Debug.WriteLine(enemy.GetType().ToString()
                    + " took " + projectile.Damage + " damage");

                enemy.TakeDamage(projectile.Damage);

                if (enemy.isDead)
                {
                    enemies.Remove(enemy);
                }
            }
        }
    }
}