using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class NewGameState : IGameState
    {
        private LegendOfZelda game;
        private Texture2D RightCurtain;
        private Texture2D LeftCurtain;
        private int rightPos;
        private int leftPos;
        private int CurtainWidth;
        private int CurtainHeight;
        private int timer;
        public NewGameState(LegendOfZelda game)
        {
            this.game = game;
            timer = 0;
            RightCurtain = Textures.GetWinCurtain();
            LeftCurtain = Textures.GetWinCurtain();
            rightPos = 0;
            leftPos = game.GraphicsDevice.Viewport.Width / 2;
            CurtainWidth = game.GraphicsDevice.Viewport.Width / 2;
            CurtainHeight = game.GraphicsDevice.Viewport.Height;
            GameInit();
        }

        private void GameInit()
        {
            game.link = new GreenLink(game);
            game.playerKeyboard = GameSetup.CreatePlayerKeysController(game.link);
            game.mouse = new MouseController(game);
            game.keyboard = GameSetup.CreateGeneralKeysController(game);

            game.ProjectileManager = new ProjectileManager();
            game.CollisionDetector = new CollisionDetector(game.ProjectileManager);
            game.rooms = GameSetup.GenerateRoomList(game);
            game.roomIndex = 0;
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
            if(rightPos > -CurtainWidth)
            {
                rightPos -= 3;
                leftPos += 3;
            }
            else
            {
                game.PlayGame();
            }
            timer++;
        }

        public void Draw()
        {
            RoomSpriteFactory.Instance.CreateRoom0().Draw(game.spriteBatch);
            game.spriteBatch.Draw(RightCurtain, new Rectangle(rightPos, 0, CurtainWidth, CurtainHeight), new Rectangle(0, 0, RightCurtain.Width, RightCurtain.Height), Color.Black);
            game.spriteBatch.Draw(LeftCurtain, new Rectangle(leftPos, 0, CurtainWidth, CurtainHeight), new Rectangle(0, 0, LeftCurtain.Width, LeftCurtain.Height), Color.Black);
        }
    }
}
