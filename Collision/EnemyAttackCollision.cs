using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class EnemyAttackCollision
    {
        private ISet<IEnemy> enemiesToDespawn;
        private CollisionHandler handler;

        public EnemyAttackCollision(ISet<IEnemy> enemiesToDespawn, CollisionHandler handler)
        {
            this.enemiesToDespawn = enemiesToDespawn;
            this.handler = handler;
        }

        public void Handle(IEnemy enemy, IPlayer player, String attackDirection)
        {
            if (player.Direction.Equals(attackDirection) && player.IsAttacking() && !(enemy is Trap) && !(enemy is Fire))
            {
                enemy.TakeDamage();
                int xKnockback = 0;
                int yKnockback = 0;
                switch (attackDirection)
                {
                    case "left":
                        xKnockback = -5;
                        break;
                    case "right":
                        xKnockback = 5;
                        break;
                    case "up":
                        yKnockback = -5;
                        break;
                    case "down":
                        yKnockback = 5;
                        break;
                }
                if (!this.handler.enemyTouchingBlockorWall)
                {
                    enemy.X += xKnockback;
                    enemy.Y += yKnockback;
                }

                if (enemy.isDead)
                {
                    enemiesToDespawn.Add(enemy);
                    
                }
            }
        }
    }
}
