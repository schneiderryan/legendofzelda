using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class SelectGameState : IGameState
    {
        private LegendOfZelda game;
        private ISprite selectScreen;
        private Texture2D screen;
        private ModeSelector selector;

        public SelectGameState(LegendOfZelda game)
        {
            this.game = game;
            this.selectScreen = FontSpriteFactory.GetModeScreen();
            selectScreen.X = 40;
            selectScreen.Y = 40;
            this.screen = Textures.GetBlankTexture();
            selector = new ModeSelector(this.game);
            game.keyboard = GameSetup.CreateMenuKeysController(game);

        }

        public void ChangeRoom()
        {
            //Do nothing
        }

        public void CloseInventory()
        {
            //Do nothing
        }

        public void LoseGame()
        {
            //Do nothing
        }

        public void NewGame()
        {
            game.state = new NewGameState(game);
        }

        public void OpenInventory()
        {
            //Do nothing
        }

        public void PauseGame()
        {
             //Do nothing
        }

        public void PlayGame()
        {
            //Do nothing
        }

        public void ResumeGame()
        {
            //Do nothing
        }

        public void SelectMode()
        {
            //Do nothing
        }

        public void SelectItem()
        {
            //Do nothing
        }

        public void ToStart()
        {
            //Do nothing
        }

        public void WinGame()
        {
            //Do nothing
        }

        public void Update()
        {
            selector.Update();
            game.keyboard.Update();
        }

        public void Draw()
        {
            game.spriteBatch.Draw(screen, new Rectangle(0, 0, 512, 1020), new Rectangle(0, 0, 512, 120), Color.Black);
            selectScreen.Draw(game.spriteBatch);
            selector.Draw();
        }

    }
}
