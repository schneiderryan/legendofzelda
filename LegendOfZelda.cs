using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{
    class LegendOfZelda : Game
    {
        private IController mouse;
        private IController keyboard;
        private IController playerKeyboard;
        public List<Room> rooms;
        public Room currentRoom;
        public int roomIndex = 0;

        public IPlayer link;

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
            currentRoom = rooms[0];
            
            
            mouse = new MouseController(this);
            keyboard = GameSetup.CreateGeneralKeysController(this);
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

            link.Update();
            currentRoom.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);
            
            currentRoom.Draw(spriteBatch);
            link.Draw(spriteBatch, Color.White);
            currentRoom.DrawDoors(spriteBatch);
            currentRoom.DrawOverlay(spriteBatch);
            foreach(Rectangle hitbox in currentRoom.hitboxes)
            {
                Debug.DrawHitbox(spriteBatch,hitbox);
            }
            
            Debug.DrawHitbox(spriteBatch, link.Hitbox);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}