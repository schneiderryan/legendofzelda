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
        IController random;
        IScene background;

        public Texture2D SpriteSheet { get; set; }
        public ISprite Sprite { get; set; }
        public IEnemy goriya;
        public IEnemy goriya2;
        public IEnemy goriya3;
        public IEnemy goriya4;
        public IEnemy keese;
        public IEnemy keese2;
        public IEnemy keese3;
        public IEnemy keese4;
        public IEnemy stalfo;
        public IEnemy stalfo2;
        public IEnemy stalfo3;
        public IEnemy stalfo4;
        public IEnemy lfwallmaster;
        public IEnemy lfwallmaster2;
        public IEnemy rfwallmaster;
        public IEnemy rfwallmaster2;


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
            this.goriya2 = new Goriya();
            this.goriya3 = new Goriya();
            this.goriya4 = new Goriya();
            this.keese = new Keese();
            this.keese2 = new Keese();
            this.keese3 = new Keese();
            this.keese4 = new Keese();
            this.stalfo = new Stalfo();
            this.stalfo2 = new Stalfo();
            this.stalfo3 = new Stalfo();
            this.stalfo4 = new Stalfo();
            this.lfwallmaster = new LFWallmaster();
            this.lfwallmaster2 = new LFWallmaster();
            this.rfwallmaster = new RFWallmaster();
            this.rfwallmaster2 = new RFWallmaster();

            random = new RandomEnemyController(this.goriya);
            random = new RandomEnemyController(this.goriya2);
            random = new RandomEnemyController(this.goriya3);
            random = new RandomEnemyController(this.goriya4);
            random = new RandomEnemyController(this.keese);
            random = new RandomEnemyController(this.keese2);
            random = new RandomEnemyController(this.keese3);
            random = new RandomEnemyController(this.keese4);
            random = new RandomEnemyController(this.stalfo);
            random = new RandomEnemyController(this.stalfo2);
            random = new RandomEnemyController(this.stalfo3);
            random = new RandomEnemyController(this.stalfo4);
            random = new RandomEnemyController(this.lfwallmaster);
            random = new RandomEnemyController(this.lfwallmaster2);
            random = new RandomEnemyController(this.rfwallmaster);
            random = new RandomEnemyController(this.rfwallmaster2);
        }

        protected override void Update(GameTime gameTime)
        {
            goriya.Update();
            goriya2.Update();
            goriya3.Update();
            goriya4.Update();
            keese.Update();
            keese2.Update();
            keese3.Update();
            keese4.Update();
            stalfo.Update();
            stalfo2.Update();
            stalfo3.Update();
            stalfo4.Update();
            lfwallmaster.Update();
            lfwallmaster2.Update();
            rfwallmaster.Update();
            rfwallmaster2.Update();
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
            goriya2.Draw(spriteBatch);
            goriya3.Draw(spriteBatch);
            goriya4.Draw(spriteBatch);
            keese.Draw(spriteBatch);
            keese2.Draw(spriteBatch);
            keese3.Draw(spriteBatch);
            keese4.Draw(spriteBatch);
            stalfo.Draw(spriteBatch);
            stalfo2.Draw(spriteBatch);
            stalfo3.Draw(spriteBatch);
            stalfo4.Draw(spriteBatch);
            lfwallmaster.Draw(spriteBatch);
            lfwallmaster2.Draw(spriteBatch);
            rfwallmaster.Draw(spriteBatch);
            rfwallmaster2.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        
    }
}