using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class ChangeRoomState : IGameState
    {
        private LegendOfZelda game;
        private int timer;
        private int x;
        private int y;
        private Texture2D background;
        public ChangeRoomState(LegendOfZelda game)
        {
            this.background = Textures.GetRoomSheet();
            x = game.xRoom;
            y = game.yRoom;
            this.timer = 0;
            this.game = game;

        }

        public void ToStart()
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

        public void ResumeGame()
        {
            game.state = new PlayState(game);
        }

        public void ChangeRoom()
        {
            
           
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
            System.Diagnostics.Debug.WriteLine("ChangeRoomState update called");
            
            if(timer < 15)
            {
                game.yRoom++;
                timer++;
                System.Diagnostics.Debug.WriteLine("move background up 1");
            }
            else
            {
                timer = 0;
                this.PlayGame();
                System.Diagnostics.Debug.WriteLine("in new room, load");
            }
            
            
        }

        public void Draw()
        {
            game.spriteBatch.Draw(background, new Rectangle(515, 886, 176, 256), new Rectangle(0, 0, 1543, 1063), Color.Black);
        }
    }
}
