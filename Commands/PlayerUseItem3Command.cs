using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerUseItem3Command : ICommand
    {
        private IPlayer player;

        public PlayerUseItem3Command(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.UseItem3();
        }
    }
}
