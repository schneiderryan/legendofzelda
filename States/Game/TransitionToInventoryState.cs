﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    class TransitionToInventoryState : IGameState
    {
        private LegendOfZelda game;
        private int pos;
        private int updateTimer;
        private Texture2D HUD;
        private Texture2D HUDBackground;
        private Texture2D Inventory;

        public TransitionToInventoryState(LegendOfZelda game)
        {
            this.game = game;
            updateTimer = 1;
            pos = 0;
            this.HUD = Textures.GetHUD();
            this.HUDBackground = Textures.GetHUDBackground();
            this.Inventory = Textures.GetInventory();
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

        public void OpenInventory()
        {
            game.state = new InventoryState(game);
        }

        public void CloseInventory()
        {
            //Nothing to do
        }
        public void CloseItemShop()
        {
            //
        }

        public void OpenItemShop()
        {
            //
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
            if (-400 + pos < -40)
            {
                pos += 6;
            }
            else
            {
                OpenInventory();
            }

            if (updateTimer > 0)

            {
                game.rooms[game.roomIndex].Update();
                game.cone.Update();
            }
            updateTimer--;
        }

        public void Draw()
        {
            game.rooms[game.roomIndex].Draw(game.spriteBatch, Color.White);
            game.Link.Draw(game.spriteBatch, Color.White);
            game.rooms[game.roomIndex].DrawOverlay(game.spriteBatch, Color.White);
            if (game.currentMode.Equals("hard"))
            {
                game.cone.Draw(game.spriteBatch);
            }
            game.spriteBatch.Draw(HUDBackground, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 512, 120), Color.Black);
            game.spriteBatch.Draw(HUD, new Rectangle(0, pos, 512, 120), new Rectangle(0, 0, 256, 56), Color.White);
            game.spriteBatch.Draw(Inventory, new Rectangle(0, -400 + pos, 512, 400), new Rectangle(0, 0, 246, 176), Color.White);
        }
    }

}

