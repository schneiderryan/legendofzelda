using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class StartGameCommand : ICommand
    {

        LegendOfZelda game;

        public StartGameCommand(LegendOfZelda game)
        {
            this.game = game;

        }

        public void Execute()
        {
            if (game.state.ToString().Equals("LegendOfZelda.SelectGameState"))
            {
                game.state = new NewGameState(game);
            }
        }
    }
}
