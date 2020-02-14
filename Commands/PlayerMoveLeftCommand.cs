using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerMoveLeftCommand : ICommand
    {
        private LegendOfZelda game;

        public PlayerMoveLeftCommand(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.link.MoveLeft();
        }
    }
}
