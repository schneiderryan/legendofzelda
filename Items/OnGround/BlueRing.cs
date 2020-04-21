

namespace LegendOfZelda
{
    class BlueRing : Item
    {
        private LegendOfZelda game;
        public BlueRing(LegendOfZelda game)
        {
            sprite = ItemSpriteFactory.GetBlueRing();
            Hitbox = sprite.Box;
            this.game = game;
        }

        public override void Collect(IPlayer player)
        {
            if (!player.Color.Equals("blue"))
            {
                game.link = new BlueLink(player);
            }
        }
    }
}
