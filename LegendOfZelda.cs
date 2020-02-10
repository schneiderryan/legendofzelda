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
        IController keyboard;

        // remove this l8r
        public Boomerang testItem;

        public List<IItem> items;
        public IItem currentItem;
        public int currentIndex;

        public IItem Arrow { get; set; }
        public Texture2D SpriteSheet { get; set; }
        public ISprite Sprite { get; set; }
        IEnemy goriya;

        public LegendOfZelda()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
            testItem = new Boomerang();
            this.Window.Title = "The Legend of Zelda";
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Textures.LoadAllTextures(Content);

            Dictionary<Keys, ICommand> binds = GenerateKeyBinds();
            keyboard = new SinglePressKeyboardController(binds);

            items = new List<IItem>
            {
                new Arrow(),
                new WoodSword(),
                new Bomb(),
                new Boomerang()
            };
            currentIndex = 0;
            currentItem = items[currentIndex];
            EnemySpriteFactory.Instance.LoadTextures(Content);
            this.goriya = new Goriya();
        }

        protected override void Update(GameTime gameTime)
        {
            keyboard.Update();
            testItem.Update();
            if (currentItem != null)
            {
                currentItem.Update();
            }
            goriya.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // This gets rid of blurry scaling
            https://gamedev.stackexchange.com/a/6822
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            if (currentItem != null)
            {
                currentItem.Draw(spriteBatch);
            }
            goriya.Draw(spriteBatch);
            testItem.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        private Dictionary<Keys, ICommand> GenerateKeyBinds()
        {
            Dictionary<Keys, ICommand> keyBinds = new Dictionary<Keys, ICommand>();

            ICommand cmd = new CreateSwordCommand(this);
            keyBinds.Add(Keys.NumPad5, cmd);
            keyBinds.Add(Keys.D5, cmd);

            cmd = new TestCommand(this);
            keyBinds.Add(Keys.NumPad4, cmd);
            keyBinds.Add(Keys.D4, cmd);

            cmd = new QuitCommand(this);
            keyBinds.Add(Keys.NumPad0, cmd);
            keyBinds.Add(Keys.D0, cmd);

            cmd = new SwapItemCommand(this, "next");
            keyBinds.Add(Keys.I, cmd);

            cmd = new SwapItemCommand(this, "previous");
            keyBinds.Add(Keys.U, cmd);

            return keyBinds;
        }
    }
}