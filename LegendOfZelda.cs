﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace LegendOfZelda
{
    public class LegendOfZelda : Game
    {
        public IController playerKeyboard;
        public IController enemyKeyboard;
        public IController keyboard;

        public List<IEnemy> enemies;
        public int enemyIndex = 0;
        public List<IItem> items;
        public int itemIndex = 0;
        public List<IItem> itemsOnGround;
        public List<IItem> itemsToRemove;

        public List<IProjectile> projectiles;
        public IPlayer link;

        public GraphicsDeviceManager graphics;

        private SpriteBatch spriteBatch;

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
            this.link = new GreenLink(this);

            keyboard = GameSetup.CreateGeneralKeysController(this);
            playerKeyboard = GameSetup.CreatePlayerKeysController(link);
            enemyKeyboard = GameSetup.CreateEnemyKeysController(this);

            items = GameSetup.GenerateItemList();
            itemsOnGround = GameSetup.GenerateItemsOnGround();
            enemies = GameSetup.GenerateEnemyList();
            itemsToRemove = new List<IItem>()
            {

            };
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Textures.LoadAllTextures(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            keyboard.Update();
            playerKeyboard.Update();
            enemyKeyboard.Update();

            enemies[enemyIndex].Update();
            items[itemIndex].Update();
            foreach (IItem groundItem in itemsOnGround)
            {
                groundItem.Update();
                if ((groundItem.X == link.xPos) && (groundItem.Y == link.yPos))
                {
                    groundItem.Use(link);
                    itemsToRemove.Add(groundItem);
                }
            }
            if (itemsToRemove != null && itemsToRemove.Count > 0)
            {
                foreach (IItem itemToRemove in itemsToRemove)
                {
                    itemsOnGround.Remove(itemToRemove);
                }
                itemsToRemove.Clear();
            }
            link.Update();

            foreach (IProjectile projectile in projectiles)
            {
                projectile.Update();
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            enemies[enemyIndex].Draw(spriteBatch);
            items[itemIndex].Draw(spriteBatch);
            link.Draw(spriteBatch, Color.White);
            foreach (IItem groundItem in itemsOnGround)
            {
                groundItem.Draw(spriteBatch);
            }

            foreach (IProjectile projectile in projectiles)
            {
                projectile.Draw(spriteBatch);
            }
            
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}