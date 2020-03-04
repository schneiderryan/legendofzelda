using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{
    class LegendOfZelda : Game
    {
        public IList<IRoom> rooms;
        public int roomIndex = 0;

        public IPlayer link;
        public ISet<IProjectile> projectiles;
        public IList<IDespawnEffect> effects;
        public GraphicsDeviceManager graphics;

        private IController mouse;
        private IController keyboard;
        private IController playerKeyboard;

        private CollisionHandler collisionHandler;
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
            mouse = new MouseController(this);
            keyboard = GameSetup.CreateGeneralKeysController(this);

            projectiles = new HashSet<IProjectile>();
            effects = new List<IDespawnEffect>();
            collisionHandler = new CollisionHandler(effects);
            rooms = GameSetup.GenerateRoomList(this);
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

            foreach (IProjectile projectile in projectiles)
            {
                projectile.Update();
            }
            foreach (IDespawnEffect effect in effects)
            {
                effect.Update();
            }

            collisionHandler.Handle(rooms[roomIndex], projectiles, link);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);
            
            rooms[roomIndex].Draw(spriteBatch);
            link.Draw(spriteBatch, Color.White);
            rooms[roomIndex].DrawOverlay(spriteBatch);
            
            Debug.DrawHitbox(spriteBatch, link.Footbox);
            Debug.DrawHitbox(spriteBatch, link.Hitbox);
            Debug.DrawHitbox(spriteBatch, link.LeftAttackBox);
            Debug.DrawHitbox(spriteBatch, link.RightAttackBox);
            Debug.DrawHitbox(spriteBatch, link.UpAttackBox);
            Debug.DrawHitbox(spriteBatch, link.DownAttackBox);

            foreach (IProjectile projectile in projectiles)
            {
                projectile.Draw(spriteBatch);
                Debug.DrawHitbox(spriteBatch, projectile.Hitbox);
            }
            foreach (IDespawnEffect effect in effects)
            {
                effect.Draw(spriteBatch);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }

    }
}
