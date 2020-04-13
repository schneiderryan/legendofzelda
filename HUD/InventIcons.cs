using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class InventIcons
    {
        private LegendOfZelda game;
        private IInventory inventory;
        private ISprite boomerang;
        private ISprite bomb;
        private ISprite bow;
        private ISprite arrow;
        private ISprite candle;
        private ISprite map;
        private ISprite compass;
        private int firstRowY;
        private int mapCompassX;
        private ISprite currentItem;
        public InventIcons(LegendOfZelda game)
        {
            firstRowY = 75;
            mapCompassX = 100;
            this.game = game;
            this.inventory = game.link.Inventory;
            boomerang = ItemSpriteFactory.GetBoomerang();
            boomerang.X = 275;
            boomerang.Y = firstRowY;
            bomb = ItemSpriteFactory.GetBomb();
            bomb.X = boomerang.X + 40;
            bomb.Y = firstRowY - 5;
            arrow = ItemSpriteFactory.GetArrow();
            arrow.X = bomb.X + 40;
            arrow.Y = bomb.Y;
            bow = ItemSpriteFactory.GetBow();
            bow.X = arrow.X + 15;
            bow.Y = arrow.Y;
            //candle = ItemSpriteFactory.GetCandle();
            map = ItemSpriteFactory.GetMap();
            map.X = mapCompassX;
            map.Y = 220;
            compass = ItemSpriteFactory.GetCompass();
            compass.X = mapCompassX;
            compass.Y = 300;
            currentItem = ItemSpriteFactory.GetArrow();
            currentItem.X = 145;
            currentItem.Y = firstRowY - 5;
    }

        public void Update()
        {
            //Nothing to do
        }

        public void Draw()
        {
           if(true)
            {
                boomerang.Draw(game.spriteBatch);
            }
           if(inventory.Bombs > 0)
            {
                bomb.Draw(game.spriteBatch);
            }
            if (true)
            {
                arrow.Draw(game.spriteBatch);
            }
            if (true)
            {
                bow.Draw(game.spriteBatch);
            }
            if (true)
            {
                map.Draw(game.spriteBatch);
            }
            if (true)
            {
                compass.Draw(game.spriteBatch);
            }
            currentItem.Draw(game.spriteBatch);
        }
    }
}
