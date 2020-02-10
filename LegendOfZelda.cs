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
        IController keyboard;
        public WoodSword sword;
        public Bomb bomb;


        public IItem Arrow { get; set; }

        public LegendOfZelda()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
            sword = new WoodSword();
            bomb = new Bomb();
            sword.BeOnGround();
            this.Window.Title = "The Legend of Zelda";
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Textures.LoadAllTextures(Content);

            Dictionary<Keys, ICommand> binds = GenerateKeyBinds();
            keyboard = new KeyboardController(binds);
        }

        protected override void Update(GameTime gameTime)
        {
            keyboard.Update();
            sword.Update();
            bomb.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // This gets rid of blurry scaling
            // https://gamedev.stackexchange.com/a/6822
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);
            sword.Draw(spriteBatch);
            bomb.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        private Dictionary<Keys, ICommand> GenerateKeyBinds()
        {
            Dictionary<Keys, ICommand> keyBinds = new Dictionary<Keys, ICommand>();

            ICommand cmd = new CreateItemCommand(this);
            keyBinds.Add(Keys.NumPad4, cmd);
            keyBinds.Add(Keys.D4, cmd);

            cmd = new QuitCommand(this);
            keyBinds.Add(Keys.NumPad0, cmd);
            keyBinds.Add(Keys.D0, cmd);

            return keyBinds;
        }
    }
}