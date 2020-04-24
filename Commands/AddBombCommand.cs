using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class AddBombCommand : ICommand
    {
        private IPlayer player;

        public AddBombCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.Inventory.Bombs++;
        }
    }
}