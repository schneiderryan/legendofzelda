using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class PlayState : IGameState
    {
        private LegendOfZelda game;
        private Texture2D HUD;
        private Texture2D HUDBackground;
        public PlayState(LegendOfZelda game)
        {
            this.HUD = Textures.GetHUD();
            this.HUDBackground = Textures.GetHUDBackground();
            this.game = game;
            game.music.Play();
           
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
            //Nothing to do
        }

        public void SelectMode()
        {
            //Do nothing
        }

        public void PauseGame()
        {
            game.state = new PauseState(game);
        }

        public void OpenInventory()
        {
            game.hud.offset = 360;
            game.state = new TransitionToInventoryState(game);
        }

        public void CloseInventory()
        {
            //Nothing to do
        }

        public void ResumeGame()
        {
            //Nothing to do
        }

        public void ChangeRoom()
        {
            game.state = new ChangeRoomState(game.Link.Direction, game.Link, game);
        }

        public void WinGame()
        {
            game.state = new WinState(game);
        }

        public void LoseGame()
        {
            game.state = new LoseState(game);
        }

        public void SelectItem()
        {
            game.state = new SelectItemState(game);
        }


        public void CloseItemShop()
        {
            // 
        }

        public void OpenItemShop()
        {
            game.state = new ItemShopState(game);
        }


        public void Update()
        {
            game.mouse.Update();
            game.keyboard.Update();
            game.playerKeyboard.Update();

            game.rooms[game.roomIndex].Update();
            game.cone.Update();
            game.music.Update();

            game.ProjectileManager.Update();

            IEnumerable<ICollision> collisions = game.CollisionDetector.Detect();
            CollisionHandler.Handle(collisions);
        }

        public void Draw()
        {
            game.rooms[game.roomIndex].Draw(game.spriteBatch, Color.White);
            game.Link.Draw(game.spriteBatch, Color.White);
            game.rooms[game.roomIndex].DrawOverlay(game.spriteBatch, Color.White);
            game.ProjectileManager.Draw(game.spriteBatch, Color.White);
            if (game.currentMode.Equals("hard"))
            {
                game.cone.Draw(game.spriteBatch);
            }
            game.ProjectileManager.Draw(game.spriteBatch, Color.White);
            game.spriteBatch.Draw(HUDBackground, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 256, 56), Color.Black);
            game.spriteBatch.Draw(HUD, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 256, 56), Color.White);
        }
    }
}