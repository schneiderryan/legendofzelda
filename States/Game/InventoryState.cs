using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;

namespace LegendOfZelda
{
    class InventoryState : IGameState
    {
        private LegendOfZelda game;
        private Texture2D HUD;
        private Texture2D HUDBackground;
        private Texture2D Inventory;
        private Invent invent; 
        public InventoryState(LegendOfZelda game)
        {
            this.HUD = Textures.GetHUD();
            this.HUDBackground = Textures.GetHUDBackground();
            this.Inventory = Textures.GetInventory();
            this.game = game;
            this.invent = new Invent(game);


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
            //Nothing to do
        }

        public void CloseInventory()
        {
            this.game.state = new TransitionFromInventoryState(this.game);
        }

        public void SelectMode()
        {
            //Do nothing
        }

        public void CloseItemShop()
        {
            //
        }

        public void OpenItemShop()
        {
            //
        }

        public void ResumeGame()
        {
            //game.state = new TransitionFromInventoryState(game);
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
            game.mouse.Update();
            game.keyboard.Update();
            game.hud.Update();
            invent.Update();
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
            game.ProjectileManager.Draw(game.spriteBatch, Color.White);
            game.spriteBatch.Draw(HUDBackground, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 256, 56), Color.Black);
            game.spriteBatch.Draw(HUD, new Rectangle(0, 360, 512, 120), new Rectangle(0, 0, 256, 56), Color.White);
            game.spriteBatch.Draw(Inventory, new Rectangle(0, -40, 512, 400), new Rectangle(0, 0, 246, 176), Color.White);
            invent.Draw();
        }

        
    }
}
