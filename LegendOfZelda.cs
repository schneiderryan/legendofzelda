using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace LegendOfZelda
{
    public class LegendOfZelda : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
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
            PlayerSpriteFactory.Instance.LoadTextures(Content);
            this.link = new GreenLink();
        }

        protected override void Update(GameTime gameTime)
        {
            link.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            //// This gets rid of blurry scaling
            //// https://gamedev.stackexchange.com/a/6822
            //spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            //background.Draw(spriteBatch);
            //Sprite.Draw(spriteBatch);
            //spriteBatch.End();

            spriteBatch.Begin();
            link.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }

        //private Dictionary<Keys, ICommand> GenerateKeyBinds()
        //{
        //    Dictionary<Keys, ICommand> keyBinds = new Dictionary<Keys, ICommand>();

        //    ICommand cmd = new DancingSpriteCommand(this);
        //    keyBinds.Add(Keys.NumPad4, cmd);
        //    keyBinds.Add(Keys.D4, cmd);

        //    cmd = new MoveSpriteCommand(this);
        //    keyBinds.Add(Keys.NumPad3, cmd);
        //    keyBinds.Add(Keys.D3, cmd);

        //    cmd = new AnimatedSpriteCommand(this);
        //    keyBinds.Add(Keys.NumPad2, cmd);
        //    keyBinds.Add(Keys.D2, cmd);

        //    cmd = new StaticSpriteCommand(this);
        //    keyBinds.Add(Keys.NumPad1, cmd);
        //    keyBinds.Add(Keys.D1, cmd);

        //    cmd = new QuitCommand(this);
        //    keyBinds.Add(Keys.NumPad0, cmd);
        //    keyBinds.Add(Keys.D0, cmd);

        //    return keyBinds;
        //}
    }
}