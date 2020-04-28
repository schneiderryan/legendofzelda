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
            if(game.shopBalance >= game.itemPrices[game.currentShopItem])
            {
                ItemShopState.displayError = false;
                System.Diagnostics.Debug.WriteLine("purchase item: " + game.currentShopItem + "\n cost: " + game.itemPrices[game.currentShopItem]);
                game.shopBalance -= game.itemPrices[game.currentShopItem];
                game.Link.Inventory.Rupees -= (int)game.itemPrices[game.currentShopItem];
                if(game.currentShopItem == "sword")
                {
                    WhiteSword newSword = new WhiteSword();
                    newSword.Collect(this.game.Link);
                }
                else if(game.currentShopItem == "heart")
                {
                    Heart newheart = new Heart();
                    newheart.Collect(this.game.Link);
                }
                else
                {
                    this.game.Link.Inventory.HasBluePotion = true;
                }
                System.Diagnostics.Debug.WriteLine("new balance: " + game.shopBalance);
                
            }
            else
            {
                ItemShopState.displayError = true;
                System.Diagnostics.Debug.WriteLine("Insufficient funds. Please find more rupees by killing enemies.");
                
            }
            
        }
    }
}
