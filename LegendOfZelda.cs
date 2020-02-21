using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace LegendOfZelda
{
    class LegendOfZelda : Game
    {
        public IController playerKeyboard;

        public IController mouse;

        private IController enemyKeyboard;
        private IController keyboard;

        public LevelLoader levelLoader;
        public List<IPlayer> players;

        public List<IEnemy> enemies;
        public int enemyIndex;

        public List<IItem> items;
        public int itemIndex;

        public int roomIndex = 0;

        


        public List<IProjectile> projectiles;
        public IPlayer link;
        public List<IRoom> rooms;
       

        public GraphicsDeviceManager graphics;

        private SpriteBatch spriteBatch;

        public LegendOfZelda()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 352; 
            graphics.PreferredBackBufferWidth = 512;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.Window.Title = "The Legend of Zelda";

            projectiles = new List<IProjectile>();

            rooms = GameSetup.GenerateRoomList(this);
            this.link = new GreenLink(this);


            levelLoader = new LevelLoader("TestLevel.csv", this);
            players = levelLoader.loadPlayers();


            mouse = new MouseController(this);
            keyboard = GameSetup.CreateGeneralKeysController(this);
            foreach(IPlayer player in players)
            {
                playerKeyboard = GameSetup.CreatePlayerKeysController(player);
            }
            enemyKeyboard = GameSetup.CreateEnemyKeysController(this);


            
            items = levelLoader.loadItems();
            enemies = levelLoader.loadEnemies();

        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Textures.LoadAllTextures(Content);
            

        }

        protected override void Update(GameTime gameTime)
        {
            mouse.Update();
            keyboard.Update();
            playerKeyboard.Update();
            //enemyKeyboard.Update();


            rooms[roomIndex].Update();
           

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

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            rooms[roomIndex].Draw(spriteBatch, Color.White);
            


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