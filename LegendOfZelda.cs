using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace LegendOfZelda
{
    public class LegendOfZelda : Game
    {
        private IController PlayerKeyboard;
        private IController enemyKeyboard;
        private IController keyboard;

        private List<IEnemy> Enemies;
        private int EnemyIndex = 0;
        private List<IItem> Items;
        private int ItemIndex = 0;

        private List<IProjectile> Projectiles;
        private IPlayer Link;

        private GraphicsDeviceManager graphics;

        private SpriteBatch spriteBatch;

        public IPlayer link
        {
            get { return Link; }
            set { Link = value; }
        }

        public List<IEnemy> enemies
        {
            get { return Enemies; }
        }

        public List<IProjectile> projectiles
        {
            get { return Projectiles; }
        }

        public int itemIndex
        {
            get { return ItemIndex; }
            set { ItemIndex = value; }
        }

        public List<IItem> items
        {
            get { return Items; }
        }

        public int enemyIndex
        {
            get { return EnemyIndex; }
            set { EnemyIndex = value; }
        }

        public IController playerKeyboard
        {
            get { return PlayerKeyboard; }
            set { PlayerKeyboard = value; }
        }

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