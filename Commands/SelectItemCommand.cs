using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class SelectItemCommand : ICommand
    {

        private LegendOfZelda game;
        private String direction;
        private int currentIndex;
        private int i;

        public SelectItemCommand(LegendOfZelda game, string direction)
        {
            this.game = game;
            this.direction = direction;
        }
        public void Execute()
        {
            if (game.state.ToString().Equals("LegendOfZelda.ItemShopState"))
            {
                currentIndex = 0;
                i = 0;
                string[] items = { "sword", "heart", "bluepotion" };
                foreach (string item in items)
                {
                    if (item.Equals(game.currentShopItem))
                    {
                        currentIndex = i;
                    }
                    i++;
                }
                if (direction.ToString().Equals("down"))
                {
                    currentIndex++;
                    if (currentIndex >= items.Length)
                    {
                        currentIndex = 0;
                    }
                }
                else if (direction.ToString().Equals("up"))
                {
                    currentIndex--;
                    if (currentIndex < 0)
                    {
                        currentIndex = items.Length - 1;
                    }
                }
                game.currentShopItem = items[currentIndex];
            }
        }
    }
}
