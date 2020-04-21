
namespace LegendOfZelda
{
    class HeartContainer : Item
    {
        public HeartContainer()
        {
            sprite = ItemSpriteFactory.GetHeartContainer();
            Hitbox = sprite.Box;
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Collect(IPlayer player)
        {
            if (player.HeartsCanChange)
            {
                player.MaxHearts += 1.0;
                player.CurrentHearts += 1.0;
            }
        }
    }
}
