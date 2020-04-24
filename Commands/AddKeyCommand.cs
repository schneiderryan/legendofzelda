using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class AddKeyCommand : ICommand
    {
        private IPlayer player;

        public AddKeyCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.Inventory.Keys++;
        }
    }
}