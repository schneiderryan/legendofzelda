using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace LegendOfZelda
{
    class LegendOfZelda : Game
    {
        private IController mouse;
        private IController keyboard;
        private IController playerKeyboard;
        public List<IRoom> rooms;
        public int roomIndex = 0;

        public IPlayer link;
        public List<IProjectile> projectiles;

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

            this.link = new GreenLink(this);
            playerKeyboard = GameSetup.CreatePlayerKeysController(link);

            rooms = GameSetup.GenerateRoomList(this);

            mouse = new MouseController(this);
            keyboard = GameSetup.CreateGeneralKeysController(this);

            projectiles = new List<IProjectile>();
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
            link.Update();

            foreach(IProjectile projectile in projectiles)
            {
                projectile.Update();
            }

            // collision stuffs

            foreach (IProjectile p in projectiles)
            {
                if (p.Hitbox.Intersects(link.Hitbox))
                {
                    // do things
                }
            }


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            rooms[roomIndex].Draw(spriteBatch, Color.White);
            link.Draw(spriteBatch, Color.White);

            Debug.DrawHitbox(spriteBatch, link.Hitbox);

            foreach (IProjectile projectile in projectiles)
            {
                projectile.Draw(spriteBatch);
                Debug.DrawHitbox(spriteBatch, projectile.Hitbox);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}