using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerNPCCollision : ICollision
    {
        private IPlayer player;
        private INPC npc;
        private String attackDirection;
        private LegendOfZelda game;
        public PlayerNPCCollision(IPlayer player, INPC npc, String attackDirection, LegendOfZelda game)
        {
            this.player = player;
            this.npc = npc;
            this.attackDirection = attackDirection;
            this.game = game;
        }

        public void Handle()
        {
            if (player.Direction.Equals(attackDirection) && player.IsAttacking() && (npc is OldMan))
            {
                game.OldManDamaged = true;
            }
        }
    }
}
