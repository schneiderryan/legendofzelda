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
        public Aquamentus aquamentus;
        

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
            aquamentus = new Aquamentus();
    
            list.Add(enemy);
            list.Add(new Goriya());
            list.Add(new Keese());
            list.Add(new Stalfo());
            list.Add(new Trap());
            list.Add(new LFWallmaster());
            list.Add(new RFWallmaster());
            list.Add(aquamentus);
            maxEnemy = list.Count-1;
            Dictionary <Keys, ICommand> binds = GenerateKeyBinds();
            //binds[Keys.O].Execute();
            keyboard = new KeyboardController(this, binds);
            
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
            if(enemy == aquamentus)
            {
                aquamentus.Draw(spriteBatch);
            }
            
 
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

            cmd = new BreatheFireballCommand(this);
            keyBinds.Add(Keys.F, cmd);


            return keyBinds;
        }


    }
}