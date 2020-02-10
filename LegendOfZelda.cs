﻿using Microsoft.Xna.Framework;
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
        IController mouse;
        IScene background;
        public WoodSword sword;
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
            this.Window.Title = "Legend of Zelda";
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            SpriteSheet = Content.Load<Texture2D>("items_mod");
            background = new BackgroundScene(Content.Load<SpriteFont>("PressStart2P"),
                    this.GraphicsDevice);
            Textures.LoadAllTextures(Content);

            Dictionary<Keys, ICommand> binds = GenerateKeyBinds();
            //binds[Keys.D1].Execute(); // sets Sprite to a static sprite
            keyboard = new KeyboardController(binds);
            mouse = new MouseController(this);
            Sprite = ItemSpriteFactory.GetExplodingBomb();
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
<<<<<<< HEAD:LegendOfZelda.cs
            keyboard.Update();
            mouse.Update();
            Sprite.Update();
            if (currentItem != null)
            {
                currentItem.Update();
            }
=======
            goriya.Update();
>>>>>>> 13c1858d758aae16be47ef65e6e8d6c186945d1f:Game1.cs
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // This gets rid of blurry scaling
            // https://gamedev.stackexchange.com/a/6822
            // spriteBatch.Begin(samplerState: SamplerState.PointClamp);

<<<<<<< HEAD:LegendOfZelda.cs
            background.Draw(spriteBatch);
            Sprite.Draw(spriteBatch);
            if (currentItem != null)
            {
                currentItem.Draw(spriteBatch);
            }
=======
            //background.Draw(spriteBatch);
            //Sprite.Draw(spriteBatch);
            //spriteBatch.End();
            spriteBatch.Begin();
            goriya.Draw(spriteBatch);
>>>>>>> 13c1858d758aae16be47ef65e6e8d6c186945d1f:Game1.cs
            spriteBatch.End();

            base.Draw(gameTime);
        }

<<<<<<< HEAD:LegendOfZelda.cs
        private Dictionary<Keys, ICommand> GenerateKeyBinds()
        {
            Dictionary<Keys, ICommand> keyBinds = new Dictionary<Keys, ICommand>();

            ICommand cmd = new CreateSwordCommand(this);
            keyBinds.Add(Keys.NumPad5, cmd);
            keyBinds.Add(Keys.D5, cmd);

            cmd = new ThrowSwordDownCommand(this);
            keyBinds.Add(Keys.NumPad4, cmd);
            keyBinds.Add(Keys.D4, cmd);

            cmd = new MoveSpriteCommand(this);
            keyBinds.Add(Keys.NumPad3, cmd);
            keyBinds.Add(Keys.D3, cmd);

            cmd = new AnimatedSpriteCommand(this);
            keyBinds.Add(Keys.NumPad2, cmd);
            keyBinds.Add(Keys.D2, cmd);

            cmd = new StaticSpriteCommand(this);
            keyBinds.Add(Keys.NumPad1, cmd);
            keyBinds.Add(Keys.D1, cmd);

            cmd = new QuitCommand(this);
            keyBinds.Add(Keys.NumPad0, cmd);
            keyBinds.Add(Keys.D0, cmd);

            cmd = new SwapItemCommand(this, "next");
            keyBinds.Add(Keys.I, cmd);

            cmd = new SwapItemCommand(this, "previous");
            keyBinds.Add(Keys.U, cmd);

            return keyBinds;
        }
=======
        
>>>>>>> 13c1858d758aae16be47ef65e6e8d6c186945d1f:Game1.cs
    }
}