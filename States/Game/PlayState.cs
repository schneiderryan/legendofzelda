using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayState : IGameState
    {
        private LegendOfZelda game;
        public PlayState(LegendOfZelda game)
        {
            this.game = game;
        }

        public void PlayGame()
        {
            //Nothing to do
        }

        public void PauseGame()
        {
            game.state = new PauseState(game);
        }

        public void ResumeGame()
        {
            //Nothing to do
        }

        public void ChangeRoom()
        {
            game.state = new ChangeRoomState(game);
        }

        public void WinGame()
        {
            game.state = new WinState(game);
        }

        public void LoseGame()
        {
            game.state = new LoseState(game);
        }

        public void SelectItem()
        {
            game.state = new SelectItemState(game);
        }

        public void Update()
        {
            //Figure out later
        }
    }
}
