using System.Collections.Generic;

namespace LegendOfZelda
{
    internal class ResetCommand : ICommand
    {
        private LegendOfZelda game;

        public ResetCommand(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.state = new StartMenuState(game);
            game.hud.offset = 0;
        }
    }
}
