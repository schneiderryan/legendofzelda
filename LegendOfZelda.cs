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
        public GraphicsDeviceManager graphics;

        private IController mouse;
        private IController keyboard;
        private IController playerKeyboard;

        private IList<IDespawnEffect> effects;
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
            ProjectileCollisionDetector.Register(projectiles, effects);

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
            for (int i = 0; i < effects.Count; i++)
            {
                if (effects[i] == null || effects[i].Finished)
                {
                    effects.RemoveAt(i);
                    i--;
                }
                else
                {
                    effects[i].Update();
                }
            }

            ProjectileCollisionDetector.HandleCollisions(rooms[roomIndex], link);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);
            
            rooms[roomIndex].Draw(spriteBatch);
            link.Draw(spriteBatch, Color.White);
            rooms[roomIndex].DrawOverlay(spriteBatch);
            
            Debug.DrawHitbox(spriteBatch, link.Hitbox);

            foreach (IProjectile projectile in projectiles)
            {
                projectile.Draw(spriteBatch);
                Debug.DrawHitbox(spriteBatch, projectile.Hitbox);
            }
            foreach (IDespawnEffect effect in effects)
            {
                if (effect != null)
                {
                    effect.Draw(spriteBatch);
                }
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}