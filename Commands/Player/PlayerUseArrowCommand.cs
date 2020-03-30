using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerUseArrowCommand : ICommand
    {
        private IPlayer player;

        public PlayerUseArrowCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.Inventory.BowAndArrow.Use(player);
        }
    }
}
