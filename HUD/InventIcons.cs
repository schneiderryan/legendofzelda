

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
        private int firstRowY;
        private int mapCompassX;
        private ISprite currentSprite;
        private ISprite selector;
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
            currentSprite = FontSpriteFactory.GetWhiteBox();
            compass = ItemSpriteFactory.GetCompass();
            compass.X = mapCompassX;
            compass.Y = 300;
            selector = ItemSpriteFactory.GetItemSelector();
        }

        public void Update()
        {
            if (game.link.CurrentItem.ToString().Equals("LegendOfZelda.Bomb"))
            {
                currentSprite = ItemSpriteFactory.GetBomb();
                selector.X = bomb.X;
                selector.Y = bomb.Y;
            }
            else if (game.link.CurrentItem.ToString().Equals("LegendOfZelda.Boomerang"))
            {
                currentSprite = ItemSpriteFactory.GetBoomerang();
                selector.X = boomerang.X;
                selector.Y = boomerang.Y;
            }
            else if (game.link.CurrentItem.ToString().Equals("LegendOfZelda.Arrow"))
            {
                currentSprite = ItemSpriteFactory.GetArrow();
                selector.X = arrow.X;
                selector.Y = arrow.Y;
            }
            currentSprite.X = 145;
            currentSprite.Y = firstRowY - 5;
            selector.X = selector.X - 5;
        }

        public void Draw()
        {
           if(game.link.Inventory.Boomerang.Level > 0)
            {
                boomerang.Draw(game.spriteBatch);
            }
           if(inventory.Bombs > 0)
            {
                bomb.Draw(game.spriteBatch);
            }
            if (game.link.Inventory.HasArrow)
            {
                arrow.Draw(game.spriteBatch);
            }
            if (game.link.Inventory.HasBow)
            {
                bow.Draw(game.spriteBatch);
            }
            if (game.link.Inventory.HasMap)
            {
                map.Draw(game.spriteBatch);
            }
            if (game.link.Inventory.HasCompass)
            {
                compass.Draw(game.spriteBatch);
            }
            currentSprite.Draw(game.spriteBatch);
            selector.Draw(game.spriteBatch);
        }
    }
}
