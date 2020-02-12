using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerUseItem2Command : ICommand
    {
        private IPlayer player;

        public PlayerUseItem2Command(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.UseItem2();
        }
    }
}
