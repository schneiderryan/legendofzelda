using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

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
        private int updateTimer;
        private Texture2D HUD;
        private Texture2D HUDBackground;
        public NewGameState(LegendOfZelda game)
        {
            MediaPlayer.Stop();
            game.music = new MusicLoop();
            this.game = game;
            updateTimer = 1;
            RightCurtain = Textures.GetWinCurtain();
            LeftCurtain = Textures.GetWinCurtain();
            rightPos = 0;
            leftPos = game.GraphicsDevice.Viewport.Width / 2;
            CurtainWidth = game.GraphicsDevice.Viewport.Width / 2;
            CurtainHeight = game.GraphicsDevice.Viewport.Height;
            this.HUD = Textures.GetHUD();
            this.HUDBackground = Textures.GetHUDBackground();
            GameInit();
        }

        private void GameInit()
        {
            game.rooms = GameSetup.GenerateRoomList(game);
            game.roomIndex = 1;

            game.Link = new GreenLink(game, game.MyPlayerID);
            game.cone = new ConeOfVision(game.Link);
            game.playerKeyboard = GameSetup.CreatePlayerMovementController(game.Link);
            game.mouse = new MouseController(game);
            game.keyboard = GameSetup.CreateSinglePressKeysController(game);

            game.ProjectileManager.Clear();

            game.CollisionDetector = new CollisionDetector(game.ProjectileManager, game);
            game.xRoom = 515;
            game.yRoom = 826;
           game.Link.Inventory.Rupees = (int)game.shopBalance;
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
            game.music.Play();
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
            //Nothing to do
        }

        public void ResumeGame()
        {
            //Nothing to do
        }

        public void SelectMode()
        {
            //Do nothing
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

        public void CloseItemShop()
        {
            //
        }

        public void OpenItemShop()
        {
            //
        }

        public void Update()
        {

            if(rightPos > -CurtainWidth)

            {
                rightPos -= 4;
                leftPos += 4;
            }
            else
            {
                game.PlayGame();
            }

            if(updateTimer > 0)

            {
                game.rooms[game.roomIndex].Update();
                game.cone.Update();
            }
            updateTimer--;
        }

        public void Draw()
        {
            //RoomSpriteFactory.Instance.CreateRoom0().Draw(game.spriteBatch);
            game.rooms[game.roomIndex].Draw(game.spriteBatch, Color.White);
            game.Link.Draw(game.spriteBatch, Color.White);
            game.rooms[game.roomIndex].DrawOverlay(game.spriteBatch, Color.White);
            if (game.currentMode.Equals("hard"))
            {
                game.cone.Draw(game.spriteBatch);
            }
            game.spriteBatch.Draw(HUDBackground, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 512, 120), Color.Black);
            game.spriteBatch.Draw(HUD, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 256, 56), Color.White);
            game.spriteBatch.Draw(RightCurtain, new Rectangle(rightPos, 0, CurtainWidth, CurtainHeight), new Rectangle(0, 0, RightCurtain.Width, RightCurtain.Height), Color.Black);
            game.spriteBatch.Draw(LeftCurtain, new Rectangle(leftPos, 0, CurtainWidth, CurtainHeight), new Rectangle(0, 0, LeftCurtain.Width, LeftCurtain.Height), Color.Black);
        }
    }

}

