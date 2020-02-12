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

        IController keyboarda;
        IController keyboardb;
        IController keyboardc;
        public List<IEnemy> list;
        public int index;
        public int maxEnemy;
        public Texture2D EnemySpriteSheet { get; set; }
        public ISprite Sprite { get; set; }
        public IEnemy enemy;
        public Aquamentus aquamentus;
   
        public List<IItem> items;
        public IItem currentItem;
        public int currentIndex;
        public List<IProjectile> projectiles;

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
            this.Window.Title = "The Legend of Zelda";
            projectiles = new List<IProjectile>();

        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            EnemySpriteFactory.Instance.LoadTextures(Content);
            EnemySpriteSheet = Content.Load<Texture2D>("loz_enemy_sheet");
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
            keyboarda = new EnemyKeyboardController(this, binds);
            keyboardc = new KeyboardController(binds);


            Textures.LoadAllTextures(Content);
            PlayerSpriteFactory.Instance.LoadTextures(Content);
            ProjectileSpriteFactory.Instance.LoadTextures(Content);
            EnemySpriteFactory.Instance.LoadTextures(Content);

            this.link = new RedLink(this);

            Dictionary<Keys, ICommand> binds = GenerateKeyBinds();
            keyboard = new SinglePressKeyboardController(binds);
   
            keyboardb = new SinglePressKeyboardController(binds);

            items = GenerateItemList();
            currentIndex = 0;
            currentItem = items[currentIndex];
            
            this.goriya = new Goriya();
        }

        protected override void Update(GameTime gameTime)
        {
            keyboarda.Update();
            keyboardb.Update();
            keyboardc.Update();

            enemy.Update();

            currentItem.Update();
            foreach(IProjectile projectile in projectiles)
            {
                projectile.Update();
            }
           
            link.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

           
            spriteBatch.Begin();
            enemy.Draw(spriteBatch);
            if(enemy == aquamentus)
            {
                aquamentus.Draw(spriteBatch);
            }
            
 
            spriteBatch.End();
            

            spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            currentItem.Draw(spriteBatch);
            foreach (IProjectile projectile in projectiles)
            {
                projectile.Draw(spriteBatch);
            }
            
            link.Draw(spriteBatch, Color.White);
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

            
             cmd = new SwapItemCommand(this, "next");
            keyBinds.Add(Keys.I, cmd);

            cmd = new SwapItemCommand(this, "previous");
            keyBinds.Add(Keys.U, cmd);

            cmd = new QuitCommand(this);
            keyBinds.Add(Keys.NumPad0, cmd);
            keyBinds.Add(Keys.D0, cmd);
            
            cmd = new PlayerMoveLeftCommand(this.link);
            keyBinds.Add(Keys.Left, cmd);
            keyBinds.Add(Keys.A, cmd);

            cmd = new PlayerMoveRightCommand(this.link);
            keyBinds.Add(Keys.Right, cmd);
            keyBinds.Add(Keys.D, cmd);

            cmd = new PlayerMoveUpCommand(this.link);
            keyBinds.Add(Keys.Up, cmd);
            keyBinds.Add(Keys.W, cmd);

            cmd = new PlayerMoveDownCommand(this.link);
            keyBinds.Add(Keys.Down, cmd);
            keyBinds.Add(Keys.S, cmd);

            cmd = new PlayerDamagedCommand(this.link);
            keyBinds.Add(Keys.E, cmd);

            cmd = new PlayerAttackCommand(this.link);
            keyBinds.Add(Keys.Z, cmd);
            keyBinds.Add(Keys.N, cmd);

            cmd = new PlayerUseItem1Command(this.link);
            keyBinds.Add(Keys.D1, cmd);
            keyBinds.Add(Keys.NumPad1, cmd);

            cmd = new PlayerUseItem2Command(this.link);
            keyBinds.Add(Keys.D2, cmd);
            keyBinds.Add(Keys.NumPad2, cmd);

            cmd = new PlayerUseItem3Command(this.link);
            keyBinds.Add(Keys.D3, cmd);
            keyBinds.Add(Keys.NumPad3, cmd);

            cmd = new PlayerStillCommand(this.link);
            keyBinds.Add(Keys.None, cmd);

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