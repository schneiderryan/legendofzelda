
namespace LegendOfZelda
{
    class BlueRupee : Item
    {
        public BlueRupee()
        {
            sprite = ItemSpriteFactory.GetBlueRupee();
            Hitbox = sprite.Box;
        }

        public override void Pickup(IPlayer player)
        {
            player.Inventory.Rupees += 5;
        }
    }
}
