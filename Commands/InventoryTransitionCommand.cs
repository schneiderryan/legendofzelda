using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class InventoryTransitionCommand : ICommand
    {
        private LegendOfZelda game;
        private bool open = false;
        public InventoryTransitionCommand(LegendOfZelda game)
        {
            this.game = game;

        }

        public void Execute()
        {
            if (open)
            {
                game.CloseInventory();
                open = false;
            }
            else
            {
                game.OpenInventory();
                open = true;
            }
        }
    }
}
