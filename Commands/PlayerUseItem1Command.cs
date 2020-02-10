using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerUseItem1Command : ICommand
    {
        private IPlayer player;

        public PlayerUseItem1Command(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.UseItem1();
        }
    }
}
