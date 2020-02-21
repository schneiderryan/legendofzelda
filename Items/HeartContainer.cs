
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
        public override void Use(IPlayer player)
        {
            player.maxHearts += 1.0;
            player.currentHearts += 1.0;
        }
    }
}