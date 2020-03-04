using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class PlayerEnemyCollision
    {
        private ISet<IEnemy> enemiesToDepsawn;

        public PlayerEnemyCollision(ISet<IEnemy> enemiesToDepsawn)
        {
            this.enemiesToDepsawn = enemiesToDepsawn;
        }
        public void Handle(IPlayer player, IEnemy enemy, in Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y == player.Hitbox.Y)
                {
                    if (!player.Direction.Equals("up") || !player.IsAttacking())
                    {
                        player.TakeDamage();
                    }
                    player.Y += 5;
                }
                else
                {
                    if (!player.Direction.Equals("down") || !player.IsAttacking())
                    {
                        player.TakeDamage();
                    }
                    player.Y -= 5;
                }
            }
            else
            {
                if (collision.X == player.Hitbox.X)
                {
                    if (!player.Direction.Equals("left") || !player.IsAttacking())
                    {
                        player.TakeDamage();
                    }
                    player.X += 5;
                }
                else
                {
                    if (!player.Direction.Equals("right") || !player.IsAttacking())
                    {
                        player.TakeDamage();
                    }
                    player.X -= 5;
                }
            }

            if (player.Direction.Equals(player.Direction) && player.IsAttacking())
            {
                enemy.TakeDamage();
                switch (player.Direction)
                {
                    case "left":
                        enemy.X -= 5;
                        break;
                    case "right":
                        enemy.X += 5;
                        break;
                    case "up":
                        enemy.Y -= 5;
                        break;
                    case "down":
                        enemy.Y += 5;
                        break;
                }

                if (enemy.isDead)
                {
                    enemiesToDepsawn.Add(enemy);
                }
            }
        }

    }
}
