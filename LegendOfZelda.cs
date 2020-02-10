using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace LegendOfZelda
{
    public class Game1 : Game
    {
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;

        IController keyboard;
        IController mouse;
        IController random;
        IScene background;
        public List<IEnemy> list;
        public int index;
        public int maxEnemy;
        public Texture2D SpriteSheet { get; set; }
        public ISprite Sprite { get; set; }
        public IEnemy enemy;
        

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
            SpriteSheet = Content.Load<Texture2D>("loz_enemy_sheet");
            list = new List<IEnemy>();
            index = 0;
            
            enemy = new Gel();
    
            list.Add(enemy);
            list.Add(new Goriya());
            list.Add(new Keese());
            list.Add(new Stalfo());
            list.Add(new Trap());
            list.Add(new LFWallmaster());
            list.Add(new RFWallmaster());
            list.Add(new Aquamentus());
            maxEnemy = list.Count-1;
            Dictionary <Keys, ICommand> binds = GenerateKeyBinds();
            //binds[Keys.O].Execute();
            keyboard = new KeyboardController(this, binds);
            
            /*random = new RandomEnemyController(this.trap);
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
            */
        }

        protected override void Update(GameTime gameTime)
        {
    
            keyboard.Update();
            enemy.Update();
           
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
            enemy.Draw(spriteBatch);
            /*
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
            */
           
            spriteBatch.End();
            
            base.Draw(gameTime);
        }

        private Dictionary<Keys, ICommand> GenerateKeyBinds()
        {
            Dictionary<Keys, ICommand> keyBinds = new Dictionary<Keys, ICommand>();
            
            ICommand cmd = new EnemyMoveUpCommand(enemy);
            keyBinds.Add(Keys.O, cmd);

            cmd = new EnemyMoveUpCommand(enemy);
            keyBinds.Add(Keys.P, cmd);

            

            return keyBinds;
        }


    }
}