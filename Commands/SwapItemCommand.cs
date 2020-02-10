using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class SwapItemCommand : ICommand
    {
        private LegendOfZelda game1;
        private String swapDirection;
        private int index;

        public SwapItemCommand(LegendOfZelda game1, String direction)
        {
            this.game1 = game1;
            this.swapDirection = direction;
        }
        
        public void Execute()
        {
            if (swapDirection.Equals("next"))
            {
                if (game1.items.Count - 1 <= game1.currentIndex)
                {
                    game1.currentIndex = 0;
                } else
                {

                    game1.currentIndex++;
                }
            } else if (swapDirection.Equals("previous"))
            {
                if (0 >= game1.currentIndex)
                {
                    game1.currentIndex = game1.items.Count - 1;
                }
                else
                {

                    game1.currentIndex--;
                }
            }
            game1.currentItem = game1.items[game1.currentIndex];
        }
    }
}
