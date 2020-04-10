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
        private Texture2D RightCurtain;
        private Texture2D LeftCurtain;
        private int rightPos;
        private int leftPos;
        private int CurtainWidth;
        private int CurtainHeight;
        private int finalDelay;
        private Texture2D HUD;
        public WinState(LegendOfZelda game)
        {
            this.game = game;
            bw = false;
            timer = 0;
            RightCurtain = Textures.GetWinCurtain();
            LeftCurtain = Textures.GetWinCurtain();
            rightPos = -game.GraphicsDevice.Viewport.Width / 2 - 20;
            leftPos = game.GraphicsDevice.Viewport.Width;
            CurtainWidth = game.GraphicsDevice.Viewport.Width / 2 + 20;
            CurtainHeight = game.GraphicsDevice.Viewport.Height;
            finalDelay = 0;
            this.HUD = Textures.GetHUD();
        }

        public void ToStart()
        {
            this.game.state = new StartMenuState(this.game);
        }

        public void NewGame()
        {
            //Nothing to do
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
            if (timer > 200)
            {
                if(rightPos <= -20)
                {
                    rightPos += 3;
                    leftPos -= 3;
                }
            }
            if(rightPos > -20)
            {
                finalDelay++;
            }
            if(finalDelay > 75)
            {
                game.ToStart();
            }
            game.link.Update();
            timer++;
        }

        public void Draw()
        {
            if (!bw || timer > 150)
            {
                game.rooms[game.roomIndex].Draw(game.spriteBatch, Color.White);
            }
            else
            {
                Texture2D bwroom = Textures.GetBWRoom();
                game.spriteBatch.Draw(bwroom, new Rectangle(0, -1, game.GraphicsDevice.Viewport.Width+2, game.GraphicsDevice.Viewport.Height+2), new Rectangle(0, 0, bwroom.Width, bwroom.Height), Color.White);
            }
            game.spriteBatch.Draw(HUD, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 512, 120), Color.Black);
            game.spriteBatch.Draw(RightCurtain, new Rectangle(rightPos, 0, CurtainWidth, CurtainHeight), new Rectangle(0, 0, RightCurtain.Width, RightCurtain.Height), Color.Black);
            game.spriteBatch.Draw(LeftCurtain, new Rectangle(leftPos, 0, CurtainWidth, CurtainHeight), new Rectangle(0, 0, LeftCurtain.Width, LeftCurtain.Height), Color.Black);
            game.link.Draw(game.spriteBatch, Color.White);
            foreach (IItem item in game.rooms[game.roomIndex].Items)
            {
                item.Update();
            }
        }
    }
}
