using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class SelectModeCommand : ICommand
    {

        private LegendOfZelda game;
        private String direction;
        private int currentIndex;
        private int i;

        public SelectModeCommand(LegendOfZelda game, string direction)
        {
            this.game = game;
            this.direction = direction;
        }
        public void Execute()
        {
            if (game.state.ToString().Equals("LegendOfZelda.SelectGameState"))
            {
                currentIndex = 0;
                i = 0;
                string[] modes = { "normal", "hard", "sudden death", "puzzle" };
                foreach (string mode in modes)
                {
                    if (mode.Equals(game.currentMode))
                    {
                        currentIndex = i;
                    }
                    i++;
                }
                if (direction.ToString().Equals("down"))
                {
                    currentIndex++;
                    if (currentIndex >= modes.Length)
                    {
                        currentIndex = 0;
                    }
                }
                else if (direction.ToString().Equals("up"))
                {
                    currentIndex--;
                    if (currentIndex < 0)
                    {
                        currentIndex = modes.Length - 1;
                    }
                }
                game.currentMode = modes[currentIndex];
            }
        }
    }
}
