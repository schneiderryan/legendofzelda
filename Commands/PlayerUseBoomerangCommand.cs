using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerUseBoomerangCommand : ICommand
    {
        private IPlayer player;

        public PlayerUseBoomerangCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            //player.UseItem(new Boomerang());
        }
    }
}
