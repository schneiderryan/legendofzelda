using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerMoveRightCommand : ICommand
    {
        private LegendOfZelda game;

        public PlayerMoveRightCommand(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.link.MoveRight();
        }
    }
}
