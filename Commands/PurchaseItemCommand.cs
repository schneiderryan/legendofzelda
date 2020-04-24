using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PurchaseItemCommand : ICommand
    {

        LegendOfZelda game;

        public PurchaseItemCommand(LegendOfZelda game)
        {
            this.game = game;

        }

        public void Execute()
        {
            if(game.shopBalance > game.itemPrices[game.currentShopItem])
            {
                System.Diagnostics.Debug.WriteLine("purchase item: " + game.currentShopItem + "\n cost: " + game.itemPrices[game.currentShopItem]);
                game.shopBalance -= game.itemPrices[game.currentShopItem];
                System.Diagnostics.Debug.WriteLine("new balance: " + game.shopBalance);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Insufficient funds. Please choose an item that costs less than your balance of "+game.shopBalance);
                
            }
            
        }
    }
}
