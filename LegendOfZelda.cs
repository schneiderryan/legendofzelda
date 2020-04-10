﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace LegendOfZelda
{
    class LegendOfZelda : Game
    {
        public IGameState state;

        public IList<IRoom> rooms;
        public int roomIndex;

        public IPlayer link;

        public IProjectileManager ProjectileManager { get; set; }

        public GraphicsDeviceManager graphics;

        public IController mouse;
        public IController keyboard;
        public IController playerKeyboard;
        public IController roomController;

        //public List<SoundEffect> soundEffects;
        public Song menusong;
        public Song dungeonsong;

        public int xRoom = 515;
        public int yRoom = 826;

        public CollisionDetector CollisionDetector { get; set; }
        public SpriteBatch spriteBatch;

        public LegendOfZelda()
        {
            graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferHeight = 472,
                PreferredBackBufferWidth = 512
            };
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            //soundEffects = new List<SoundEffect>();
            
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.Window.Title = "The Legend of Zelda";
            state = new StartMenuState(this);
        }

        protected override void LoadContent()
        {
            this.menusong = Content.Load<Song>("intro");
            this.dungeonsong = Content.Load<Song>("dungeonsong");
            //soundEffects.Add(Content.Load<SoundEffect>("dooropened"));
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

        public void NewGame()
        {
            state.NewGame();
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