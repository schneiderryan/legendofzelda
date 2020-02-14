using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerUseArrowCommand : ICommand
    {
        private LegendOfZelda game;

        public PlayerUseArrowCommand(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            Bow bow = new Bow()
            {
                HasArrow = true
            };
            game.link.UseItem(bow);
        }
    }
}
