using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayState : IGameState
    {
        private LegendOfZelda game;
        public PlayState(LegendOfZelda game)
        {
            this.game = game;
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

            foreach (IProjectile projectile in game.projectiles)
            {
                projectile.Update();
            }
            foreach (IDespawnEffect effect in game.effects)
            {
                effect.Update();
            }

            game.collisionHandler.Handle(game.rooms[game.roomIndex], game.projectiles, game.link);
        }

        public void Draw()
        {
            game.rooms[game.roomIndex].Draw(game.spriteBatch);
            game.link.Draw(game.spriteBatch, Color.White);
            game.rooms[game.roomIndex].DrawOverlay(game.spriteBatch);

            foreach (IProjectile projectile in game.projectiles)
            {
                projectile.Draw(game.spriteBatch);
                Debug.DrawHitbox(game.spriteBatch, projectile.Hitbox);
            }
            foreach (IDespawnEffect effect in game.effects)
            {
                effect.Draw(game.spriteBatch);
            }
        }
    }
}
