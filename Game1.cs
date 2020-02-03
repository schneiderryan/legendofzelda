using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Sprint0
{
    public class Game1 : Game
    {
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        IController keyboard;
        IController mouse;
        IScene background;

        public Texture2D SpriteSheet { get; set; }
        public ISprite Sprite { get; set; }
        IEnemy goriya;

        public Game1()
        {
            
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            EnemySpriteFactory.Instance.LoadTextures(Content);
            this.goriya = new Goriya();
        }

        protected override void Update(GameTime gameTime)
        {
            goriya.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // This gets rid of blurry scaling
            // https://gamedev.stackexchange.com/a/6822
            // spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            //background.Draw(spriteBatch);
            //Sprite.Draw(spriteBatch);
            //spriteBatch.End();
            spriteBatch.Begin();
            goriya.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        
    }
}