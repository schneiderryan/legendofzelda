

namespace LegendOfZelda
{
    class RedRing : Item
    {
        private LegendOfZelda game;

        public RedRing(LegendOfZelda game)
        {
            sprite = ItemSpriteFactory.GetRedRing();
            Hitbox = sprite.Box;
            this.game = game;
        }

        public override void Collect(IPlayer player)
        {
            if (!player.Color.Equals("red"))
            {
                game.link = new RedLink(player);
            }
        }
    }
}
