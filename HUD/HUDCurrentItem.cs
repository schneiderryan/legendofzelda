using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class HUDCurrentItem
    {
        private LegendOfZelda game;
        private int offset;
        private IItem item;
        private ISprite currentSprite;
        public HUDCurrentItem(LegendOfZelda game)
        {
            this.game = game;
            currentSprite = FontSpriteFactory.GetWhiteBox();
        }

        public void Update()
        {
            this.offset = game.hud.offset;
            System.Console.WriteLine(game.link.HeldItem);
            if(game.link.HeldItem.ToString().Equals("LegendOfZelda.Bomb"))
            {
                currentSprite = ItemSpriteFactory.GetBomb();
            }
            else if (game.link.HeldItem.ToString().Equals("LegendOfZelda.Boomerang"))
            {
                currentSprite = ItemSpriteFactory.GetBoomerang();
            }
            else if (game.link.HeldItem.ToString().Equals("LegendOfZelda.Arrow"))
            {
                currentSprite = ItemSpriteFactory.GetArrow();
            }
            currentSprite.X = 257;
            currentSprite.Y = offset + 55;
        }

        public void Draw()
        {
            if (game.link.HeldItem != null)
            {
                currentSprite.Draw(game.spriteBatch, Color.White);
            }
        }
    }
}
