using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace LegendOfZelda
{
    public class LegendOfZelda : Game
    {
        IController playerKeyboard;
        IController enemyKeyboard;
        IController keyboard;

        public List<IEnemy> enemies;
        public int enemyIndex = 0;
        public List<IItem> items;
        public int itemIndex = 0;

        public List<IProjectile> projectiles;
        public IPlayer link;

        public GraphicsDeviceManager graphics;

        private SpriteBatch spriteBatch;

        public LegendOfZelda()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.Window.Title = "The Legend of Zelda";

            projectiles = new List<IProjectile>();
            this.link = new GreenLink(this);

            keyboard = GameSetup.CreateGeneralKeysController(this);
            playerKeyboard = GameSetup.CreatePlayerKeysController(this);
            enemyKeyboard = GameSetup.CreateEnemyKeysController(this);

            items = GameSetup.GenerateItemList();
            enemies = GameSetup.GenerateEnemyList();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Textures.LoadAllTextures(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            keyboard.Update();
            playerKeyboard.Update();
            enemyKeyboard.Update();

            enemies[enemyIndex].Update();
            items[itemIndex].Update();
            link.Update();

            foreach (IProjectile projectile in projectiles)
            {
                projectile.Update();
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            enemies[enemyIndex].Draw(spriteBatch);
            items[itemIndex].Draw(spriteBatch);
            link.Draw(spriteBatch, Color.White);

            foreach (IProjectile projectile in projectiles)
            {
                projectile.Draw(spriteBatch);
            }
            
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}