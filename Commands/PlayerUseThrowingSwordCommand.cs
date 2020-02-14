using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerUseThrowingSwordCommand : ICommand
    {
        private LegendOfZelda game;

        public PlayerUseThrowingSwordCommand(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.link.UseProjectile(new SwordProjectile(game.link.direction, game.link.xPos, game.link.yPos));
        }
    }
}
