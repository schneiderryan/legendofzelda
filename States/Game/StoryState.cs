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
            clickDelay = 5;
        }

        public void ToStart()
        {
            //Nothing to do
        }

        public void NewGame()
        {
            game.state = new NewGameState(game);
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
                game.NewGame();
            }
            clickDelay--;

            story.Y -= 2;
            if (story.Y == -story.Box.Height + game.GraphicsDevice.Viewport.Height)
            {
                game.NewGame();
            }
        }

        public void Draw()
        {
            game.GraphicsDevice.Clear(Color.Black);
            story.Draw(game.spriteBatch);
        }
    }
}