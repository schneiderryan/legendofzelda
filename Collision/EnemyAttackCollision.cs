using System.Collections.Generic;


namespace LegendOfZelda
{
    class EnemyAttackCollision : ICollision
    {
        private ICollection<IEnemy> enemies;
        private IEnemy enemy;
        private IPlayer player;
        private string attackDirection;

        public EnemyAttackCollision(ICollection<IEnemy> enemies, IEnemy enemy,
                IPlayer player, string attackDirection)
        {
            this.enemies = enemies;
            this.enemy = enemy;
            this.player = player;
            this.attackDirection = attackDirection;
        }

        public void Handle()
        {
            if (player.Direction.Equals(attackDirection) && player.IsAttacking()
                    && !(enemy is Trap) && !(enemy is Fire))
            {
                
                enemy.TakeDamage(player.Inventory.Sword.Damage);
                switch (attackDirection)
                {
                    case "up":
                        enemy.Knockback(0, -CollideableObject.KNOCKBACK);
                        break;
                    case "down":
                        enemy.Knockback(0, CollideableObject.KNOCKBACK);
                        break;
                    case "right":
                        enemy.Knockback(CollideableObject.KNOCKBACK, 0);
                        break;
                    case "left":
                        enemy.Knockback(-CollideableObject.KNOCKBACK, 0);
                        break;
                }

                if (enemy.isDead)
                {
                    enemies.Remove(enemy);
                }
            }
        }
    }
}