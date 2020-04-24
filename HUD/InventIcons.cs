

using Microsoft.Xna.Framework;

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
        private ISprite map;
        private ISprite compass;
        private ISprite blueCandle;
        private ISprite bluePotion;
        private ISprite redPotion;
        private int initX;
        private int firstRowY;
        private int secondRowY;
        private int mapCompassX;
        private int mapY;
        private int compassY;
        private ISprite currentSprite;
        private int currentSpriteX;
        private ISprite selector;
        private int currentDelay;
        private int totalDelay;
        private int itemDiff;
        private int smallDiff;
        private int bowDiff;

        public InventIcons(LegendOfZelda game)
        {
            itemDiff = 40;
            smallDiff = 5;
            firstRowY = 75;
            secondRowY = 105;
            bowDiff = 15;
            mapCompassX = 100;
            mapY = 220;
            compassY = 300;
            currentSpriteX = 145;
            initX = 275;
            this.game = game;
            this.inventory = game.Link.Inventory;
            boomerang = ItemSpriteFactory.GetBoomerang();
            boomerang.X = initX;
            boomerang.Y = firstRowY;
            bomb = ItemSpriteFactory.GetBomb();
            bomb.X = boomerang.X + itemDiff;
            bomb.Y = firstRowY - smallDiff;
            arrow = ItemSpriteFactory.GetArrow();
            arrow.X = bomb.X + itemDiff;
            arrow.Y = bomb.Y;
            bow = ItemSpriteFactory.GetBow();
            bow.X = arrow.X + bowDiff;
            bow.Y = arrow.Y;
            blueCandle = ItemSpriteFactory.GetBlueCandle();
            blueCandle.Scale = 2;
            blueCandle.X = arrow.X + itemDiff + smallDiff;
            blueCandle.Y = arrow.Y;
            bluePotion = ItemSpriteFactory.GetBluePotion();
            bluePotion.X = bow.X;
            bluePotion.Y = secondRowY;
            redPotion = ItemSpriteFactory.GetRedPotion();
            redPotion.X = bluePotion.X;
            redPotion.Y = bluePotion.Y;
            map = ItemSpriteFactory.GetMap();
            map.X = mapCompassX;
            map.Y = mapY;
            currentSprite = FontSpriteFactory.GetWhiteBox();
            compass = ItemSpriteFactory.GetCompass();
            compass.X = mapCompassX;
            compass.Y = compassY;
            selector = ItemSpriteFactory.GetItemSelector();
            currentDelay = 0;
            totalDelay = smallDiff;
        }

        public void Update()
        {

            currentDelay++;
            if (currentDelay == totalDelay)
            {
                selector.Update();
                currentDelay = 0;
            }
            if (game.Link.CurrentItem.ToString().Equals("LegendOfZelda.Bomb"))
            {
                currentSprite = ItemSpriteFactory.GetBomb();
                selector.X = bomb.X;
                selector.Y = bomb.Y;
            }
            else if (game.Link.CurrentItem.ToString().Equals("LegendOfZelda.Boomerang"))
            {
                currentSprite = ItemSpriteFactory.GetBoomerang();
                selector.X = boomerang.X;
                selector.Y = boomerang.Y;
            }
            else if (game.Link.CurrentItem.ToString().Equals("LegendOfZelda.Arrow"))
            {
                currentSprite = ItemSpriteFactory.GetArrow();
                selector.X = arrow.X;
                selector.Y = arrow.Y;
            } else if (game.Link.CurrentItem.ToString().Equals("LegendOfZelda.BlueCandle"))
            {
                currentSprite = ItemSpriteFactory.GetBlueCandle();
                currentSprite.Scale = 2;
                selector.X = blueCandle.X;
                selector.Y = blueCandle.Y;
            } 
            else if (game.Link.CurrentItem.ToString().Equals("LegendOfZelda.BluePotion"))
            {
                currentSprite = ItemSpriteFactory.GetBluePotion();
                selector.X = bluePotion.X;
                selector.Y = bluePotion.Y;
            }
            else if (game.Link.CurrentItem.ToString().Equals("LegendOfZelda.RedPotion"))
            {
                currentSprite = ItemSpriteFactory.GetRedPotion();
                selector.X = redPotion.X;
                selector.Y = redPotion.Y;
            }
            currentSprite.X = currentSpriteX;
            currentSprite.Y = firstRowY - smallDiff;
            selector.X = selector.X - smallDiff;
        }

        public void Draw()
        {
           if(game.Link.Inventory.Boomerang.Level > 0)
            {
                boomerang.Draw(game.spriteBatch);
            }
           if(inventory.Bombs > 0)
            {
                bomb.Draw(game.spriteBatch);
            }
            if (game.Link.Inventory.HasArrow)
            {
                arrow.Draw(game.spriteBatch);
            }
            if (game.Link.Inventory.HasBow)
            {
                bow.Draw(game.spriteBatch);
            }
            if (game.Link.Inventory.HasMap)
            {
                map.Draw(game.spriteBatch);
            }
            if (game.Link.Inventory.HasCompass)
            {
                compass.Draw(game.spriteBatch);
            }
            if (game.Link.Inventory.BlueCandle.Found)
            {
                blueCandle.Draw(game.spriteBatch);
            }
            if (game.Link.Inventory.HasBluePotion)
            {
                bluePotion.Draw(game.spriteBatch);
            }
            if (!(game.Link.CurrentItem.ToString().Equals("LegendOfZelda.Boomerang") && (game.Link.Inventory.Boomerang.Level == 0)))
            {
                currentSprite.Draw(game.spriteBatch, Color.White);
            }
            selector.Draw(game.spriteBatch);
        }
    }
}
