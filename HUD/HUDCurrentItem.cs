using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class HUDCurrentItem
    {
        private LegendOfZelda game;
        private IHeldItem item;
        public HUDCurrentItem(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Update()
        {
            this.item = game.link.Inventory.Offhand;
        }

        public void Draw()
        {
            if (this.item != null)
            {
                this.item.X = 257;
                this.item.Y = 55;
                this.item.Draw(game.spriteBatch, Color.White);
            }
        }
    }
}
