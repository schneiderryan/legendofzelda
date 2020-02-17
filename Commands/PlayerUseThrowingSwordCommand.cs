using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class PlayerUseThrowingSwordCommand : ICommand
    {
        private IPlayer player;

        public PlayerUseThrowingSwordCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.UseProjectile(new SwordProjectile(player.direction, player.xPos, player.yPos));
        }
    }
}
