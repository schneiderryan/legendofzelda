using System.Collections.Generic;
using Microsoft.Xna.Framework;


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
                Rectangle dummyCollision = new Rectangle();
                switch (attackDirection)
                {
                    case "up":
                    case "down":
                        dummyCollision.Width = 1;
                        break;
                    case "right":
                    case "left":
                        dummyCollision.Height = 1;
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
