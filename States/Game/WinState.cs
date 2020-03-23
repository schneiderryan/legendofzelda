using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class WinState : IGameState
    {
        private LegendOfZelda game;
        public WinState(LegendOfZelda game)
        {
            this.game = game;
        }

        public void PlayGame()
        {
            //Nothing to do
        }

        public void PauseGame()
        {
            //Nothing to do
        }

        public void ResumeGame()
        {
            //Nothing to do
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

        public void Draw()
        {

        }
    }
}
