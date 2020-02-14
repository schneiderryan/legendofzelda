using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerAttackCommand : ICommand
    {
        private LegendOfZelda game;

        public PlayerAttackCommand(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.link.Attack();
        }
    }
}
