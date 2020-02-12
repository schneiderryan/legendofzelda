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

        public List<IItem> items;
        public IItem currentItem;
        public int currentIndex;

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
            this.Window.Title = "The Legend of Zelda";
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Textures.LoadAllTextures(Content);

            Dictionary<Keys, ICommand> binds = GenerateKeyBinds();
            keyboard = new SinglePressKeyboardController(binds);

            items = GenerateItemList();
            currentIndex = 0;
            currentItem = items[currentIndex];
            EnemySpriteFactory.Instance.LoadTextures(Content);
            this.goriya = new Goriya();
        }

        protected override void Update(GameTime gameTime)
        {
            keyboard.Update();
            currentItem.Update();
            goriya.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // This gets rid of blurry scaling
            // https://gamedev.stackexchange.com/a/6822
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            currentItem.Draw(spriteBatch);
            goriya.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        private Dictionary<Keys, ICommand> GenerateKeyBinds()
        {
            Dictionary<Keys, ICommand> keyBinds = new Dictionary<Keys, ICommand>();

            ICommand cmd = new SwapItemCommand(this, "next");
            keyBinds.Add(Keys.I, cmd);

            cmd = new SwapItemCommand(this, "previous");
            keyBinds.Add(Keys.U, cmd);

            cmd = new QuitCommand(this);
            keyBinds.Add(Keys.NumPad0, cmd);
            keyBinds.Add(Keys.D0, cmd);

            return keyBinds;
        }

        private static List<IItem> GenerateItemList()
        {
            List<IItem> list = new List<IItem>()
            {
                new Arrow(),
                new BlueRupee(),
                new Bomb(),
                new Boomerang(),
                new Bow(),
                new Compass(),
                new Fairy(),
                new Heart(),
                new HeartContainer(),
                new Key(),
                new Map(),
                new Rupee(),
                new TriforceShard(),
                new WoodSword(),
            };

            foreach (IItem i in list)
            {
                i.X = 100;
                i.Y = 100;
            }

            return list;
        }
    }
}