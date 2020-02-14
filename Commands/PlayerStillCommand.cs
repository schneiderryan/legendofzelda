using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerStillCommand : ICommand
    {
        private LegendOfZelda game;

        public PlayerStillCommand(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            this.game.link.BeStill();
        }
    }
}
