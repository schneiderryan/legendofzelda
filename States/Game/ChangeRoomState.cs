using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class ChangeRoomState : IGameState
    {
        private LegendOfZelda game;
        public ChangeRoomState(LegendOfZelda game)
        {
            this.game = game;
        }

        public void ToStart()
        {
            //Nothing to do
        }

        public void NewGame()
        {
            //Nothing to do
        }

        public void PlayGame()
        {
            game.state = new PlayState(game);
        }

        public void PauseGame()
        {
            //Nothing to do
        }

        public void ResumeGame()
        {
            game.state = new PlayState(game);
        }

        public void ChangeRoom()
        {
            if (game.link is DamagedLink)
            {
                game.link = (game.link as DamagedLink).InnerLink;
            }
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

        public void Draw()
        {

        }
    }
}
