using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace LegendOfZelda
{
    class WinState : IGameState
    {
        private LegendOfZelda game;
        private bool bw;
        private int delay = 10;
        private int timer;
        public WinState(LegendOfZelda game)
        {
            this.game = game;
            bw = false;
            timer = 0;
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
            delay--;
            if (delay == 0)
            {
                bw = !bw;
                delay = 8;
            }
            timer++;
        }

        public void Draw()
        {
            if (!bw || timer > 100)
            {
                game.rooms[game.roomIndex].Draw(game.spriteBatch);
            }
            else
            {
                Texture2D bwroom = Textures.GetBWRoom();
                game.spriteBatch.Draw(bwroom, new Rectangle(0, -1, game.GraphicsDevice.Viewport.Width+2, game.GraphicsDevice.Viewport.Height+2), new Rectangle(0, 0, bwroom.Width, bwroom.Height), Color.White);
            }
            game.link.Draw(game.spriteBatch, Color.White);
        }
    }
}
