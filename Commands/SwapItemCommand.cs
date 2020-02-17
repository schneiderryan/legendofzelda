using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class SwapItemCommand : ICommand
    {
        private LegendOfZelda game;
        private string swapDirection;

        public SwapItemCommand(LegendOfZelda game, string direction)
        {
            this.game = game;
            this.swapDirection = direction;
        }
        
        public void Execute()
        {
            if (swapDirection.Equals("next"))
            {
                if (game.items.Count - 1 == game.itemIndex)
                {
                    game.itemIndex = 0;
                }
                else
                {
                    game.itemIndex++;
                }
            }
            else if (swapDirection.Equals("previous"))
            {
                if (0 == game.itemIndex)
                {
                    game.itemIndex = game.items.Count - 1;
                }
                else
                {
                    game.itemIndex--;
                }
            }
        }
    }
}
