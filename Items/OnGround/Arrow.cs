
namespace LegendOfZelda
{
    class Arrow : Item
    {
        public Arrow()
        {
            sprite = ItemSpriteFactory.GetArrow();
            Hitbox = sprite.Box;
        }

        public override void Collect(IPlayer player)
        {
            player.PickupItem(this, 50, false);
            player.Inventory.HasArrow = true;
        }
    }
}
