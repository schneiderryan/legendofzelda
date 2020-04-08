using Microsoft.Xna.Framework;
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
        public LoseState(LegendOfZelda game)
        {
            this.game = game;
            this.tint = Color.White;
            this.tintTimer = 0;
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
                tint = Color.YellowGreen;
            }
            else if (tintTimer < 60)
            {
                tint = Color.LightGreen;
            }
            else if (tintTimer < 90)
            {
                tint = Color.Green;
            }
            else if (tintTimer < 120)
            {
                tint = Color.DarkGreen;
            }
            else if (tintTimer < 210)
            {
                tint = Color.Black;
            }
            else
            {
                game.NewGame();
            }
            tintTimer++;
        }

        public void Draw()
        {
            game.rooms[game.roomIndex].Draw(game.spriteBatch, tint);
            game.link.Draw(game.spriteBatch, Color.White);
        }
    }
}