using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class StartMenuState : IGameState
    {
        private LegendOfZelda game;
        public StartMenuState(LegendOfZelda game)
        {
            this.game = game;
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
            if (Mouse.GetState().LeftButton.HasFlag(ButtonState.Pressed))
            {
                game.state = new PlayState(game);
            }
        }

        public void Draw()
        {
            
        }
    }
}
