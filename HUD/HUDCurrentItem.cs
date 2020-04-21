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
            if(game.link.CurrentItem.ToString().Equals("LegendOfZelda.Bomb"))
            {
                currentSprite = ItemSpriteFactory.GetBomb();
            }
            else if (game.link.CurrentItem.ToString().Equals("LegendOfZelda.Boomerang"))
            {
                currentSprite = ItemSpriteFactory.GetBoomerang();
            }
            else if (game.link.CurrentItem.ToString().Equals("LegendOfZelda.Arrow"))
            {
                currentSprite = ItemSpriteFactory.GetArrow();
            }
            currentSprite.X = 257;
            currentSprite.Y = offset + 55;
        }

        public void Draw()
        {
            if (game.link.CurrentItem != null)
            {
                currentSprite.Draw(game.spriteBatch, Color.White);
            }
        }
    }
}
