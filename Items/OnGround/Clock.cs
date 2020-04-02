

namespace LegendOfZelda
{
    class Clock : Item
    {
        private LegendOfZelda game;

        public Clock(LegendOfZelda game)
        {
            sprite = ItemSpriteFactory.GetClock();
            Hitbox = sprite.Box;
            this.game = game;
        }

        public override void Collect(IPlayer player)
        {
            player.Inventory.HasClock = true;
            game.link = new DamagedLink(game);
        }
    }
}
