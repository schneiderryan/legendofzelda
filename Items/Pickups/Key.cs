
namespace LegendOfZelda
{
    class Key : Item
    {
        public Key()
        {
            sprite = ItemSpriteFactory.GetKey();
            Hitbox = sprite.Box;
        }

        public override void Pickup(IPlayer player)
        {
            player.Inventory.Keys += 1;
        }
    }
}
