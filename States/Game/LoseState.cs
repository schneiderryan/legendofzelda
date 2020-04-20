using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class LoseState : IGameState
    {
        private LegendOfZelda game;
        private Color tint;
        private int tintTimer;
        private Texture2D HUDBackground;
        public LoseState(LegendOfZelda game)
        {
            this.game = game;
            this.tint = Color.White;
            this.tintTimer = 0;
            this.HUDBackground = Textures.GetHUDBackground();
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

        public void OpenInventory()
        {
            //Nothing to do
        }

        public void CloseInventory()
        {
            //Nothing to do
        }

        public void SelectMode()
        {
            //Do nothing
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
            if (tintTimer < 30)
            {
                tint = Color.Blue;
            }
            else if (tintTimer < 60)
            {
                tint = Color.BlueViolet;
            }
            else if (tintTimer < 90)
            {
                tint = Color.Violet;
            }
            else if (tintTimer < 120)
            {
                tint = Color.DarkViolet;
            }
            else if (tintTimer < 300)
            {
                tint = Color.Black;
            }
            else
            {
                game.NewGame();
            }
            tintTimer++;

            game.link.Update();
            game.cone.Update();
        }

        public void Draw()
        {
            game.rooms[game.roomIndex].Draw(game.spriteBatch, tint);
            game.spriteBatch.Draw(HUDBackground, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 512, 120), Color.Black);
            game.link.Draw(game.spriteBatch, Color.White);
            if (game.currentMode.Equals("hard"))
            {
                game.cone.Draw(game.spriteBatch);
            }
        }
    }
}