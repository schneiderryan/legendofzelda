﻿using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class PlayerEnemyCollision
    {
        private ISet<IEnemy> enemiesToDepsawn;
        private CollisionHandler handler;

        public PlayerEnemyCollision(ISet<IEnemy> enemiesToDepsawn, CollisionHandler handler)
        {
            this.enemiesToDepsawn = enemiesToDepsawn;
            this.handler = handler;
        }
        public void Handle(IPlayer player, IEnemy enemy, in Rectangle collision)
        {
            int playerXKnockback = 0;
            int playerYKnockback = 0;
            if (collision.Width > collision.Height)
            {
                if (collision.Y == player.Hitbox.Y)
                {
                    if (!player.Direction.Equals("up") || !player.IsAttacking())
                    {
                        player.TakeDamage();
                    }
                    playerYKnockback = 5;
                }
                else
                {
                    if (!player.Direction.Equals("down") || !player.IsAttacking())
                    {
                        player.TakeDamage();
                    }
                    playerYKnockback = -5;
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
                    playerXKnockback = 5;
                }
                else
                {
                    if (!player.Direction.Equals("right") || !player.IsAttacking())
                    {
                        player.TakeDamage();
                    }
                    playerXKnockback = -5;
                }
            }
            if (!this.handler.playerTouchingBlockorWall)
            {
                player.X += playerXKnockback;
                player.Y += playerYKnockback;
            }
        }

    }
}
