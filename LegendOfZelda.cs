using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace LegendOfZelda
{
      class LegendOfZelda : Game
    {
        public IController playerKeyboard;

        private IController mouse;
        private IController keyboard;

        public LevelLoader levelLoader;
        public List<IPlayer> players;

        public List<IEnemy> enemies;
        public int enemyIndex;

        public List<IItem> items;
        public int itemIndex;

        public List<IProjectile> projectiles;
        public IPlayer link;
        public List<IRoom> rooms;
        public int roomIndex = 0;


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
            players = new List<IPlayer>();
            players.Add(link);

            /*levelLoader = new LevelLoader("TestLevel.csv", this);*/

            mouse = new MouseController(this);
            keyboard = GameSetup.CreateGeneralKeysController(this);
            foreach(IPlayer player in players)
            {
                playerKeyboard = GameSetup.CreatePlayerKeysController(player);
            }

            /*items = levelLoader.loadItems();
            enemies = levelLoader.loadEnemies();*/

            /*players = levelLoader.loadPlayers();*/
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Textures.LoadAllTextures(Content, GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            mouse.Update();
            keyboard.Update();
            playerKeyboard.Update();

            rooms[roomIndex].Update();

            foreach(IEnemy enemy in enemies)
            {
                enemy.Update();
            }

            foreach(IItem item in items)
            {
                item.Update();
            }

            foreach (IPlayer player in players)
            {
                player.Update();
            }

            foreach (IProjectile projectile in projectiles)
            {
                projectile.Update();
            }

            // collision stuffs
            foreach (IItem item in items)
            {
                foreach (IPlayer player in players)
                {
                    // check collision
                    // if intersects then
                    // Item.Pickup(IPlayer) ?
                }
            }

            foreach (IEnemy enemy in enemies)
            {
                foreach (IPlayer player in players)
                {
                    // check collision
                    // if intersects then
                    // do things
                }
            }

            foreach (IProjectile p in projectiles)
            {
                foreach (IPlayer player in players)
                {
                    if (p.Hitbox.Intersects(player.Hitbox))
                    {
                        // do things
                    }
                }
            }

            // do wall/block collisions - this is the only one where sides matter

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            rooms[roomIndex].Draw(spriteBatch, Color.White);

            foreach (IEnemy enemy in enemies)
            {
                enemy.Draw(spriteBatch);
            }

            foreach (IItem item in items)
            {
                item.Draw(spriteBatch);
                Debug.DrawHitbox(spriteBatch, item.Hitbox);
            }

            foreach (IPlayer player in players)
            {
                player.Draw(spriteBatch, Color.White);
                Debug.DrawHitbox(spriteBatch, player.Hitbox);
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