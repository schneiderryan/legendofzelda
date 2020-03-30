
namespace LegendOfZelda
{
    class Rupee : Item
    {
        public Rupee()
        {
            sprite = ItemSpriteFactory.GetRupee();
            Hitbox = sprite.Box;
        }

        public override void Pickup(IPlayer player)
        {
            player.Inventory.Rupees += 1;
        }
    }
}
