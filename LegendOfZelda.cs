using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class LegendOfZelda : Game
    {
        public IGameState state;
        public HeadsUpDisplay hud;

        public IList<IRoom> rooms;
        public int roomIndex;
        public bool OldManDamaged { get; set; }
        public int MyPlayerID { get; set; }
        public IPlayer Link
        {
            get => rooms[roomIndex].Players[MyPlayerID];
            set => rooms[roomIndex].Players[MyPlayerID] = value;
        }

        public ConeOfVision cone;

        public IProjectileManager ProjectileManager { get; set; }
        public GraphicsDeviceManager graphics;

        public string currentMode;
        public IController mouse;
        public IController keyboard;
        public IController playerKeyboard;

        public int xRoom;
        public int yRoom;

        public CollisionDetector CollisionDetector { get; set; }
        public SpriteBatch spriteBatch;
        public MusicLoop music;


        public LegendOfZelda()
        {
            graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferHeight = 472,
                PreferredBackBufferWidth = 512
            };
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            currentMode = "normal";
            base.Initialize();
            this.Window.Title = "The Legend of Zelda";
            state = new StartMenuState(this);
            hud = new HeadsUpDisplay(this);
            ProjectileManager = new ProjectileManager();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Textures.LoadAllTextures(Content, GraphicsDevice);
            Sounds.LoadAllSounds(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            state.Update();
            if (state.ToString().Equals("LegendOfZelda.PlayState") || state.ToString().Equals("LegendOfZelda.TransitionToInventoryState"))
            {
                hud.Update();
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);
            GraphicsDevice.Clear(Color.White);

            state.Draw();

            if (state.ToString().Equals("LegendOfZelda.PlayState") || state.ToString().Equals("LegendOfZelda.PauseState") || state.ToString().Equals("LegendOfZelda.InventoryState"))
            {
                hud.Draw();
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }

        public void ToStart()
        {
            state.ToStart();
        }

        public void NewGame()
        {
            state.NewGame();
        }

        public void SelectMode()
        {
            state.SelectMode();
        }

        public void PlayGame()
        {
            state.PlayGame();
        }

        public void PauseGame()
        {
            state.PauseGame();
        }

        public void OpenInventory()
        {
            state.OpenInventory();
        }

        public void CloseInventory()
        {
            state.CloseInventory();
        }
        public void ResumeGame()
        {
            state.ResumeGame();
        }

        public void ChangeRoom()
        {
            state.ChangeRoom();
        }

        public void WinGame()
        {
            state.WinGame();
        }

        public void LoseGame()
        {
            state.LoseGame();
        }

        public void SelectItem()
        {
            state.SelectItem();
        }

    }
}