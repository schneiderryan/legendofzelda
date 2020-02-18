using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace LegendOfZelda
{
    class LegendOfZelda : Game
    {
        public IController playerKeyboard { get; set; }
        private IController enemyKeyboard;
        private IController keyboard;

        public List<IEnemy> enemies { get; set; }
        public int enemyIndex { get; set; }
        public List<IItem> items { get; set; }
        public int itemIndex { get; set; }

        public List<IProjectile> projectiles { get; set; }
        public IPlayer link { get; set; }

        public GraphicsDeviceManager graphics { get; set; }

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

            Projectiles = new List<IProjectile>();
            this.Link = new GreenLink(this);

            keyboard = GameSetup.CreateGeneralKeysController(this);
            PlayerKeyboard = GameSetup.CreatePlayerKeysController(link);
            enemyKeyboard = GameSetup.CreateEnemyKeysController(this);

            Items = GameSetup.GenerateItemList();
            Enemies = GameSetup.GenerateEnemyList();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Textures.LoadAllTextures(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            keyboard.Update();
            PlayerKeyboard.Update();
            enemyKeyboard.Update();

            Enemies[EnemyIndex].Update();
            Items[ItemIndex].Update();
            Link.Update();

            foreach (IProjectile projectile in Projectiles)
            {
                projectile.Update();
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            Enemies[EnemyIndex].Draw(spriteBatch);
            Items[ItemIndex].Draw(spriteBatch);
            Link.Draw(spriteBatch, Color.White);

            foreach (IProjectile projectile in Projectiles)
            {
                projectile.Draw(spriteBatch);
            }
            
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}