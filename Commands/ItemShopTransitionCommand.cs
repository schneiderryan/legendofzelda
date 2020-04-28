using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class ItemShopTransitionCommand : ICommand
    {
        private LegendOfZelda game;
        private bool open = false;
        public ItemShopTransitionCommand(LegendOfZelda game)
        {
            this.game = game;

        }

        public void Execute()
        {
            
            if (open)
            {
                game.CloseItemShop();
                open = false;
               
            }
            else
            {
                game.OpenItemShop();
                open = true;
                
            }
        }
    }
}
