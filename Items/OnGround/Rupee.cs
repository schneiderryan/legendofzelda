
namespace LegendOfZelda
{
    class Rupee : Item
    {
        public Rupee()
        {
            sprite = ItemSpriteFactory.GetRupee();
            Hitbox = sprite.Box;
        }

        public override void Collect(IPlayer player)
        {
            player.Inventory.Rupees += 1;
        }
    }
}
