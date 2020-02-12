using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerUseThrowingSwordCommand : ICommand
    {
        private IPlayer player;

        public PlayerUseThrowingSwordCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.UseItem(new WoodSword());
        }
    }
}
