using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class AddRupeesCommand : ICommand
    {
        private IPlayer player;

        public AddRupeesCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.Inventory.Rupees += 10;
        }
    }
}
