
namespace LegendOfZelda
{
    class TriforceShard : Item
    {
        private LegendOfZelda game;
        public TriforceShard(LegendOfZelda game)
        {
            sprite = ItemSpriteFactory.GetTriforceShard();
            Hitbox = sprite.Box;
            this.game = game;
        }

        public override void Use(IPlayer player)
        {
            player.PickupItem(new TriforceShard(game), -1);
            game.WinGame();
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                        