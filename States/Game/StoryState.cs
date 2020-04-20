using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class StoryState : IGameState
    {
        private LegendOfZelda game;
        private ISprite story;
        private int clickDelay;
        public StoryState(LegendOfZelda game)
        {
            this.game = game;
            game.GraphicsDevice.Clear(Color.Black);
            this.story = MiscSpriteFactory.Instance.CreateStory();
            story.Y = game.GraphicsDevice.Viewport.Height;
            clickDelay = 15;
        }

        public void ToStart()
        {
            //Nothing to do
        }

        public void NewGame()
        {
            //added in select game state
            //game.state = new NewGameState(game);
        }

        public void PlayGame()
        {
            //Nothing to do
        }

        public void PauseGame()
        {
            //Nothing to do
        }

        public void OpenInventory()
        {
            //Nothing to do
        }

        public void CloseInventory()
        {
            //Nothing to do
        }

        public void ResumeGame()
        {
            //Nothing to do
        }

        public void SelectMode()
        {
            game.state = new SelectGameState(game);
        }

        public void WinGame()
        {
            //Nothing to do
        }

        public void LoseGame()
        {
            //Nothing to do
        }

        public void ChangeRoom()
        {
            //Nothing to do
        }

        public void SelectItem()
        {
            //Nothing to do
        }

        public void Update()
        {
            if (Mouse.GetState().LeftButton.HasFlag(ButtonState.Pressed) && clickDelay <= 0)
            {
                game.SelectMode();
            }
            clickDelay--;

            story.Y -= 2;
            if (story.Y == -story.Box.Height + game.GraphicsDevice.Viewport.Height)
            {
                game.SelectMode();
            }
        }

        public void Draw()
        {
            game.GraphicsDevice.Clear(Color.Black);
            story.Draw(game.spriteBatch);
        }
    }

}
