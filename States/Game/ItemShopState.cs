using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    class ItemShopState : IGameState
    {
        private LegendOfZelda game;
        private ISprite itemShopScreen;
        private Texture2D screen;
        private ItemShopSelector selector;
        private ISprite zeroBalanceSprite;
        public static bool displayError;

        public ItemShopState(LegendOfZelda game)
        {
            this.game = game;
            this.itemShopScreen = FontSpriteFactory.GetItemShopScreen();
            this.zeroBalanceSprite = MiscSpriteFactory.Instance.CreateZeroBalanceSprite();
            
            zeroBalanceSprite.X = 0;
            zeroBalanceSprite.Y = 370;
            this.screen = Textures.GetBlankTexture();
            selector = new ItemShopSelector(this.game);
            
            displayError = false;
        }

        public void ChangeRoom()
        {
            //Do nothing
        }

        public void CloseInventory()
        {
            //Do nothing
        }

        public void LoseGame()
        {
            //Do nothing
        }

        public void NewGame()
        {
           //
        }

        public void OpenInventory()
        {
            //Do nothing
        }

        public void PauseGame()
        {
            //Do nothing
        }

        public void PlayGame()
        {
            //Do nothing
        }

        public void ResumeGame()
        {
            //Do nothing
        }

        public void SelectMode()
        {
            //Do nothing
        }

        public void SelectItem()
        {
            //Do nothing
        }

        public void ToStart()
        {
            //Do nothing
        }

        public void WinGame()
        {
            //Do nothing
        }

        public void CloseItemShop()
        {
            game.state = new PlayState(game);
        }

        public void OpenItemShop()
        {
            //
        }

        public void Update()
        {
            selector.Update();
            game.keyboard.Update();
        }

        public void Draw()
        {

            game.spriteBatch.Draw(screen, new Rectangle(0, 0, 512, 1020), new Rectangle(0, 0, 512, 120), Color.Black);
            itemShopScreen.Draw(game.spriteBatch);
            selector.Draw();
            if (displayError)
            {
                zeroBalanceSprite.Draw(game.spriteBatch);
            }
        }

    }
}
