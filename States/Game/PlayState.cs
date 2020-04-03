using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class PlayState : IGameState
    {
        private LegendOfZelda game;
        public PlayState(LegendOfZelda game)
        {
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
            game.state = new ChangeRoomState(game);
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
        }
    }
}
