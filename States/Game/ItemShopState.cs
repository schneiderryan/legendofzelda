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

        public ItemShopState(LegendOfZelda game)
        {
            this.game = game;
            this.itemShopScreen = FontSpriteFactory.GetItemShopScreen();
            itemShopScreen.X = 40;
            itemShopScreen.Y = 40;
            this.screen = Textures.GetBlankTexture();
            selector = new ItemShopSelector(this.game);
            game.keyboard = GameSetup.CreateItemShopKeysController(game);
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
        }

    }
}
