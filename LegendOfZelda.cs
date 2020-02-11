using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace LegendOfZelda
{
    public class LegendOfZelda : Game
    {
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        IEnemy goriya;
        public IPlayer link;

        public LegendOfZelda()
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
            PlayerSpriteFactory.Instance.LoadTextures(Content);
            this.link = new GreenLink(this);
        }

        protected override void Update(GameTime gameTime)
        {
            goriya.Update();
            link.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            goriya.Draw(spriteBatch);
            spriteBatch.End();

            spriteBatch.Begin();
            link.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}