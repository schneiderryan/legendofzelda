using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace LegendOfZelda
{
    class LegendOfZelda : Game
    {
        public IController playerKeyboard;
        private IController enemyKeyboard;
        private IController keyboard;

        public LevelLoader levelLoader;
        public List<IPlayer> players;
        public List<IEnemy> enemies;
        public int enemyIndex;
        public List<IItem> items;
        public int itemIndex;

        public List<IProjectile> projectiles;
        public IPlayer link;

        public GraphicsDeviceManager graphics;

        private SpriteBatch spriteBatch;
        private List<List<ISet<ICollideable>>> grid;

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

            levelLoader = new LevelLoader("TestLevel.csv", this);
            players = levelLoader.loadPlayers();

            keyboard = GameSetup.CreateGeneralKeysController(this);
            foreach(IPlayer player in players)
            {
                playerKeyboard = GameSetup.CreatePlayerKeysController(player);
            }
            enemyKeyboard = GameSetup.CreateEnemyKeysController(this);

            items = levelLoader.loadItems();
            enemies = levelLoader.loadEnemies();

            grid = new List<List<ISet<ICollideable>>>();
            int i = 0;
            while (i < 12)
            {
                grid.Add(new List<ISet<ICollideable>>());
                int j = 0;
                while (j < 7)
                {
                    grid[i].Add(new HashSet<ICollideable>());
                    j++;
                }
                i++;
            }
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
            //enemyKeyboard.Update();

            foreach(IEnemy enemy in enemies)
            {
                enemy.Update();
            }

            foreach(IItem item in items)
            {
                item.Update();
            }

            //enemies[enemyIndex].Update();
            //items[itemIndex].Update();

            foreach (IPlayer player in players)
            {
                player.Update();
            }

            foreach (IProjectile projectile in projectiles)
            {
                projectile.Update();
            }

            List<ICollideable> objs = new List<ICollideable>();
            objs.AddRange(items);

            foreach (ICollideable c in objs)
            {
                c.Collide(link);
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            //enemies[enemyIndex].Draw(spriteBatch);
            //items[itemIndex].Draw(spriteBatch);

            foreach (IEnemy enemy in enemies)
            {
                enemy.Draw(spriteBatch);
            }

            foreach (IItem item in items)
            {
                item.Draw(spriteBatch);
            }

            foreach (IPlayer player in players)
            {
                player.Draw(spriteBatch, Color.White);
            }

            foreach (IProjectile projectile in projectiles)
            {
                projectile.Draw(spriteBatch);
            }
            
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}