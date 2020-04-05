using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{
    class LegendOfZelda : Game
    {
        public IGameState state;

        public IList<IRoom> rooms;
        public int roomIndex;

        public IPlayer link;
        public ISet<IProjectile> projectiles;
        public IList<IDespawnEffect> effects;
        public GraphicsDeviceManager graphics;
        public int xRoom = 515;
        public int yRoom = 886;

        public IController mouse;
        public IController keyboard;
        public IController playerKeyboard;

        public CollisionHandler collisionHandler;
        public SpriteBatch spriteBatch;

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

            state = new StartMenuState(this);
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Textures.LoadAllTextures(Content, GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            state.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);
            GraphicsDevice.Clear(Color.White);

            state.Draw();

            spriteBatch.End();

            base.Draw(gameTime);
        }

        public void ToStart()
        {
            state.ToStart();
        }

        public void PlayGame()
        {
            state.PlayGame();
        }

        public void PauseGame()
        {
            state.PauseGame();
        }

        public void ResumeGame()
        {
            state.ResumeGame();
        }

        public void ChangeRoom()
        {
            state.ChangeRoom();
        }

        public void WinGame()
        {
            state.WinGame();
        }

        public void LoseGame()
        {
            state.LoseGame();
        }

        public void SelectItem()
        {
            state.SelectItem();
        }

    }
}