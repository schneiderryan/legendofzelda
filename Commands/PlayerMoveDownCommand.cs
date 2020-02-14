using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerMoveDownCommand : ICommand
    {
        private LegendOfZelda game;

        public PlayerMoveDownCommand(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.link.MoveDown();
        }
    }
}
