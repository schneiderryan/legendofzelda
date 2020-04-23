using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class HUDCurrentItem
    {
        private LegendOfZelda game;
        private int offset;
        private ISprite currentSprite;
        public HUDCurrentItem(LegendOfZelda game)
        {
            this.game = game;
            currentSprite = FontSpriteFactory.GetWhiteBox();
        }

        public void Update()
        {
            this.offset = game.hud.offset;
            if(game.Link.CurrentItem.ToString().Equals("LegendOfZelda.Bomb"))
            {
                currentSprite = ItemSpriteFactory.GetBomb();
            }
            else if (game.Link.CurrentItem.ToString().Equals("LegendOfZelda.Boomerang"))
            {
                currentSprite = ItemSpriteFactory.GetBoomerang();
            }
            else if (game.Link.CurrentItem.ToString().Equals("LegendOfZelda.Arrow"))
            {
                currentSprite = ItemSpriteFactory.GetArrow();
            }
            else if (game.Link.CurrentItem.ToString().Equals("LegendOfZelda.BlueCandle"))
            {
                currentSprite = ItemSpriteFactory.GetBlueCandle();
            } else if (game.Link.CurrentItem.ToString().Equals("LegendOfZelda.BluePotion"))
            {
                currentSprite = ItemSpriteFactory.GetBluePotion();
            } else if (game.Link.CurrentItem.ToString().Equals("LegendOfZelda.RedPotion"))
            {
                currentSprite = ItemSpriteFactory.GetRedPotion();
            }
            currentSprite.X = 257;
            currentSprite.Y = offset + 55;
        }

        public void Draw()
        {
            if (game.Link.CurrentItem != null)
            {
                if (!(game.Link.CurrentItem.ToString().Equals("LegendOfZelda.Boomerang") && (game.Link.Inventory.Boomerang.Level == 0)))
                {
                    currentSprite.Draw(game.spriteBatch, Color.White);
                }
            }
        }
    }
}
