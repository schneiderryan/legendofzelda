using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerMoveUpCommand : ICommand
    {
        private LegendOfZelda game;

        public PlayerMoveUpCommand(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.link.MoveUp();
        }
    }
}
