using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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

        public void PauseGame()
        {
            game.state = new PauseState(game);
        }

        public void ResumeGame()
        {
            //Nothing to do
        }

        public void ChangeRoom()
        {
            game.state = new ChangeRoomState(game.link.Direction, game);
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

        public void Update()
        {
            game.mouse.Update();
            game.keyboard.Update();
            game.playerKeyboard.Update();

            game.rooms[game.roomIndex].Update();
            game.link.Update();

            game.ProjectileManager.Update();

            IEnumerable<ICollision> collisions =
                    game.CollisionDetector.Detect(game.rooms[game.roomIndex], game.link);
            CollisionHandler.Handle(collisions);
        }

        public void Draw()
        {
            game.rooms[game.roomIndex].Draw(game.spriteBatch, Color.White);
            game.link.Draw(game.spriteBatch, Color.White);
            game.rooms[game.roomIndex].DrawOverlay(game.spriteBatch, Color.White);
            game.ProjectileManager.Draw(game.spriteBatch, Color.White);
            game.spriteBatch.Draw(HUDBackground, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 256, 56), Color.Black);
            game.spriteBatch.Draw(HUD, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 256, 56), Color.White);
        }
    }
}