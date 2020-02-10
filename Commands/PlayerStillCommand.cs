using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerStillCommand : ICommand
    {
        private IPlayer player;

        public PlayerStillCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            this.player.BeStill();
        }
    }
}
