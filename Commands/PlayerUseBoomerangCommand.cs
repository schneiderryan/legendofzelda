using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerUseBoomerangCommand : ICommand
    {
        private LegendOfZelda game;

        public PlayerUseBoomerangCommand(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.link.UseProjectile(new BoomerangProjectile(game.link.direction, game.link.xPos, game.link.yPos));
        }
    }
}
