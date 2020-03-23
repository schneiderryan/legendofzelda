using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class SelectItemState : IGameState
    {
        private LegendOfZelda game;
        public SelectItemState(LegendOfZelda game)
        {
            this.game = game;
        }

        public void PlayGame()
        {
            game.state = new PlayState(game);
        }

        public void PauseGame()
        {
            game.state = new PauseState(game);
        }

        public void ResumeGame()
        {
            game.state = new PlayState(game);
        }

        public void ChangeRoom()
        {
            //Nothing to do
        }

        public void WinGame()
        {
            //Nothing to do
        }

        public void LoseGame()
        {
            //Nothing to do
        }

        public void SelectItem()
        {
            //Nothing to do
        }

        public void Update()
        {
            //Figure out later
        }
    }
}
