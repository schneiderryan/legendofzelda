using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class StartMenuState : IGameState
    {
        private LegendOfZelda game;
        private Texture2D StartMenu;
        private int counter;
        private int delay;
        public StartMenuState(LegendOfZelda game)
        {
            this.game = game;
            StartMenu = Textures.GetStartMenu();
            counter = 0;
            delay = 7;
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
            if (Mouse.GetState().LeftButton.HasFlag(ButtonState.Pressed))
            {
                game.state = new PlayState(game);
            }
            delay--;
            if(delay == 0)
            {
                counter++;
                if (counter > 3)
                {
                    counter = 0;
                }
                delay = 5;
            }
        }

        public void Draw()
        {
            Rectangle destination = new Rectangle(0, 0, game.GraphicsDevice.Viewport.Width, game.GraphicsDevice.Viewport.Height);
            switch (counter)
            {
                case 0:
                    game.spriteBatch.Draw(StartMenu, destination, new Rectangle(3, 5, 255, 239), Color.White);
                    break;
                case 1:
                    game.spriteBatch.Draw(StartMenu, destination, new Rectangle(262, 5, 255, 239), Color.White);
                    break;
                case 2:
                    game.spriteBatch.Draw(StartMenu, destination, new Rectangle(3, 248, 255, 239), Color.White);
                    break;
                case 3:
                    game.spriteBatch.Draw(StartMenu, destination, new Rectangle(262, 248, 255, 239), Color.White);
                    break;
            }
        }
    }
}
